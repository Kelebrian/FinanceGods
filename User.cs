using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Management
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public User() { }
        public User(string login, string password, string avatar)
        {
            Login = login;
            Password = password;
            Avatar = avatar;
        }
    }
}
