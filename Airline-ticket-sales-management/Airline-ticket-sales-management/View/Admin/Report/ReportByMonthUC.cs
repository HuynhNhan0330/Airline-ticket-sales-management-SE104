using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class ReportByMonthUC: UserControl
    {
        private List<DetailedMonthlyRevenueReportDTO> _detailedMonthlyRevenueReports;
        public List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports
        {
            get { return _detailedMonthlyRevenueReports; }
            set
            {
                _detailedMonthlyRevenueReports = value;
            }
        }
        private bool isSort = false;


        private decimal _totalRevenue;
        public decimal totalRevenue
        {
            get { return _totalRevenue; }
            set
            {
                _totalRevenue = value;  
            }
        }

        public ReportByMonthUC()
        {
            InitializeComponent();
        }

        public void loadData(List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports)
        {
            this.detailedMonthlyRevenueReports = new List<DetailedMonthlyRevenueReportDTO>(detailedMonthlyRevenueReports);

            loadPanel();

            lbFlightCount.Text = detailedMonthlyRevenueReports.Count.ToString();
            lbTicket.Text = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.TicketSold).ToString();
            totalRevenue = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue);
            lbRevenue.Text = Helper.FormatVNMoney(totalRevenue);
        }

        private void ReportByMonthUC_Load(object sender, EventArgs e)
        {

        }

        private void loadPanel()
        {
            pnReportByMonth.Controls.Clear();

            for (int i = 0; i < detailedMonthlyRevenueReports.Count; ++i)
            {
                DetailedMonthlyRevenueReportDTO dmrp = detailedMonthlyRevenueReports[i];
                detailedMonthlyRevenueReports[i].STT = i + 1;
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

        private void lbRe_Click(object sender, EventArgs e)
        {
            if (isSort)
                detailedMonthlyRevenueReports = detailedMonthlyRevenueReports.OrderByDescending(darr => darr.Revenue).ToList();

            else
                detailedMonthlyRevenueReports = detailedMonthlyRevenueReports.OrderBy(darr => darr.Revenue).ToList();

            isSort = !isSort;
            loadPanel();
        }
    }
}
