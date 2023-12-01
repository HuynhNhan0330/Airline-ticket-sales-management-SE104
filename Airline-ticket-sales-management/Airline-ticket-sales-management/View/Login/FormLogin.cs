using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class FormLogin : Form
    {
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

        private void pibClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
