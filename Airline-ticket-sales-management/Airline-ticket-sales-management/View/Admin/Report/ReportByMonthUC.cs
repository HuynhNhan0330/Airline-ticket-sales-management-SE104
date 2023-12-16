using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class ReportByMonthUC: UserControl
    {
        public ReportByMonthUC()
        {
            InitializeComponent();
        }

        public void loadData(List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports)
        {
            loadPanel(detailedMonthlyRevenueReports);

            lbFlightCount.Text = detailedMonthlyRevenueReports.Count.ToString();
            lbTicket.Text = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.TicketSold).ToString();
            lbRevenue.Text = Helper.FormatVNMoney(detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue));
        }

        private void ReportByMonthUC_Load(object sender, EventArgs e)
        {

        }

        private void loadPanel(List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports)
        {
            for (int i = 0; i < detailedMonthlyRevenueReports.Count; ++i)
            {
                DetailedMonthlyRevenueReportDTO dmrp = detailedMonthlyRevenueReports[i];
                ReportByMonthItemUC uc = new ReportByMonthItemUC();
                uc.stt = i + 1;
                uc.dmrr = dmrp;
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
