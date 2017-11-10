using AutoTestFoundation.Model;
using AutoTestFoundation.Util;
using System.Collections.Generic;

namespace AutoTestFoundation.Manager
{
    class UserManager
    {
        public static string DATABASE_TABLE_USER_NAME = "user";

        private static UserManager instance = null;

        private static readonly object locker = new object();

        private User user;

        private List<User> users = new List<User>();

        private UserManager()
        {
            user = User.TestUser;
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        public static UserManager GetUserManager()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new UserManager();
                    }
                }
            }
            return instance;
        }

        public void SetCurrentUser(User currentUser)
        {
            user = currentUser;
        }

        public User GetCurrentUser()
        {
            return user;
        }

        public void InitWithConfig(string path)
        {
            lock (locker)
            {
                DataBaseManager.GetInstance().Init(path);
                List<User> dbUser = DataBaseManager.GetInstance().GetDatas<User>(DATABASE_TABLE_USER_NAME);
                DataBaseManager.GetInstance().Deinit();
                for (int i = 0; i < dbUser.Count; i++)
                {
                    users.Add(dbUser[i]);
                }
            }
        }

        public List<User> GetUsers()
        {
            lock (locker)
            {
                return users;
            }
        }

        public bool ContainsUserName(string username)
        {
            lock (locker)
            {
                foreach (User user in users)
                {
                    if (user.Name.Equals(username))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool ValidateUserNameAndPassword(string username, string password)
        {
            lock (locker)
            {
                foreach (User user in users)
                {
                    if (user.Name.Equals(username) && user.Password.Equals(CryptoUtil.MD5String(password)))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
