using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class FlightUC : UserControl
    {
        private AButton currentAbtn;
        //private ObservableCollection<Flight> flights { get; set; }

        public FlightUC()
        {
            InitializeComponent();
            currentAbtn = abtnListFlight;
            loadBody(new FlightListUC());
        }

        public void loadBody(UserControl uc)
        {
            pnBodyFlight.Controls.Clear();
            pnBodyFlight.Controls.Add(uc);
        }

        private void doActivateAbtn(AButton abtn)
        {
            abtn.BackgroundColor = BaseColor.XanhDam;
            abtn.ForeColor = Color.White;
        }

        private void doDeactivateAbtn(AButton abtn)
        {
            abtn.BackgroundColor = Color.Transparent;
            abtn.ForeColor = BaseColor.XanhDam;
        }

        private void abtnCreateFlight_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnCreateFlight)
            {
                doDeactivateAbtn(currentAbtn);
                currentAbtn = abtnCreateFlight;

                doActivateAbtn(currentAbtn);
                loadBody(new OperationFlightUC());
            }
        }

        public void abtnListFlight_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnListFlight)
            {
                doDeactivateAbtn(currentAbtn);
                currentAbtn = abtnListFlight;

                doActivateAbtn(currentAbtn);
                loadBody(new FlightListUC());
            }
        }

        public void abtnDetailFlight_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnDetailFlight)
            {
                doDeactivateAbtn(currentAbtn);
                currentAbtn = abtnDetailFlight;

                doActivateAbtn(currentAbtn);
                //loadBody(new OperationFlightUC());
            }
        }
    }
}
