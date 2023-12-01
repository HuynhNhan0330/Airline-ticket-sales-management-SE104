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
            FrmLogin currentForm = FindForm() as FrmLogin;
            currentForm.loadBody(new RegisterUC());
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            FrmLogin currentForm = FindForm() as FrmLogin;
            currentForm.loadBody(new ForgotPassword1());
        }
    }
}
