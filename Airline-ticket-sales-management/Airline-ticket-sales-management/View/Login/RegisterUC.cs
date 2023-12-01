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
    public partial class RegisterUC : UserControl
    {
        public RegisterUC()
        {
            InitializeComponent();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new LoginUC());
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if(atxbPassword.PasswordChar)
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

        private void pibHideViewRePassword_Click(object sender, EventArgs e)
        {
            if (atxbRePassword.PasswordChar)
            {
                atxbRePassword.PasswordChar = false;
                pibHideViewRePassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbRePassword.PasswordChar = true;
                pibHideViewRePassword.BackgroundImage = Properties.Resources.view;
            }
        }
    }
}
