using CRUD_MVC_Talita_Todesco.BLL;
using CRUD_MVC_Talita_Todesco.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Talita_Todesco
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void senha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO
            {
                Email = emailtxt.Text,
                Senha = senhatxt.Text,
            };


            LoginBLL login = new LoginBLL();
            bool retorno = login.GetLoginBLL(loginDTO);



            if(retorno)
            {
                MessageBox.Show("Login Ok!.");
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o login, tente novamente.");
            }

       }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
