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
            databaseClass databaseClassObject = new databaseClass();
            //databaseClassObject.cleaningDataBase();
            databaseClassObject.userRegistration(Int16.Parse(databaseClassObject.searchingForMaxId()) + 1, "username", "password", "email", "phoneNumber");
        }
    }
}
