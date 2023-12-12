using Airline_ticket_sales_management.AControls;
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

        private void abtnRegsiter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbRePassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbPassword.Texts.Trim() == atxbRePassword.Texts.Trim())
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                AccountDTO account = new AccountDTO();
                account.Name = atxbName.Texts.Trim();
                account.Email = atxbEmail.Texts.Trim();
                account.Phone = atxbPhone.Texts.Trim();
                account.Password = atxbPassword.Texts.Trim();

                regsiter(account);
            }
        }

        private void regsiter(AccountDTO account)
        {

        }
    }
}
