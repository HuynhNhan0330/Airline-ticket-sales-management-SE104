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
        private List<DetailedAnnualRevenueReportDTO> _detailAnnualRevenueReport;
        public List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport
        {
            get { return _detailAnnualRevenueReport; }
            set 
            { 
                _detailAnnualRevenueReport = value; 
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

        public ReportByYearUC()
        {
            InitializeComponent();
        }

        private void ReportByYearUC_Load(object sender, EventArgs e)
        {
            
        }

        public void loadData(List<DetailedAnnualRevenueReportDTO> detailAnnualRevenueReport)
        {
            this.detailAnnualRevenueReport = new List<DetailedAnnualRevenueReportDTO>(detailAnnualRevenueReport);
            loadPanel();

            lbFlightCount.Text = detailAnnualRevenueReport.Sum(darr => darr.FlightCount).ToString();
            totalRevenue = detailAnnualRevenueReport.Sum(darr => darr.Revenue);
            lbRevenue.Text = Helper.FormatVNMoney(totalRevenue);

            loadChart();
        }

        public void loadPanel()
        {
            pnReportByYear.Controls.Clear();

            for (int i = 0; i < detailAnnualRevenueReport.Count; ++i)
            {
                detailAnnualRevenueReport[i].STT = i + 1;
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

        public void loadChart()
        {
            chartReportByYear.DataSource = detailAnnualRevenueReport;
            chartReportByYear.Series[0].XValueMember = "Month";
            chartReportByYear.Series[0].YValueMembers = "Ratio";
            chartReportByYear.DataBind();
            chartReportByYear.Update();
        }

        private void lbRe_Click(object sender, EventArgs e)
        {
            if (isSort)
                detailAnnualRevenueReport = detailAnnualRevenueReport.OrderByDescending(darr => darr.Revenue).ToList();

            else
                detailAnnualRevenueReport = detailAnnualRevenueReport.OrderBy(darr => darr.Revenue).ToList();

            isSort = !isSort;
            loadPanel();
        }
    }
}
