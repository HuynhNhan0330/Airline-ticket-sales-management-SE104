using Airline_ticket_sales_management.DTOs;
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
    public partial class PlaneItemUC : UserControl
    {
        private readonly int margin = 15;
        public PlaneDTO _plane;
        private PlaneDTO Plane
        {
            get { return _plane; }
            set
            {
                _plane = value;
                render();
            }
        }

        public PlaneItemUC(PlaneDTO plane)
        {
            InitializeComponent();
            this.Plane = plane;
        }

        private void render()
        {
            // value
            lbPlaneID.Text = Plane.PlaneID;
            lbPlaneName.Text = Plane.PlaneName;
            lbSeatCount.Text = Plane.SeatCount.ToString();

            // top
            lbPlaneID.Top = margin;
            lbPlaneName.Top = margin;
            lbSeatCount.Top = margin;

            // left
            lbPlaneID.Left = (pnPlaneID.Width - lbPlaneID.Width) / 2;
            lbPlaneName.Left = (pnPlaneName.Width - lbPlaneName.Width) / 2;
            lbSeatCount.Left = (pnSeatCount.Width - lbSeatCount.Width) / 2;

            // height
            this.Height = Math.Max(this.Height, lbPlaneID.Height + margin * 2);
            this.Height = Math.Max(this.Height, lbPlaneName.Height + margin * 2);
            this.Height = Math.Max(this.Height, lbSeatCount.Height + margin * 2);

            // position control
            foreach (Control ctr in pnControl.Controls)
                ctr.Top = (this.Height - ctr.Height) / 2;
        }
    }
}
