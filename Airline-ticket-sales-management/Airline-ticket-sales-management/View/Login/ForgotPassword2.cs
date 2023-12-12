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
    public partial class ForgotPassword2 : UserControl
    {
        public ForgotPassword2()
        {
            InitializeComponent();
        }

        private void lbGetOTP_Click(object sender, EventArgs e)
        {
            getOTP();
        }

        private async void getOTP()
        {
            FormLogin currentForm = FindForm() as FormLogin;

            AccountDTO account = await AccountDAL.Ins.findAccountByEmail(currentForm.email);

            if (account == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Emnail không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                currentForm.sendOTP(currentForm.email);
            }
        }

        private void abtnAccept_Click(object sender, EventArgs e)
        {
            FormLogin currentForm = FindForm() as FormLogin;

            if (string.IsNullOrEmpty(atxbOTP.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu OTP không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                if (currentForm.otp.ToString() != atxbOTP.Texts.Trim())
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Mã OTP không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
                else
                {
                    currentForm.addBody(new ForgotPassword3());
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
