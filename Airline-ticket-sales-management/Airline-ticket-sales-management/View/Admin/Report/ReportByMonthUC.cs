using Airline_ticket_sales_management.Usercontrols;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class ReportByMonthUC: UserControl
    {
        public ReportByMonthUC()
        {
            InitializeComponent();
        }

        private void ReportByMonthUC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; ++i)
            {
                ReportByMonthItemUC uc = new ReportByMonthItemUC();
                pnReportByMonth.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnReportByMonth.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }
    }
}
