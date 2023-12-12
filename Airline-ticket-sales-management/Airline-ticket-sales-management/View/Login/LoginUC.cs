using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
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
            if (string.IsNullOrEmpty(atxbUsername.Texts.Trim())) 
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                login(atxbUsername.Texts.Trim(), atxbPassword.Texts.Trim());
            }
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

        private async void login(string username, string password)
        {
            (AccountDTO account, string label) = await AccountDAL.Ins.login(username, password);

            if (account == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                var currentForm = FindForm();
                currentForm.Hide();

                FormAdminHome frmHome = new FormAdminHome(account);
                frmHome.ShowDialog();

                currentForm.Show();
            }
        }

        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.addBody(new ForgotPassword1());
        }
    }
}
