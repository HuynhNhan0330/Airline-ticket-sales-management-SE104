using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<PlaneDTO> planes;

        public PlaneListUC()
        {
            InitializeComponent();
        }

        private void PlaneListUC_Load(object sender, EventArgs e)
        {
            loadListPlane();
        }

        private void loadPanelListPlane()
        {
            foreach (PlaneDTO plane in planes) 
            {
                PlaneItemUC uc = new PlaneItemUC(plane);
                pnPlaneList.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnPlaneList.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }

        private async void loadListPlane()
        {
            (bool isGet, List<PlaneDTO> listPlane, string label) = await PlaneDAL.Ins.getListPlane();
            if (isGet)
            {
                planes = new ObservableCollection<PlaneDTO>(listPlane);
                loadPanelListPlane();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("label", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    
        public void removePlane(PlaneItemUC planeItemUC)
        {
            int indexRemove = pnPlaneList.Controls.IndexOf(planeItemUC);

            pnPlaneList.Controls.RemoveAt(indexRemove);
            pnPlaneList.Controls.RemoveAt(indexRemove - 1);
        }
    }
}
