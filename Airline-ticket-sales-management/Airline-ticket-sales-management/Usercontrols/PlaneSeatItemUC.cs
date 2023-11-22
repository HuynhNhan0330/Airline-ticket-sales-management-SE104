using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Utils;
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

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class PlaneSeatItemUC : UserControl
    {
        private ObservableCollection<SeatDTO> _seats = new ObservableCollection<SeatDTO>();
        public ObservableCollection<SeatDTO> Seats
        {
            get { return _seats; }
            set { _seats = value; }
        }

        private string type;

        private string _stt;
        public string stt
        {
            get { return _stt; }
            set 
            { 
                _stt = value;
                lbText.Text = stt;
            }
        }
        
        public PlaneSeatItemUC(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private async Task loadColorItemBasicAsync()
        {
            TicketClassDTO first = await TicketClassDAL.Ins.getFirst();
            first.ColorTicketClass = ColorTranslator.FromHtml(ColorCodes.ColorList[0]);

            foreach (Control ctr in this.Controls)
            {
                if (ctr is Panel && ctr.Name != "pnSTT")
                {
                    SeatDTO seat = new SeatDTO();
                    seat.TicketClass = first;
                    seat.SeatID = stt + ctr.Name.Substring(2);
                    ctr.BackColor = seat.TicketClass.ColorTicketClass;
                    Seats.Add(seat);
                    ctr.Click += setTicketClassInPlane;
                }
            }
        }

        private void setTicketClassInPlane(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            
            Control ctr = this.Parent;
            while (!(ctr is OperationPlaneUC))
                ctr = ctr.Parent;

            OperationPlaneUC ctrParent = ctr as OperationPlaneUC;
            
            if (ctrParent.SelectedTicketClass != null)
            {
                panel.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;

                int sttList = int.Parse(panel.Name.Substring(2)) - 1;

                Seats[5 - sttList].TicketClass = ctrParent.SelectedTicketClass;

                ctrParent.reloadDetailTicketClass();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng chọn loại hạng vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void PlaneSeatItemUC_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case "Plane":
                    loadColorItemBasicAsync();
                    break;

                case "2":
                    break;
            }
        }

        private void lbText_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            Control ctr = this.Parent;
            while (!(ctr is OperationPlaneUC))
                ctr = ctr.Parent;

            OperationPlaneUC ctrParent = ctr as OperationPlaneUC;

            if (ctrParent.SelectedTicketClass != null)
            {
                foreach (SeatDTO s in Seats)
                    s.TicketClass = ctrParent.SelectedTicketClass;

                pn1.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;
                pn2.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;
                pn3.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;
                pn4.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;
                pn5.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;
                pn6.BackColor = ctrParent.SelectedTicketClass.ColorTicketClass;

                ctrParent.reloadDetailTicketClass();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng chọn loại hạng vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
