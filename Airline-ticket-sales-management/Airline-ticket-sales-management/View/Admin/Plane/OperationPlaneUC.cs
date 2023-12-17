using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class OperationPlaneUC : UserControl
    {
        private ObservableCollection<TicketClassDTO> ticketClasses;
        private TicketClassDTO _ticketClassSelected = null;
        private PlaneDTO plane = null;
        public TicketClassDTO SelectedTicketClass
        {
            get { return _ticketClassSelected; }
            set
            {
                _ticketClassSelected = value;
            }
        }

        public OperationPlaneUC(PlaneDTO plane = null)
        {
            InitializeComponent();
            this.plane = plane;
        }

        private async void loadSeat()
        {
            (bool isGetSeats, List<SeatDTO> seats, string label) = await SeatDAL.Ins.getSeats(plane);

            if (isGetSeats)
            {
                for (int index1 = 0; index1 < seats.Count / 6; ++index1)
                {
                    PlaneSeatItemUC uc = new PlaneSeatItemUC("");

                    for (int index2 = 0; index2 < 6; ++index2)
                    {
                        seats[index1 * 6 + index2].TicketClass.ColorTicketClass = this.ticketClasses.First(tc => tc.TicketClassID == seats[index1 * 6 + index2].TicketClass.TicketClassID).ColorTicketClass;
                        uc.Seats.Add(seats[index1 * 6 + index2]);
                    }

                    uc.stt = seats[index1 * 6].SeatID[0].ToString();
                    uc.loadColor();
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

                reloadDetailTicketClass();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void OperationPlaneUC_Load(object sender, EventArgs e)
        {
            loadTicketClass();
            setCurrentTicketClass();

            if (plane == null) pnEdit.Visible = false;
            else
            {
                atbPlaneName.Texts = plane.PlaneName;
                atbPlaneName.isPlaceholder = false;
                atbPlaneName.setForeColor();

                atbSeatCount.Texts = plane.SeatCount.ToString();
                atbSeatCount.isPlaceholder = false;
                atbSeatCount.setForeColor();

                loadSeat();
            }
        }

        private void addTicketClassItem(TicketClassDTO ticketClass, int colorPosition)
        {
            PlaneTicketClassItemUC uc = new PlaneTicketClassItemUC();
            uc.TicketClass = ticketClass;
            ticketClass.ColorTicketClass = ColorTranslator.FromHtml(ColorCodes.ColorList[colorPosition]);
            uc._BackgroundColor = ticketClass.ColorTicketClass;
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
                    // Add
                    if (intValue > pnSeat.Controls.Count * 6 / 2)
                    {
                        for (int stt = pnSeat.Controls.Count / 2; stt < intValue / 6; ++stt)
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
                    // remove
                    else if (intValue < pnSeat.Controls.Count * 6 / 2)
                    {
                        for (int valueRemove = (pnSeat.Controls.Count / 2 - intValue / 6) * 2 - 1; valueRemove >= 0; --valueRemove)
                            pnSeat.Controls.RemoveAt(valueRemove);

                    }
                }

                reloadDetailTicketClass();
            }
        }

        public void reloadDetailTicketClass()
        {
            Dictionary<string, int> ticketClassCounts = new Dictionary<string, int>();

            foreach (Control ctr in pnSeat.Controls)
                if (ctr is PlaneSeatItemUC)
                {
                    PlaneSeatItemUC ctrSeat = ctr as PlaneSeatItemUC;
                    foreach(SeatDTO seat in ctrSeat.Seats)
                        if (ticketClassCounts.ContainsKey(seat.TicketClass.TicketClassName))
                            ticketClassCounts[seat.TicketClass.TicketClassName] += 1;
                        else ticketClassCounts.Add(seat.TicketClass.TicketClassName, 1);
                }

            pnTicketClassDetail.Controls.Clear();

            foreach (KeyValuePair<string, int> kvp in ticketClassCounts)
            {
                DetailTicketClassUC uc = new DetailTicketClassUC();
                uc.NameTicketClass = kvp.Key;
                uc.SeatCount = kvp.Value;
                uc.render();
                pnTicketClassDetail.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnTicketClassDetail.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
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
            else if (int.Parse(atbSeatCount.Texts.Trim()) != pnSeat.Controls.Count * 6 / 2)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu số lượng ghế chưa đồng nhất vui lòng tải lại danh sách ghế", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            (bool isCreatePlane, string label, string newID) = await PlaneDAL.Ins.createPlane(plane);

            if (isCreatePlane)
            {
                List<SeatDTO> listSeat = new List<SeatDTO>();

                foreach (Control ctr in pnSeat.Controls)
                {
                    if (ctr is PlaneSeatItemUC)
                    {
                        PlaneSeatItemUC ctrPlaneSeatItemUC = ctr as PlaneSeatItemUC;
                        listSeat.AddRange(ctrPlaneSeatItemUC.Seats);
                    }
                }

                (bool isCreateSeat, string label1) = await SeatDAL.Ins.createSeats(listSeat, newID);

                if (isCreateSeat)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void setCurrentTicketClass()
        {
            if (SelectedTicketClass != null)
            {
                lbTextTicketClass.ForeColor = BaseColor.Den;
                lbTextTicketClass.Text = SelectedTicketClass.TicketClassName;
                pnCurrentTicketClass.BackColor = SelectedTicketClass.ColorTicketClass;
            }

            lbTextTicketClass.MaximumSize = new Size(pnCurrentTicketClass.Width - 10 * 2 - 10, 0);
            lbTextTicketClass.Left = (pnCurrentTicketClass.Width - 10 - lbTextTicketClass.Width) / 2;
            lbTextTicketClass.Top = (pnCurrentTicketClass.Height - lbTextTicketClass.Height) / 2;
        }

        private void abtnCancel_Click(object sender, EventArgs e)
        {
            Control ctr = this;
            while (!(ctr is PlaneUC))
                ctr = ctr.Parent;

            PlaneUC ctrParent = ctr as PlaneUC;
            ctrParent.abtnPlaneList_Click(sender, e);
        }

        private void abtnUpdatePlane_Click(object sender, EventArgs e)
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
            else if (int.Parse(atbSeatCount.Texts.Trim()) != pnSeat.Controls.Count * 6 / 2)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu số lượng ghế chưa đồng nhất vui lòng tải lại danh sách ghế", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atbSeatCount.Focus();
                ms.ShowDialog();
            }
            else
            {
                updatePlane();
            }
        }

        private async void updatePlane()
        {
            PlaneDTO newPlane = new PlaneDTO(atbPlaneName.Texts.Trim(), int.Parse(atbSeatCount.Texts.Trim()), plane.PlaneID);

            (bool isUpdatePlane, string label) = await PlaneDAL.Ins.updatePlane(newPlane);

            if (isUpdatePlane)
            {
                List<SeatDTO> listSeat = new List<SeatDTO>();

                foreach (Control ctr in pnSeat.Controls)
                {
                    if (ctr is PlaneSeatItemUC)
                    {
                        PlaneSeatItemUC ctrPlaneSeatItemUC = ctr as PlaneSeatItemUC;
                        listSeat.AddRange(ctrPlaneSeatItemUC.Seats);
                    }
                }

                (bool isUpdateSeat, string label1) = await SeatDAL.Ins.updateSeats(plane, listSeat);

                if (isUpdateSeat)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void atbPlaneName__KeyDown(object sender, EventArgs e)
        {
            Helper.enterOnlyLetter(e);
        }

        private void atbSeatCount__KeyDown(object sender, EventArgs e)
        {
            Helper.enterOnlyNumber(e);
        }
    }
}
