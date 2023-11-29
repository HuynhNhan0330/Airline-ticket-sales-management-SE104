using Airline_ticket_sales_management.Usercontrols;
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
    public partial class ReportByYearUC : UserControl
    {
        public ReportByYearUC()
        {
            InitializeComponent();
        }

        private void ReportByYearUC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; ++i)
            {
                ReportByYearItemUC uc = new ReportByYearItemUC();
                pnReportByYear.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnReportByYear.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }
    }
}
