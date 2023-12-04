using Airline_ticket_sales_management.AControls;
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
    public partial class PlaneUC : UserControl
    {
        private AButton currentAbtn = null;

        public PlaneUC()
        {
            InitializeComponent();
            currentAbtn = this.abtnPlaneList;
        }

        public void loadBody(UserControl uc)
        {
            pnBodyPlane.Controls.Clear();
            pnBodyPlane.Controls.Add(uc);
        }


        #region menu
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

        public void abtnPlaneList_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnPlaneList) 
            {
                doDeactivateAbtn(currentAbtn);
                currentAbtn = abtnPlaneList;

                doActivateAbtn(currentAbtn);
                loadBody(new PlaneListUC());
            }
        }

        private void abtnCreatePlane_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnCreatePlane)
            {
                doDeactivateAbtn(currentAbtn);
                currentAbtn = abtnCreatePlane;

                doActivateAbtn(currentAbtn);
                loadBody(new OperationPlaneUC());
            }
        }

        public void abtnDetailPlane_Click(object sender, EventArgs e)
        {
            if (currentAbtn != abtnDetailPlane)
            {
                doDeactivateAbtn(currentAbtn);
                currentAbtn = abtnDetailPlane;

                doActivateAbtn(currentAbtn);
                //loadBody(new OperationPlaneUC());
            }
        }
        #endregion
    }
}
