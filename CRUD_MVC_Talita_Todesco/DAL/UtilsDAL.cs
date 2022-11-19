using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Talita_Todesco.DAL
{
    class UtilsDal { 
        public static MySqlConnection GetConnection()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder 
            {
            Server = "localhost",
            Database = "cad_usuario",
            UserID = "root",
            Password = "" 
            };


            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();


            return connection;
        }

    }
}
