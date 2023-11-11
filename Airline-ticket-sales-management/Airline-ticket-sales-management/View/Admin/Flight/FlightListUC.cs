using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_ticket_sales_management.Usercontrols;

namespace Airline_ticket_sales_management
{
    public partial class FlightListUC : UserControl
    {
        public FlightListUC()
        {
            InitializeComponent();

            loadDataFlight();
        }

        private void loadDataFlight()
        {
            for (int i = 0; i < 1000; i++)
            {
                FlightItemUC uc = new FlightItemUC();
                pnFlightList.Controls.Add(uc);
                uc.emptySeat = i + 1000;
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnFlightList.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }

        private void FlightListUC_Load(object sender, EventArgs e)
        {
        }
    }
}
