using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class OperationPlaneUC : UserControl
    {
        private ObservableCollection<TicketClassDTO> ticketClasses;
        private TicketClassDTO _ticketClassSelected = null;
        public TicketClassDTO SelectedTicketClass
        {
            get { return _ticketClassSelected; }
            set
            {
                _ticketClassSelected = value;
            }
        }

        public OperationPlaneUC()
        {
            InitializeComponent();
        }

        private void OperationPlaneUC_Load(object sender, EventArgs e)
        {
            loadTicketClass();
        }

        private void addTicketClassItem(TicketClassDTO ticketClass, int colorPosition)
        {
            PlaneTicketClassItemUC uc = new PlaneTicketClassItemUC();
            uc.TicketClass = ticketClass;
            uc._BackgroundColor = ColorTranslator.FromHtml(ColorCodes.ColorList[colorPosition]);
            pnTicketClass.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Top;

            Panel pn = new Panel();
            pnTicketClass.Controls.Add(pn);
            pn.Height = 2;
            pn.BackColor = Color.Transparent;
            pn.BringToFront();
            pn.Dock = DockStyle.Top;
        }

        private async void loadTicketClass()
        {
            (bool isGetList, List<TicketClassDTO> listTicketClass, string lb) = await TicketClassDAL.Ins.getListTicketClass();

            if (isGetList)
            {
                ticketClasses = new ObservableCollection<TicketClassDTO>(listTicketClass);

                for (int index = 0; index < ticketClasses.Count; ++index)
                    addTicketClassItem(ticketClasses[index], index % ColorCodes.ColorList.Count);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(lb, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void lbReloadSeat_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(atbSeatCount.Texts))
            {
                int intValue = int.Parse(atbSeatCount.Texts);
                if (intValue % 6 != 0)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng nhập giá trị chia hết cho 6", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    atbSeatCount.Focus();
                    ms.ShowDialog();
                }
                else if (intValue > 156)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng nhập giá trị nhỏ hơn 156", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    atbSeatCount.Focus();
                    ms.ShowDialog();
                }
                else if (intValue < 1)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng nhập giá trị lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    atbSeatCount.Focus();
                    ms.ShowDialog();
                }
                else
                {
                    pnSeat.Controls.Clear();

                    for (int stt = 0; stt < intValue / 6; ++stt)
                    {
                        PlaneSeatItemUC uc = new PlaneSeatItemUC("Plane");
                        uc.stt = ((char)('A' + stt)).ToString();
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
                }
            }
        }

        private void abtnCreatePlane_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atbPlaneName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên máy bay bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atbPlaneName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atbSeatCount.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu số lượng ghế bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atbSeatCount.Focus();
                ms.ShowDialog();
            }
            else if (int.Parse(atbSeatCount.Texts.Trim()) % 6 != 0)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu số lượng ghế phải chia hết cho 6", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atbSeatCount.Focus();
                ms.ShowDialog();
            }
            else
            {
                _ = createPlaneAsync();
            }
        }

        private async Task createPlaneAsync()
        {
            PlaneDTO plane = new PlaneDTO(atbPlaneName.Texts.Trim(), int.Parse(atbSeatCount.Texts.Trim()));
            (bool isCreatePlane, string label) = await PlaneDAL.Ins.createPlane(plane);

            if (isCreatePlane)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
