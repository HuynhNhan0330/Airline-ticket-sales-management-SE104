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
    public class PreventiveAirportDAL
    {
        private static PreventiveAirportDAL _ins;
        public static PreventiveAirportDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new PreventiveAirportDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createFlightDetail(List<PreventiveAirportDTO> PreventiveAirports, string flightID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var flightDetailList = (from pra in PreventiveAirports
                                    select new FLIGHT_DETAIL
                                    {
                                        FlightID = flightID,
                                        PreventiveAirportID = pra.PreventiveAirportID,
                                        StopoverDuration = pra.StopoverDuration,
                                        Note = pra.Note
                                    }).ToList();

                    context.FLIGHT_DETAIL.AddRange(flightDetailList);
                    context.SaveChanges();

                    return (true, "Tạo chi tiết máy bay thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, List<PreventiveAirportDTO>, string)> getListPreventiveAirport(string flightID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var PreventiveAirportList = (from preventiveAirport in context.FLIGHT_DETAIL
                                                 where preventiveAirport.FlightID == flightID
                                                 join airport in context.AIRPORTs
                                                 on preventiveAirport.PreventiveAirportID equals airport.AirportID
                                                 select new PreventiveAirportDTO
                                                 {
                                                       PreventiveAirportID = preventiveAirport.PreventiveAirportID,
                                                       AirportName = airport.AirportName,
                                                       CityName = airport.CityName,
                                                       FlightID = preventiveAirport.FlightID,
                                                       StopoverDuration = preventiveAirport.StopoverDuration,
                                                       Note = preventiveAirport.Note
                                                 }).ToListAsync();

                    return (true, await PreventiveAirportList, "Lấy danh sách sân bay trung gian thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> deletePreventiveAirport(string flightID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var flightDetailsDelete = context.FLIGHT_DETAIL.Where(flightDetail => flightDetail.FlightID == flightID).ToList();

                    context.FLIGHT_DETAIL.RemoveRange(flightDetailsDelete);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
