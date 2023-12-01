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

        private void abtnGetOTP_Click(object sender, EventArgs e)
        {
            FrmLogin currentForm = FindForm() as FrmLogin;
            currentForm.loadBody(new ForgotPassword3());
        }
    }
}
