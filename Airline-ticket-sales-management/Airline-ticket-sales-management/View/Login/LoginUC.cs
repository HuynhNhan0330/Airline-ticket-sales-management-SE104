using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void abtnLogin_Click(object sender, EventArgs e)
        {
            var currentForm = FindForm();
            currentForm.Hide();

            FormAdminHome frmHome = new FormAdminHome();
            frmHome.ShowDialog();

            currentForm.Show();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new RegisterUC());
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if (atxbPassword.PasswordChar)
            {
                atxbPassword.PasswordChar = false;
                pibHideViewPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbPassword.PasswordChar = true;
                pibHideViewPassword.BackgroundImage = Properties.Resources.view;
            }
        }
    }
}
