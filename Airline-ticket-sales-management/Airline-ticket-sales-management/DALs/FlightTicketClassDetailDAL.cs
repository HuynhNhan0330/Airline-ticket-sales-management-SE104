using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DALs
{
    public class FlightTicketClassDetailDAL
    {
        private static FlightTicketClassDetailDAL _ins;
        public static FlightTicketClassDetailDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new FlightTicketClassDetailDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createFlgihtTicketClassDetail(FlightDTO flight)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    // Lấy chi tiết ghế máy bay
                    (List<PlaneTicketClassDetailDTO> PlaneTicketClassDetailList, string label) = await PlaneDAL.Ins.getPlaneTicketClassDetail(flight.PlaneID);
                    
                    if (PlaneTicketClassDetailList != null)
                    {
                        var FlightTicketClassDetails = (from ptcd in PlaneTicketClassDetailList
                                                        select new FLIGHT_TICKET_CLASS_DETAIL
                                                        {
                                                            FlightID = flight.FlightID,
                                                            TicketClassID = ptcd.TicketClass.TicketClassID,
                                                            Fare = flight.TicketPrice * ptcd.TicketClass.PricePercentage / 100,
                                                            TicketSold = 0,
                                                            SeatCapacity = ptcd.Quantity,
                                                            SeatRemaining = ptcd.Quantity
                                                        }).ToList();
                        
                        context.FLIGHT_TICKET_CLASS_DETAIL.AddRange(FlightTicketClassDetails);
                        context.SaveChanges();

                        return (true, "Tạo chi tiết hạng vé chuyến bay thành công!");
                    }
                    else
                    {
                        return (false, label);
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, List<FlightTicketClassDetailDTO>, string)> getListFlightTicketClassDetail(string flightID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var FlightTicketClassDetailList = (from ftcd in context.FLIGHT_TICKET_CLASS_DETAIL
                                                       where ftcd.FlightID == flightID
                                                       select new FlightTicketClassDetailDTO
                                                       {
                                                           FlightID = flightID,
                                                           TicketClassID = ftcd.TicketClassID,
                                                           Fare = ftcd.Fare,
                                                           TicketSold = ftcd.TicketSold,
                                                           SeatCapacity = ftcd.SeatCapacity,
                                                           SeatRemaining= ftcd.SeatRemaining
                                                       }).ToListAsync();

                    return (true, await FlightTicketClassDetailList, "Lấy danh sách chi tiết chuyến bay thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> deleteFlightTicketClassDetail(string flightID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var flightTicketClassDetailDelete = context.FLIGHT_TICKET_CLASS_DETAIL.Where(ftcd => ftcd.FlightID == flightID).ToList();

                    context.FLIGHT_TICKET_CLASS_DETAIL.RemoveRange(flightTicketClassDetailDelete);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

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
