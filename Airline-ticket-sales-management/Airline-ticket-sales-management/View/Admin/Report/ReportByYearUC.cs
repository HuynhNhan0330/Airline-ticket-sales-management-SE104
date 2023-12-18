using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            
        }

        public void loadData(List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport)
        {
            loadPanel(detailAnnualRevenueReport);

            lbFlightCount.Text = detailAnnualRevenueReport.Sum(darr => darr.FlightCount).ToString();
            lbRevenue.Text = Helper.FormatVNMoney(detailAnnualRevenueReport.Sum(darr => darr.Revenue));

            loadChart(detailAnnualRevenueReport);
        }

        public void loadPanel(List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport)
        {
            pnReportByYear.Controls.Clear();

            for (int i = 0; i < detailAnnualRevenueReport.Count; ++i)
            {
                ReportByYearItemUC uc = new ReportByYearItemUC();
                uc.stt = i + 1;
                uc.darr = detailAnnualRevenueReport[i];
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

        public void loadChart(List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport)
        {
            chartReportByYear.DataSource = detailAnnualRevenueReport;
            chartReportByYear.Series[0].XValueMember = "Month";
            chartReportByYear.Series[0].YValueMembers = "Ratio";
            chartReportByYear.DataBind();
            chartReportByYear.Update();
        }
    }
}
