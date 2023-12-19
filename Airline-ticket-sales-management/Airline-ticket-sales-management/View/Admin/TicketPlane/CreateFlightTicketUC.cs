using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Usercontrols;
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

namespace Airline_ticket_sales_management
{
    public partial class CreateFlightTicketUC : UserControl
    {
        private ObservableCollection<TicketClassDTO> ticketClasses;
        private ObservableCollection<FlightDTO> flights;
        private FlightDTO flight = null;
        
        private TicketClassDTO _ticketClassSelected = null;
        public TicketClassDTO ticketClassSelected
        {
            get { return _ticketClassSelected; }
            set
            {
                _ticketClassSelected = value;
            }
        }

        private string _seatID = null;
        public string seatID
        {
            get { return _seatID; }
            set
            {
                _seatID = value;
            }
        }

        public CreateFlightTicketUC()
        {
            InitializeComponent();
            loadTicketClass();
        }

        public CreateFlightTicketUC(FlightDTO flight)
        {
            InitializeComponent();
            loadTicketClass();
            this.flight = flight;
            atxbFlightID.Texts = flight.FlightID;
            atxbFlightID.isPlaceholder = false;
            atxbFlightID.setForeColor();
            loadSeat();
        }

        private void CreateFlightTicketUC_Load(object sender, EventArgs e)
        {
            setComplete();
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

        private void addTicketClassItem(TicketClassDTO ticketClass, int colorPosition)
        {
            PlaneTicketClassItemUC uc = new PlaneTicketClassItemUC("Ticket");
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

        private async void setComplete()
        {
            (bool isGet, List<FlightDTO> flights, string label) = await FlightDAL.Ins.getListFlight();

            if (isGet)
            {
                List<string> completes = new List<string>();

                foreach (FlightDTO flight in flights)
                    completes.Add(flight.FlightID);

                atxbFlightID.complete(completes);
            }
        }

        private void atxbFlightID__TextChanged(object sender, EventArgs e)
        {
            loadSeat();
        }

        private async void loadSeat()
        {
            atxbPrice.Texts = "";
            pnSeat.Controls.Clear();

            // Khi mã chuyến bay thay đổi thì sẽ load ghế nếu flight đúng.
            // Step 1: find flight 
            this.flight = await FlightDAL.Ins.findFlight(atxbFlightID.Texts.Trim());
            if (this.flight != null)
            {
                // Step 2:
                await loadPanelSeat();
            }
        }

        private async Task loadPanelSeat()
        {
            pnSeat.Controls.Clear();
            (bool isGetSeats, List<SeatDTO> seats, string label) = await SeatDAL.Ins.getSeats(flight.PlaneID);

            if (isGetSeats)
            {
                for (int index1 = 0; index1 < seats.Count / 6; ++index1)
                {
                    PlaneSeatItemUC uc = new PlaneSeatItemUC("Ticket");

                    // Set seat
                    for (int index2 = 0; index2 < 6; ++index2)
                    {
                        seats[index1 * 6 + index2].TicketClass.ColorTicketClass = this.ticketClasses.First(tc => tc.TicketClassID == seats[index1 * 6 + index2].TicketClass.TicketClassID).ColorTicketClass;
                        uc.Seats.Add(seats[index1 * 6 + index2]);
                    }

                    uc.stt = seats[index1 * 6].SeatID[0].ToString();

                    // Ban đầu tất cả ghế đều màu gray (chưa được chọn), đỏ (nếu đã chọn)
                    // load...

                    pnSeat.Controls.Add(uc);
                    uc.BringToFront();
                    uc.Dock = DockStyle.Top;
                    uc.loadTicketColor(flight.FlightID);

                    Panel pn = new Panel();
                    pnSeat.Controls.Add(pn);
                    pn.Height = 5;
                    pn.BackColor = Color.Transparent;
                    pn.BringToFront();
                    pn.Dock = DockStyle.Top;
                }
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnCreateFlightTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbFlightID.Texts))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu mã chuyến bay không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPrice.Texts))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu giá tiền không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbFullName.Texts))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu họ và tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbIDCard.Texts))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu CMND/CCCD không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPhone.Texts))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbEmail.Texts))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkCardID(atxbIDCard.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu CMND/CCCD không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkPhone(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkEmail(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (this.flight == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu mã chuyến bay không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (this.ticketClassSelected == null)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Chưa chọn hạng vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(seatID))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Vui lòng chọn chỗ ngồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (DateTime.Now.AddDays(ParametersDTO.Ins.EarliestBookingTime) > flight.DepartureDateTime)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Hiện tại đã trễ để đặt vé chuyến bay này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
                    {
                TicketDTO ticket = new TicketDTO();
                ticket.FlightID = flight.FlightID;
                ticket.FullName = atxbFullName.Texts;
                ticket.IDCard = atxbIDCard.Texts;
                ticket.PhoneNumber = atxbPhone.Texts;
                ticket.Email = atxbEmail.Texts;
                ticket.Price = decimal.Parse(atxbPrice.Texts);
                ticket.TicketClassID = this.ticketClassSelected.TicketClassID;

                if (string.IsNullOrEmpty(seatID))
                    ticket.SeatID = "";
                else
                    ticket.SeatID = seatID;

                createTicket(ticket);
            }
        }

        private async void createTicket(TicketDTO ticket)
        {
            (bool isCreate, string label) = await TicketDAL.Ins.createTicket(ticket);

            if (isCreate)
            {
                Control ctr = this;

                while (!(ctr is FlightTicketUC))
                    ctr = ctr.Parent;

                FlightTicketUC uc = ctr as FlightTicketUC;

                AMessageBoxFrm ms = new AMessageBoxFrm("Tạo vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();

                // load lại trang để reset trang
                uc.abtnCreateFlightTicket_Click(this, EventArgs.Empty);
                
                // Giảm chi tiết hạng vé của từng chuyến bay
                 (bool isUpdate, string label1) = await FlightTicketClassDetailDAL.Ins.updateFlightTicketClassDetail(flight.FlightID, ticketClassSelected.TicketClassID);

            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void setCurrentTicketClass()
        {
            if (ticketClassSelected != null)
            {
                lbTextTicketClass.ForeColor = BaseColor.Den;
                lbTextTicketClass.Text = ticketClassSelected.TicketClassName;
                pnCurrentTicketClass.BackColor = ticketClassSelected.ColorTicketClass;
            }

            lbTextTicketClass.MaximumSize = new Size(pnCurrentTicketClass.Width - 10 * 2 - 10, 0);
            lbTextTicketClass.Left = (pnCurrentTicketClass.Width - 10 - lbTextTicketClass.Width) / 2;
            lbTextTicketClass.Top = (pnCurrentTicketClass.Height - lbTextTicketClass.Height) / 2;
        }

        public void setValidSeat()
        {
            seatID = "";

            // Khi click hạng bé thì sẽ hiện xanh các ghế phù hợp để chọn
            foreach (Control uc in pnSeat.Controls)
            {
                if (uc is PlaneSeatItemUC)
                {
                    PlaneSeatItemUC ucSeat = uc as PlaneSeatItemUC;
                    
                    // Các ghế thuộc ticketclass đó thì sẽ màu xanh nếu đã đỏ thì k đổi màu
                    ucSeat.setValidSeat(this.ticketClassSelected.TicketClassID);
                }
            }
        }

        public void deleteSeatSelected()
        {
            if (!string.IsNullOrEmpty(seatID))
                foreach (Control ctr in pnSeat.Controls)
                {
                    if (ctr is PlaneSeatItemUC)
                    {
                        PlaneSeatItemUC ctrSeat = ctr as PlaneSeatItemUC;

                        if (char.Parse(ctrSeat.stt) == seatID[0])
                            ctrSeat.clearColor(seatID[1]);
                    }
                }
        }

        public void setPrice()
        {
            if (flight != null && ticketClasses != null)
            {
                atxbPrice.Texts = (flight.TicketPrice * ticketClassSelected.PricePercentage / 100).ToString();
                atxbPrice.isPlaceholder = false;
                atxbPrice.setForeColor();
            }
        }

        private void KeyDownOnlyNumber(object sender, EventArgs e)
        {
            Helper.enterOnlyNumber(e);
        }
    }
}
