using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
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

        private void pibEdit_Click(object sender, EventArgs e)
        {
            Control ctr = this;
            while (!(ctr is PlaneUC))
                ctr = ctr.Parent;

            PlaneUC ctrParent = ctr as PlaneUC;
            ctrParent.abtnDetailPlane_Click(sender, e);
            OperationPlaneUC newBody = new OperationPlaneUC(Plane);
            ctrParent.loadBody(newBody);
        }

        private void pibDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private async void delete()
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
            {
                (bool isDeleteSeats, string label) = await SeatDAL.Ins.deleteSeats(this.Plane);

                if (isDeleteSeats)
                {
                    (bool isDeletePlane, string label1) = await PlaneDAL.Ins.deletePlane(this.Plane);

                    if (isDeletePlane)
                    {
                        Control ctr = this;
                        while (!(ctr is PlaneListUC))
                            ctr = ctr.Parent;

                        PlaneListUC ctrParent = ctr as PlaneListUC;
                        ctrParent.removePlane(this);

                        AMessageBoxFrm ms2 = new AMessageBoxFrm(label1, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ms2.ShowDialog();
                    }
                    else
                    {
                        AMessageBoxFrm ms2 = new AMessageBoxFrm(label1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ms2.ShowDialog();
                    }
                }
                else
                {
                    AMessageBoxFrm ms1 = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms1.ShowDialog();
                }
            }
        }
    }
}
