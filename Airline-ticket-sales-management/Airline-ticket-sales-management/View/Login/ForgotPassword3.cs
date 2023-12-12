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
    public partial class ForgotPassword3 : UserControl
    {
        public ForgotPassword3()
        {
            InitializeComponent();
        }

        private void abtnSubmit_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;
            currentForm.loadBody(new LoginUC());
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

        private void abtnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbRePassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (atxbPassword.Texts.Trim() != atxbRePassword.Texts.Trim())
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Mật khẩu nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                updateAccount();
            }
        }

        private async void updateAccount()
        {
            FormLogin currentForm = FindForm() as FormLogin;
            AccountDTO account = await AccountDAL.Ins.findAccountByEmail(currentForm.email);
            
            if (account == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thay đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                account.Password = atxbPassword.Texts.Trim();
                (bool isUpdate, string label) = await AccountDAL.Ins.updateAccount(account);

                if (isUpdate)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();

                    currentForm.loadBody(new LoginUC());
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private void pibReturn_Click(object sender, EventArgs e)
        {
            FormLogin form = Application.OpenForms.OfType<FormLogin>().FirstOrDefault();
            form.removeBody(this);
        }
    }
}
