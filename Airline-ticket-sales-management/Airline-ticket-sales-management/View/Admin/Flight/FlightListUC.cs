using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;

namespace Airline_ticket_sales_management
{
    public partial class FlightListUC : UserControl
    {
        public FlightListUC()
        {
            InitializeComponent();

        }

        private async void loadDataFlight()
        {
            (bool isGetFlights, List<FlightDTO> flights, string label) = await FlightDAL.Ins.getListFlight();

            if (isGetFlights)
            {
                foreach (FlightDTO flight in flights)
                {
                    FlightItemUC uc = new FlightItemUC();
                    uc.flight = flight; 
                    pnFlightList.Controls.Add(uc);
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
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void FlightListUC_Load(object sender, EventArgs e)
        {
            loadDataFlight();
        }
    }
}
