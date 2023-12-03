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
    public class FlightDAL
    {
        private static FlightDAL _ins;
        public static FlightDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new FlightDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string, string)> createFlight(FlightDTO flight)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    string currentMaxCode = await context.FLIGHTs.MaxAsync(fl => fl.FlightID);
                    string newCode = Helper.nextCode(currentMaxCode, "FL");

                    FLIGHT newFlight = new FLIGHT
                    {
                        FlightID = newCode,
                        PlaneID = flight.PlaneID,
                        DepartureAirportCode = flight.DepartureAirportCode,
                        ArrivalAirportCode = flight.ArrivalAirportCode,
                        DepartureDateTime = flight.DepartureDateTime,
                        FlightDuration = flight.FlightDuration,
                        TicketPrice = flight.TicketPrice
                    };

                    context.FLIGHTs.Add(newFlight);

                    context.SaveChanges();

                    return (true, "Tạo chuyến bay thành công!", newCode);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool, List<FlightDTO>, string)> getListFlight()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var FlightList = (from flight in context.FLIGHTs
                                      join departureAirport in context.AIRPORTs 
                                      on flight.DepartureAirportCode equals departureAirport.AirportID
                                      join arrivalAirport in context.AIRPORTs 
                                      on flight.ArrivalAirportCode equals arrivalAirport.AirportID
                                      select new FlightDTO
                                       {
                                           FlightID = flight.FlightID,
                                           PlaneID = flight.PlaneID,
                                           DepartureAirportCode = flight.DepartureAirportCode,
                                           DepartureAirportName = departureAirport.AirportName,
                                           DepartureCityName = departureAirport.CityName,
                                           ArrivalAirportCode = flight.ArrivalAirportCode,
                                           ArrivalAirportName = arrivalAirport.AirportName,
                                           ArrivalCityName = arrivalAirport.CityName,
                                           TicketPrice = flight.TicketPrice,
                                           DepartureDateTime = flight.DepartureDateTime,
                                           FlightDuration = flight.FlightDuration,
                                       }).ToListAsync();

                    return (true, await FlightList, "Lấy danh sách chuyến bay thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        //public async Task<(bool, string)> deleteAirport(AirportDTO airport)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            AIRPORT airportDelete = context.AIRPORTs.FirstOrDefault(ap => ap.AirportID == airport.AirportID);

        //            context.AIRPORTs.Remove(airportDelete);
        //            context.SaveChanges();

        //            return (true, "Xoá thành công");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, ex.Message);
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
