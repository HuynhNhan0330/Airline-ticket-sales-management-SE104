using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Service;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class OperationFlightUC : UserControl
    {
        private List<string> airportComplete = new List<string>();
        private FlightDTO flight;

        public OperationFlightUC(FlightDTO flight = null)
        {
            InitializeComponent();
            this.flight = flight;
        }

        private void OperationFlightUC_Load(object sender, EventArgs e)
        {
            loadComplete();
            loadForm();
        }

        private async void loadForm()
        {
            if (flight != null)
            {
                (bool isGetPreventive, List<PreventiveAirportDTO> preventiveAirport, string label) = await PreventiveAirportDAL.Ins.getListPreventiveAirport(flight.FlightID);

                if (!isGetPreventive)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }

                atxbDepartureAirport.Texts = flight.DepartureAirportName + " (" + flight.DepartureCityName + ")";
                atxbDepartureAirport.isPlaceholder = false;
                atxbDepartureAirport.setForeColor();

                atxbArrivalAirport.Texts = flight.ArrivalAirportName + " (" + flight.ArrivalCityName + ")";
                atxbArrivalAirport.isPlaceholder = false;
                atxbArrivalAirport.setForeColor();

                atxbPlaneID.Texts = flight.PlaneID;
                atxbPlaneID.isPlaceholder = false;
                atxbPlaneID.setForeColor();
                atxbPlaneID__TextChanged(atxbPlaneID, EventArgs.Empty);

                adtpDepartureDateTime.Value = flight.DepartureDateTime;

                atxbHour.Texts = flight.DepartureDateTime.Hour.ToString();
                atxbHour.isPlaceholder = false;
                atxbHour.setForeColor();

                atxbMinute.Texts = flight.DepartureDateTime.Minute.ToString();
                atxbMinute.isPlaceholder = false;
                atxbMinute.setForeColor();

                atxbFlightDuration.Texts = flight.FlightDuration.ToString();
                atxbFlightDuration.isPlaceholder = false;
                atxbFlightDuration.setForeColor();

                atxbTicketPrice.Texts = flight.TicketPrice.ToString();
                atxbTicketPrice.isPlaceholder = false;
                atxbTicketPrice.setForeColor();

                for (int index = 0; index < preventiveAirport.Count; ++index)
                {
                    PreventiveAirportItemUC uc = new PreventiveAirportItemUC();
                    uc.PreventiveAirport = preventiveAirport[index];
                    uc.stt = index + 1;
                    uc.setCompletePlaneID(airportComplete);
                    pnPreventiveAirport.Controls.Add(uc);
                    uc.BringToFront();
                    uc.Dock = DockStyle.Top;
                }
            }
            else
                pnEdit.Visible = false;
        }

        private async void loadComplete()
        {
            (bool isGetAirport, List<AirportDTO> airports, string label1) = await AirportDAL.Ins.getListAirport();
            (bool isGetPlane, List<PlaneDTO> planes, string label2) = await PlaneDAL.Ins.getListPlane();

            if (isGetAirport)
            {
                if (isGetPlane)
                {
                    foreach (AirportDTO airport in airports)
                        airportComplete.Add(airport.AirportName + " (" + airport.CityName+ ")");

                    atxbDepartureAirport.complete(airportComplete);
                    atxbArrivalAirport.complete(airportComplete);

                    List<string> planeComplete = new List<string>();
                    foreach (PlaneDTO plane in planes)
                        planeComplete.Add(plane.PlaneID);

                    atxbPlaneID.complete(planeComplete);

                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label2, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label1, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnCreateFlight_Click(object sender, EventArgs e)
        {
            FlightDTO flight = new FlightDTO();
            flight.DepartureAirportName = atxbDepartureAirport.Texts.Trim();
            flight.ArrivalAirportName = atxbArrivalAirport.Texts.Trim();
            flight.PlaneID = atxbPlaneID.Texts.Trim();
            

            if (string.IsNullOrEmpty(flight.DepartureAirportName))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của sân bay đi bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbDepartureAirport.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(flight.ArrivalAirportName))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của sân bay đến bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbArrivalAirport.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(flight.PlaneID))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của mã máy bay bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbPlaneID.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbHour.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của giờ bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbHour.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbMinute.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của phút bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbMinute.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbFlightDuration.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của thời gian bay bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbFlightDuration.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbTicketPrice.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của giá vé bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbTicketPrice.Focus();
                ms.ShowDialog();
            }
            else if (flight.DepartureAirportName == flight.ArrivalAirportName)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Sân bay đi và sân bay đến không được trùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!(int.Parse(atxbHour.Texts.Trim()) < 24 && int.Parse(atxbHour.Texts.Trim()) >= 0 && int.Parse(atxbMinute.Texts.Trim()) < 60 && int.Parse(atxbMinute.Texts.Trim()) >= 0))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thời gian bay không phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }    
            else if (int.Parse(atxbFlightDuration.Texts.Trim()) < ParametersDTO.Ins.MinimumFlightTime)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thời gian bay ít nhất bằng " + ParametersDTO.Ins.MinimumFlightTime, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                flight.TicketPrice = decimal.Parse(atxbTicketPrice.Texts.Trim());
                flight.FlightDuration = int.Parse(atxbFlightDuration.Texts.Trim());
                
                int hour = int.Parse(atxbHour.Texts.Trim());
                int minute = int.Parse(atxbMinute.Texts.Trim());

                flight.DepartureDateTime = new DateTime(adtpDepartureDateTime.Value.Year,
                    adtpDepartureDateTime.Value.Month,
                    adtpDepartureDateTime.Value.Day,
                    hour, minute, 0);

                if (flight.DepartureDateTime < DateTime.Now)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Thời gian bay nhỏ hơn thời gian hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
                else
                    createFlight(flight);
            }
        }

        private async void createFlight(FlightDTO flight)
        {
            List<PreventiveAirportDTO> preventiveAirports = await getFlightDetail();

            if (preventiveAirports != null)
            {
                (bool isCreateFlight, int type, string label, string flightID) = await FlightService.Ins.createFlight(flight);

                if (isCreateFlight)
                {
                    (bool isCreateDetailFlight, string label1) = await PreventiveAirportDAL.Ins.createFlightDetail(preventiveAirports, flightID);
                    
                    if (isCreateDetailFlight)
                    {
                        flight.FlightID = flightID;
                        createFlightTicketClassDetail(flight);

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
                    switch (type)
                    {
                        case 0:
                            atxbDepartureAirport.Focus();
                            break;

                        case 1:
                            atxbArrivalAirport.Focus();
                            break;

                        case 2:
                            atxbPlaneID.Focus();
                            break;
                    }

                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }

            }
        }

        private async Task<List<PreventiveAirportDTO>> getFlightDetail()
        {
            List<PreventiveAirportDTO> preventiveAirports = new List<PreventiveAirportDTO>();

            for (int index = pnPreventiveAirport.Controls.Count - 1; index >= 0; --index)
            {
                PreventiveAirportItemUC ctr = pnPreventiveAirport.Controls[index] as PreventiveAirportItemUC;

                PreventiveAirportDTO preventiveAirportDTO = await ctr.getPreventiveAirport();
                if (preventiveAirportDTO == null)
                {
                    ctr.Focus();
                    AMessageBoxFrm ms1 = new AMessageBoxFrm("Lỗi tại sân bay trung gian thứ " + ctr.stt.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms1.ShowDialog();
                    return null;
                }
                else
                    preventiveAirports.Add(preventiveAirportDTO);
            }

            return preventiveAirports;
        }

        private async void createFlightTicketClassDetail(FlightDTO flight)
        {
            (bool isCreate, string label) = await FlightTicketClassDetailDAL.Ins.createFlgihtTicketClassDetail(flight);
            if (!isCreate)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void atxbPlaneID__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(atxbPlaneID.Texts.Trim()))
                loadDetailTicketClass();
            else
                pnTicketClassDetail.Controls.Clear();
        }

        private async void loadDetailTicketClass()
        {
            (PlaneDTO plane, string label) = await PlaneDAL.Ins.findPlane(atxbPlaneID.Texts.Trim());

            if (plane != null)
            {
                (bool isGetSeat, List<SeatDTO> listSeat, string label1) = await SeatDAL.Ins.getSeats(plane);
                
                if (isGetSeat)
                {
                    Dictionary<string, int> ticketClassCounts = new Dictionary<string, int>();

                    foreach (SeatDTO seat in listSeat)
                    {
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
            }
            else
                pnTicketClassDetail.Controls.Clear();
        }

        private void abtnAddPreventiveAirport_Click(object sender, EventArgs e)
        {
            if (pnPreventiveAirport.Controls.Count < ParametersDTO.Ins.MaxPreventiveAirports)
            {
                PreventiveAirportItemUC uc = new PreventiveAirportItemUC();
                uc.stt = pnPreventiveAirport.Controls.Count + 1;
                uc.setCompletePlaneID(airportComplete);
                pnPreventiveAirport.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số lượng máy bay trung gian đã đạt tối đa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnRemovePreventiveAirport_Click(object sender, EventArgs e)
        {
            if (pnPreventiveAirport.Controls.Count > 0)
                pnPreventiveAirport.Controls.RemoveAt(0);
        }

        private void abtnCancel_Click(object sender, EventArgs e)
        {
            Control ctr = this;
            while (!(ctr is FlightUC))
                ctr = ctr.Parent;

            FlightUC ctrParent = ctr as FlightUC;
            ctrParent.abtnListFlight_Click(sender, e);
        }

        private void abtnUpdateFlight_Click(object sender, EventArgs e)
        {
            // chỉ được thay đổi khi chưa bay và chưa có ai mua vé
            // update sau

            FlightDTO flight = new FlightDTO();
            flight.DepartureAirportName = atxbDepartureAirport.Texts.Trim();
            flight.ArrivalAirportName = atxbArrivalAirport.Texts.Trim();
            flight.PlaneID = atxbPlaneID.Texts.Trim();


            if (string.IsNullOrEmpty(flight.DepartureAirportName))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của sân bay đi bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbDepartureAirport.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(flight.ArrivalAirportName))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của sân bay đến bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbArrivalAirport.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(flight.PlaneID))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của mã máy bay bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbPlaneID.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbHour.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của giờ bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbHour.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbMinute.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của phút bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbMinute.Focus();
                ms.ShowDialog();
            }
            else if (!(int.Parse(atxbHour.Texts.Trim()) < 24 && int.Parse(atxbHour.Texts.Trim()) >= 0 && int.Parse(atxbMinute.Texts.Trim()) < 60 && int.Parse(atxbMinute.Texts.Trim()) >= 0))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thời gian bay không phù hợp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbFlightDuration.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của thời gian bay bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbFlightDuration.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbTicketPrice.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu của giá vé bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbTicketPrice.Focus();
                ms.ShowDialog();
            }
            else
            {
                flight.TicketPrice = decimal.Parse(atxbTicketPrice.Texts.Trim());
                flight.FlightDuration = int.Parse(atxbFlightDuration.Texts.Trim());

                int hour = int.Parse(atxbHour.Texts.Trim());
                int minute = int.Parse(atxbMinute.Texts.Trim());

                flight.DepartureDateTime = new DateTime(adtpDepartureDateTime.Value.Year,
                    adtpDepartureDateTime.Value.Month,
                    adtpDepartureDateTime.Value.Day,
                    hour, minute, 0);

                flight.FlightID = this.flight.FlightID;

                if (flight.DepartureDateTime < DateTime.Now)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Thời gian bay nhỏ hơn thời gian hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
                else
                    updateFlight(flight);
            }
        }

        private async void updateFlight(FlightDTO flight)
        {
            List<PreventiveAirportDTO> preventiveAirports = await getFlightDetail();

            if (preventiveAirports != null)
            {
                (bool isUpdateFlight, int type, string label) = await FlightService.Ins.updateFlight(flight, preventiveAirports);

                if (isUpdateFlight)
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ms.ShowDialog();
                }
                else
                {
                    switch (type)
                    {
                        case 0:
                            atxbDepartureAirport.Focus();
                            break;

                        case 1:
                            atxbArrivalAirport.Focus();
                            break;

                        case 2:
                            atxbPlaneID.Focus();
                            break;
                    }

                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }

            }
        }

        private void KeyDownOnlyNumber(object sender, EventArgs e)
        {
            Helper.enterOnlyNumber(e);
        }
    }
}
