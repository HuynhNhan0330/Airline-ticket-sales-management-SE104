using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.DALs
{
    public class TicketDAL
    {
        private static TicketDAL _ins;
        public static TicketDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new TicketDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createTicket(TicketDTO ticket)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    string currentMaxCode = await context.FLIGHT_TICKET.MaxAsync(tk => tk.FlightTicketID);
                    string newCode = Helper.nextCode(currentMaxCode, "TK");

                    FLIGHT_TICKET flightTicket = new FLIGHT_TICKET
                    {
                        FlightTicketID = newCode,
                        FlightID = ticket.FlightID,
                        TicketClassID = ticket.TicketClassID,
                        FullName = ticket.FullName,
                        IDCard = ticket.IDCard,
                        PhoneNumber = ticket.PhoneNumber,
                        Email = ticket.Email,
                        Price = ticket.Price,
                        SeatID = ticket.SeatID,
                    };

                    if (string.IsNullOrEmpty(ticket.SeatID))
                        flightTicket.FlightStatus = "Đã mua";
                    else
                        flightTicket.FlightStatus = "Đã đặt chỗ";


                    context.FLIGHT_TICKET.Add(flightTicket);

                    context.SaveChanges();

                    return (true, "Tạo vé thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        // Kiểm tra ghế đó đã có trong vé nào chưa
        public async Task<bool> checkSeat(string flightID, string seatID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var find = context.FLIGHT_TICKET.FirstOrDefault(tk => tk.FlightStatus != "Đã huỷ" && tk.SeatID == seatID && tk.FlightID == flightID);

                    return find != null;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //public async Task<(bool, List<AirportDTO>, string)> getListAirport()
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            var AirportList = (from airport in context.AIRPORTs
        //                               select new AirportDTO
        //                               {
        //                                   AirportID = airport.AirportID,
        //                                   AirportName = airport.AirportName,
        //                                   CityName = airport.CityName,
        //                                   CountryName = airport.CountryName,
        //                               }).ToListAsync();

        //            return (true, await AirportList, "Lấy danh sách sân bay thành công!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, null, ex.Message);
        //    }
        //}

        //public async Task<(bool, string)> updateAirport(AirportDTO airport)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            AIRPORT findAirport = context.AIRPORTs.FirstOrDefault(ap => ap.AirportName == airport.AirportName && ap.AirportID != airport.AirportID);
        //            if (findAirport != null)
        //                return (false, "Tên sân bay đã tồn tại");

        //            AIRPORT currentAirport = context.AIRPORTs.FirstOrDefault(ap => ap.AirportID == airport.AirportID);
        //            currentAirport.AirportName = airport.AirportName;
        //            currentAirport.CityName = airport.CityName;
        //            currentAirport.CountryName = airport.CountryName;

        //            context.SaveChanges();

        //            return (true, "Cập nhật thành công");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, ex.Message);
        //    }
        //}
    }
}
