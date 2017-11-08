

namespace AutoTestFoundation.Model
{
    class User
    {
        /// <summary>
        /// 操作员
        /// </summary>
        public static User TestUser = new User("Test", "");

        public string name;

        public string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        /// <summary>
        /// 是否管理员账号
        /// </summary>
        /// <returns></returns>
        public bool IsAdmin()
        {
            return !name.Equals(TestUser.name);
        }

    }
}
