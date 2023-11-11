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
    public partial class PlaneListUC : UserControl
    {
        public PlaneListUC()
        {
            InitializeComponent();
        }

        private void PlaneListUC_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PlaneItemUC uc = new PlaneItemUC();
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
    }
}
