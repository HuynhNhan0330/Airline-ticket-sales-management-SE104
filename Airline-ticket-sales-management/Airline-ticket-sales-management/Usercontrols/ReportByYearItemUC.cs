using Airline_ticket_sales_management.DTOs;
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

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class ReportByYearItemUC : UserControl
    {
        private int _stt;
        public int stt
        {
            get { return _stt; }
            set
            {
                _stt = value;
            }
        }

        private DetailedAnnualRevenueReportDTO _darr;
        public DetailedAnnualRevenueReportDTO darr
        {
            get { return _darr; }
            set
            {
                _darr = value;
                render();
            }
        }

        public ReportByYearItemUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbSTT.Text = stt.ToString();
            lbMonth.Text = darr.Month.ToString();
            lbFlightCount.Text = darr.FlightCount.ToString();
            lbRevenue.Text = Helper.FormatVNMoney(darr.Revenue);
            lbRatio.Text = darr.Ratio.ToString();

            lbSTT.Left = (pnSTT.Width - lbSTT.Width) / 2;
            lbMonth.Left = (pnMonth.Width - lbMonth.Width) / 2;
            lbFlightCount.Left = (pnFlightCount.Width - lbFlightCount.Width) / 2;
            lbRevenue.Left = (pnRevenue.Width - lbRevenue.Width) / 2;
            lbRatio.Left = (pnRatio.Width - lbRatio.Width) / 2;

            this.Height = Math.Max(this.Height, lbSTT.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbMonth.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbFlightCount.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbRevenue.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbRatio.Height + 10 * 2);

            lbSTT.Top = (this.Height - lbSTT.Height) / 2;
            lbSTT.Top = (this.Height - lbMonth.Height) / 2;
            lbFlightCount.Top = (this.Height - lbFlightCount.Height) / 2;
            lbRevenue.Top = (this.Height - lbRevenue.Height) / 2;
            lbRatio.Top = (this.Height - lbRatio.Height) / 2;
        }
    }
}
