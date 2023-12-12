using Airline_ticket_sales_management.AControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Airline_ticket_sales_management
{
    public partial class FormLogin : Form
    {
        private int _otp;
        public int otp
        {
            get { return _otp; }
            set { _otp = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 20);

            // Đặt Region cho Form để tạo hình dạng bo tròn
            this.Region = new Region(path);
        }

        public void loadBody(UserControl uc)
        {
            apnMain.Controls.Clear();
            apnMain.Controls.Add(uc);
        }

        public void addBody(UserControl uc)
        {
            apnMain.Controls.Add(uc);
            uc.BringToFront();
        }

        public void removeBody(UserControl uc)
        {
            apnMain.Controls.Remove(uc);
        }

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int sendOTP(string recipient)
        {
            this.email = recipient;

            // Thông tin tài khoản Gmail
            string email = "nhanhelpxx@gmail.com";
            string password = "xxts wmgb aeoe favp";

            // Tạo đối tượng MailMessage
            MailMessage message = new MailMessage();
            message.From = new MailAddress(email);
            message.To.Add(recipient);
            message.Subject = "Gửi mã xác nhận OTP";

            // Tạo ngẫu nhiên
            Random random = new Random();
            otp = random.Next(100000, 1000000);
            message.Body = "Mã OTP: " + otp.ToString();

            // Tạo đối tượng SmtpClient và cấu hình thông tin SMTP của Gmail
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(email, password);

            try
            {
                // Gửi email
                smtpClient.Send(message);

                return otp;

            }
            catch (Exception ex)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();

                return -1;
            }
        }
    }
}
