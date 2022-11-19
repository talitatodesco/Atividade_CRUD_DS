using CRUD_MVC_Talita_Todesco.DAL;
using CRUD_MVC_Talita_Todesco.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Talita_Todesco.BLL
{
    class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            LoginDAL login = new LoginDAL();
            bool retorno = login.GetLoginDAL(loginDTO);

            if(retorno)
            {
                return true;
            }

            return false;
        }
    }
 

}
