using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel.Design;
using System.Deployment.Internal;
using System.Data;

namespace UzsakymuSistema
{
    public class databaseClass
    {
        public void userRegistration(int id, string username, string password, string email, string phoneNumber)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Items;Integrated Security=True";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd.CommandText = "INSERT [UzsakymuSistema].[dbo].[Users] (id, username, password, email, phoneNumber) VALUES (@id, @username, @password, @email, @phoneNumber)";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void cleaningDataBase()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Items;Integrated Security=True";
            con.Open();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM [UzsakymuSistema].[dbo].[Users]";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string searchingForMaxId()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=Items;Integrated Security=True";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "SELECT MAX(id) FROM [UzsakymuSistema].[dbo].[Users]";
            string id = cmd.ExecuteScalar().ToString();
            if(id.Equals(""))
            {
                id = "0";
            }
            con.Close();
            return id;
        }
    }
}
