

namespace AutoTestFoundation.Model
{
    class User
    {
        /// <summary>
        /// 操作员
        /// </summary>
        public static User TestUser = new User("Test", "");

        public string Name { get; set; }

        public string Password { get; set; }

        public User(string name, string password)
        {
            this.Name = name;
            this.Password = password;
        }

        /// <summary>
        /// 是否管理员账号
        /// </summary>
        /// <returns></returns>
        public bool IsAdmin()
        {
            return !Name.Equals(TestUser.Name);
        }

    }
}
