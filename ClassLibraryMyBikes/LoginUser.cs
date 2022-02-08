using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMyBikes
{
    public class LoginUser
    {
        private string username;
        private string password;

        public LoginUser()
        {
            username = "user1";
            password = "123";
        }

        public string Username
        {
            get { return this.username; }
        }
        public string Password
        {
            get { return this.password; }
        }

        public bool ValidateLogin(string username, string password)
        {
            if(username == this.Username && password == this.Password)
            {
                return true;
            }
            return false;
        }

    }
}
