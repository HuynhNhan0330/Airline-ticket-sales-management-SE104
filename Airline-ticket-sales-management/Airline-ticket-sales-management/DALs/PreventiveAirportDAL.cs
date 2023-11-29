using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
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
