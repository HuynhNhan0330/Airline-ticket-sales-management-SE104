using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

        public async Task<(bool, List<TicketDTO>, string label)> getTicketByMonth(int month, int year)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var TicketList = (from ticket in context.FLIGHT_TICKET
                                      join flight in context.FLIGHTs
                                      on ticket.FlightID equals flight.FlightID
                                      where ticket.FlightStatus != "Đã huỷ" && flight.DepartureDateTime.Month == month && flight.DepartureDateTime.Month == year
                                      select new TicketDTO
                                      {
                                          TicketID = ticket.FlightTicketID,
                                          FlightID = flight.FlightID,
                                          TicketClassID = ticket.TicketClassID,
                                          Email = ticket.Email,
                                          PhoneNumber = ticket.PhoneNumber,
                                          FullName = ticket.FullName,
                                          FlightStatus = ticket.FlightStatus,
                                          IDCard = ticket.IDCard,
                                          Price = ticket.Price,
                                          SeatID = ticket.SeatID
                                      }).ToListAsync();
                
                    return (true, await TicketList, "Lấy danh sách vé theo tháng thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public bool checkFlightHasTicket(string fligthID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var ticket = context.FLIGHT_TICKET.FirstOrDefault(tk => tk.FlightID == fligthID && tk.FlightStatus != "Đã huỷ");

                    return ticket != null;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<(bool, List<TicketDTO>, string)> getListTicket()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var TicketList = (from ticket in context.FLIGHT_TICKET
                                      join flight in context.FLIGHTs
                                      on ticket.FlightID equals flight.FlightID
                                      join ticketClass in context.TICKET_CLASS
                                      on ticket.TicketClassID equals ticketClass.TicketClassID
                                      where ticket.FlightStatus != "Đã huỷ"
                                      select new TicketDTO
                                      {
                                          TicketID = ticket.FlightTicketID,
                                          FlightID = flight.FlightID,
                                          TicketClassID = ticket.TicketClassID,
                                          Email = ticket.Email,
                                          PhoneNumber = ticket.PhoneNumber,
                                          FullName = ticket.FullName,
                                          FlightStatus = ticket.FlightStatus,
                                          IDCard = ticket.IDCard,
                                          Price = ticket.Price,
                                          SeatID = ticket.SeatID,
                                          DepartureDateTime = flight.DepartureDateTime,
                                          TicketClassName = ticketClass.TicketClassName
                                      }).ToListAsync();

                    return (true, await TicketList, "Lấy danh sách vé thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> cancelTicket(TicketDTO ticket)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    FLIGHT_TICKET currentTicket = context.FLIGHT_TICKET.FirstOrDefault(tk => tk.FlightTicketID == ticket.TicketID);
                    currentTicket.FlightStatus = "Đã huỷ";

                    context.SaveChanges();

                    return (true, "Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
