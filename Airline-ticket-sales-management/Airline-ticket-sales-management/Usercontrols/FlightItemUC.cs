using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Service;
using SixLabors.ImageSharp.Formats;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class FlightItemUC : UserControl
    {
        private int margintb = 15;
        private int marginlr = 10;

        private FlightDTO _flight;
        public FlightDTO flight
        {
            get { return _flight; }
            set
            {
                _flight = value;

                load();
            }
        }

        private ObservableCollection<FlightTicketClassDetailDTO> flightTicketClassDetails;
        private int EmptySeat = 0;
        private int ReservedSeat = 0;

        public FlightItemUC()
        {
            InitializeComponent();
        }

        private async void load()
        {
            await setFlightTicketClassDetail();
            render();
        }

        private void render()
        {
            lbFlightID.Text = flight.FlightID;
            lbFlightID.Left = (pnFlightID.Width - lbFlightID.Width) / 2;
            this.Height = Math.Max(this.Height, lbFlightID.Height + margintb * 2);

            lbDepartureAirport.Text = flight.DepartureAirportName;
            lbDepartureAirport.Top = margintb;
            lbDepartureAirport.Left = (pnDepartureAirport.Width - lbDepartureAirport.Width) / 2;
            this.Height = Math.Max(this.Height, lbDepartureAirport.Height + margintb * 2);

            lbDeparture.Text = flight.DepartureCityName;
            lbDeparture.Left = (pnDeparture.Width - lbDeparture.Width) / 2;
            this.Height = Math.Max(this.Height, lbDeparture.Height + margintb * 2);

            lbArrivalAirport.Text = flight.ArrivalAirportName;
            lbArrivalAirport.Left = (pnArrivalAirport.Width - lbArrivalAirport.Width) / 2;
            this.Height = Math.Max(this.Height, lbArrivalAirport.Height + margintb * 2);

            lbArrival.Text = flight.ArrivalCityName;
            lbArrival.Left = (pnArrival.Width - lbArrival.Width) / 2;
            this.Height = Math.Max(this.Height, lbArrival.Height + margintb * 2);

            lbEmptySeat.Text = EmptySeat.ToString();
            lbEmptySeat.Left = (pnEmptySeat.Width - lbEmptySeat.Width) / 2;
            this.Height = Math.Max(this.Height, lbEmptySeat.Height + margintb * 2);

            DateTime arrivalTime = flight.DepartureDateTime.AddMinutes(flight.FlightDuration);
            lbFlightTime.Text = flight.DepartureDateTime.ToString("HH:mm") + "-" + arrivalTime.ToString("HH:mm");
            lbFlightTime.Left = (pnFlightTime.Width - lbFlightTime.Width) / 2;
            this.Height = Math.Max(this.Height, lbFlightTime.Height + margintb * 2);

            lbReservedSeat.Text = ReservedSeat.ToString();
            lbReservedSeat.Left = (pnReservedSeat.Width - lbReservedSeat.Width) / 2;
            this.Height = Math.Max(this.Height, lbReservedSeat.Height + margintb * 2);

            lbFlightID.Top = (this.Height - lbFlightID.Height) / 2;
            lbDepartureAirport.Top = (this.Height - lbDepartureAirport.Height) / 2;
            lbDeparture.Top = (this.Height - lbDeparture.Height) / 2;
            lbArrivalAirport.Top = (this.Height - lbArrivalAirport.Height) / 2;
            lbArrival.Top = (this.Height - lbArrival.Height) / 2;
            lbEmptySeat.Top = (this.Height - lbEmptySeat.Height) / 2;
            lbReservedSeat.Top = (this.Height - lbReservedSeat.Height) / 2;
            lbFlightTime.Top = (this.Height - lbFlightTime.Height) / 2;
            abtnBookTicket.Top = (this.Height - abtnBookTicket.Height) / 2;
            pibDelete.Top = (this.Height - abtnBookTicket.Height) / 2;
            pibEdit.Top = (this.Height - abtnBookTicket.Height) / 2;
            lbFlightDetail.Top = abtnBookTicket.Top + abtnBookTicket.Height + 5;

            this.Height = Math.Max(this.Height, lbFlightDetail.Height + lbFlightDetail.Top + 5);
        }

        private async Task setFlightTicketClassDetail()
        {
            (bool isGetFlightTicketClassDetail, List<FlightTicketClassDetailDTO> FlightTicketClassDetails, string label) = await FlightTicketClassDetailDAL.Ins.getListFlightTicketClassDetail(flight.FlightID);
            flightTicketClassDetails = new ObservableCollection<FlightTicketClassDetailDTO>(FlightTicketClassDetails);

            foreach (FlightTicketClassDetailDTO ftcd in flightTicketClassDetails)
            {
                EmptySeat += ftcd.SeatRemaining;
                ReservedSeat += ftcd.TicketSold;
            }
        }

        private void pibEdit_Click(object sender, EventArgs e)
        {
            // Chỉ sửa khi chưa có ai đặt vé

            if (TicketDAL.Ins.checkFlightHasTicket(flight.FlightID))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Chuyến bay đã có người đặt vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();

                return;
            }

            Control uc = this;

            while (!(uc is FlightUC))
                uc = uc.Parent;

            FlightUC ucFlight = uc as FlightUC;

            ucFlight.abtnDetailFlight_Click(sender, e);
            ucFlight.loadBody(new OperationFlightUC(this.flight));
        }

        private void pibDelete_Click(object sender, EventArgs e)
        {
            // Chỉ xoá khi chưa có ai đặt vé

            if (TicketDAL.Ins.checkFlightHasTicket(flight.FlightID))
            {
                AMessageBoxFrm ms1 = new AMessageBoxFrm("Chuyến bay đã có người đặt vé", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms1.ShowDialog();

                return;
            }

            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
                deleteFlight();
        }

        private async void deleteFlight()
        {
            (bool isDelete, string label) = await FlightService.Ins.deleteFlight(flight.FlightID);
            if (isDelete)
            {
                Control uc = this.Parent;
                
                while (!(uc is FlightListUC))
                    uc = uc.Parent;

                FlightListUC flightListUC = uc as FlightListUC;
                flightListUC.deleteFlightItem(this);

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnBookTicket_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.AddDays(ParametersDTO.Ins.EarliestBookingTime) <= flight.DepartureDateTime)
            {
                FormAdminHome form = Application.OpenForms.OfType<FormAdminHome>().FirstOrDefault();
                form.goToTicket(flight);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Hiện tại đã trễ để đặt vé chuyến bay này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
