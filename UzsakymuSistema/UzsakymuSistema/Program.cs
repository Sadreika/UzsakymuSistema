using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzsakymuSistema
{
    public class Program : User
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();
            User userObject = new User();
            userList.Add(userObject.userRegistration("username", "password", "email", "phoneNumber"));
        }
    }
}
