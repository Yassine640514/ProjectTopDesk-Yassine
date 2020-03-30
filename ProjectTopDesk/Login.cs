using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTopDesk.Logic;
using ProjectTopDesk.Model;

namespace ProjectTopDesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            User huidigeUser = new User();
            UserManagementController user_Service = new UserManagementController();
            

            string Email = tb_Email.Text;
            string Password = tb_Password.Text;

            huidigeUser = user_Service.CheckEmailAndPassword(Email, Password);


            if (huidigeUser == null)
            {
                MessageBox.Show("Email or Password incorrect, Try again !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (huidigeUser.type == UserType.Employee)
            {
                this.Hide();
                TopDesk TopDesk = new TopDesk(huidigeUser);
                TopDesk.Show();
            }

            else if (huidigeUser.type == UserType.ServiceDeskEmployee)
            {
                this.Hide();
                TopDesk TopDesk = new TopDesk(huidigeUser);
                TopDesk.Show();
            }
        }

        private void btn_ShowPassword_Click(object sender, EventArgs e)
        {
            if (tb_Password.UseSystemPasswordChar)
            {
                tb_Password.UseSystemPasswordChar = false;
                btn_ShowPassword.Text = "Hide password";
            }
            else
            {
                tb_Password.UseSystemPasswordChar = true;
                btn_ShowPassword.Text = "Show password";
            }
        }
    }
}
