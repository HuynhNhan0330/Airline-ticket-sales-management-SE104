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

namespace Airline_ticket_sales_management
{
    public partial class CreateFlightTicketUC : UserControl
    {
        public CreateFlightTicketUC()
        {
            InitializeComponent();
        }

        private void CreateFlightTicketUC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PlaneSeatItemUC uc = new PlaneSeatItemUC();
                pnSeat.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnSeat.Controls.Add(pn);
                pn.Height = 5;
                pn.BackColor = Color.Transparent;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }

            for (int i = 0; i < ColorCodes.ColorList.Count; i++)
            {
                PlaneTicketClassItemUC uc = new PlaneTicketClassItemUC();
                pnTicketClass.Controls.Add(uc);
                uc.BackColor = ColorTranslator.FromHtml(ColorCodes.ColorList[i]);
                uc.BringToFront();
                uc.Dock = DockStyle.Left;

                Panel pn = new Panel();
                pnTicketClass.Controls.Add(pn);
                pn.Width = 2;
                pn.BackColor = Color.Transparent;
                pn.BringToFront();
                pn.Dock = DockStyle.Left;
            }
        }
    }
}
