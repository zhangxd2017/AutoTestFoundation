using AutoTestFoundation.Model;

namespace AutoTestFoundation.Manager
{
    class UserManager
    {
        private static UserManager instance = null;

        private static readonly object locker = new object();

        private User user;

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

        public User GetCurrentUser()
        {
            return user;
        }

    }
}
