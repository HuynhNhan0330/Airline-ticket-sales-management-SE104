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
    public class AirportDAL
    {
        private static AirportDAL _ins;
        public static AirportDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new AirportDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string, string)> createAirport(AirportDTO airport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    AIRPORT findAirport= context.AIRPORTs.FirstOrDefault(ap => ap.AirportName == airport.AirportName);
                    if (findAirport != null)
                        return (false, "Tên sân bay đã tồn tại", null);

                    string currentMaxCode = await context.AIRPORTs.MaxAsync(ap => ap.AirportCode);
                    string newCode = Helper.nextCode(currentMaxCode, "AP");

                    AIRPORT newAirport = new AIRPORT
                    {
                        AirportCode = newCode,
                        AirportName = airport.AirportName,
                        CountryName = airport.CountryName,
                        CityName = airport.CityName
                    };

                    context.AIRPORTs.Add(newAirport);

                    context.SaveChanges();

                    return (true, "Tạo sân bay thành công!", newCode);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool, List<AirportDTO>, string)> getListAirport()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var AirportList = (from airport in context.AIRPORTs
                                           select new AirportDTO
                                           {
                                               AirportCode = airport.AirportCode,
                                               AirportName= airport.AirportName,
                                               CityName= airport.CityName,
                                               CountryName= airport.CountryName,
                                           }).ToListAsync();

                    return (true, await AirportList, "Lấy danh sách sân bay thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> deleteAirport(AirportDTO airport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    AIRPORT airportDelete = context.AIRPORTs.FirstOrDefault(ap => ap.AirportCode == airport.AirportCode);

                    context.AIRPORTs.Remove(airportDelete);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> updateAirport(AirportDTO airport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    AIRPORT findAirport = context.AIRPORTs.FirstOrDefault(ap => ap.AirportName== airport.AirportName && ap.AirportCode!= airport.AirportCode);
                    if (findAirport != null)
                        return (false, "Tên sân bay đã tồn tại");

                    AIRPORT currentAirport = context.AIRPORTs.FirstOrDefault(ap => ap.AirportCode == airport.AirportCode);
                    currentAirport.AirportName = airport.AirportName;
                    currentAirport.CityName = airport.CityName;
                    currentAirport.CountryName = airport.CountryName;

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
