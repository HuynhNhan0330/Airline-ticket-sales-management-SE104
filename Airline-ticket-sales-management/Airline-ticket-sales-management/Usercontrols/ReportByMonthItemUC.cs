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
    public partial class ReportByMonthItemUC : UserControl
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

        private DetailedMonthlyRevenueReportDTO _dmrr;
        public DetailedMonthlyRevenueReportDTO dmrr
        {
            get { return _dmrr; }
            set
            {
                _dmrr = value;
                render();
            }
        }

        public ReportByMonthItemUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbSTT.Text = stt.ToString();
            lbFlightName.Text = dmrr.FlightName;
            lbTicket.Text = dmrr.TicketSold.ToString();
            lbRevenue.Text = Helper.FormatVNMoney(dmrr.Revenue);
            lbRatio.Text = dmrr.Ratio.ToString();

            lbSTT.Left = (pnSTT.Width - lbSTT.Width) / 2;
            lbFlightName.Left = (pnFlightName.Width - lbFlightName.Width) / 2;
            lbTicket.Left = (pnTicket.Width - lbTicket.Width) / 2;
            lbRevenue.Left = (pnRevenue.Width - lbRevenue.Width) / 2;
            lbRatio.Left = (pnRatio.Width - lbRatio.Width) / 2;

            this.Height = Math.Max(this.Height, lbSTT.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbFlightName.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbTicket.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbRevenue.Height + 10 * 2);
            this.Height = Math.Max(this.Height, lbRatio.Height + 10 * 2);

            lbSTT.Top = (this.Height - lbSTT.Height) / 2;
            lbFlightName.Top = (this.Height - lbFlightName.Height) / 2;
            lbTicket.Top = (this.Height - lbTicket.Height) / 2;
            lbRevenue.Top = (this.Height - lbRevenue.Height) / 2;
            lbRatio.Top = (this.Height - lbRatio.Height) / 2;
        }
    }
}
