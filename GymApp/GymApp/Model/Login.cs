using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Model
{
    public class Login
    {
        //Fields
        private string username;
        private string password;
        private bool isSuccessful;
        private string message;
        private bool isAdmin;

        //Properties   
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [PasswordPropertyText]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
    }
}
