using System;
using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class FlightItemUC : UserControl
    {
        public int emptySeat
        {
            get
            {
                return Int32.Parse(lbEmptySeat.Text);
            }

            set
            {
                lbEmptySeat.Text = value.ToString();
            }
        }

        public FlightItemUC()
        {
            InitializeComponent();
        }

    }


}
