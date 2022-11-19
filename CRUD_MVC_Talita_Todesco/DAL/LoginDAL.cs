using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Talita_Todesco.DAL
{
    class LoginDAL
    {
        public bool GetLoginDAL(DTO.LoginDTO loginDTO)
        {
            try
            {
                MySqlConnection conn = UtilsDal.GetConnection();

                if(conn.State == ConnectionState.Open)
                {
                    string sql = $"SELECT * FROM usuarios" +
                        $"WHERE" +
                        $"Email '{ loginDTO.Email}'  " +
                        $"AND" +
                        $"Senha '{loginDTO.Senha}'";
                    MySqlCommand retorno = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = retorno.ExecuteReader();


                    if(reader.Read())
                    {
                        return true;
                    }
                }
            }
            catch(System.Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
           return false;
        }
       
    }
}
