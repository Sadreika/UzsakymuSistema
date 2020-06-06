using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzsakymuSistema
{
    public class User
    {
        private string username;
        private string password;
        private string email;
        private string phoneNumber;

        public User userRegistration(string username, string password, string email, string phoneNumber)
        {
            User userObject = new User();
            userObject.username = username;
            userObject.password = password;
            userObject.email = email;
            userObject.phoneNumber = phoneNumber;
            return userObject;
        }

    }
}
