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
    public class AccountDAL
    {
        private static AccountDAL _ins;
        public static AccountDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new AccountDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(AccountDTO, string)> login(string username, string password)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    AccountDTO account = (from ac in context.ACCOUNTs
                                          where (ac.Phone == username || ac.Email == username) && ac.Password == password
                                          select new AccountDTO
                                          {
                                              AccountID = ac.AccountID,
                                              Name = ac.Name,
                                              Email = ac.Email,
                                              Phone = ac.Phone,
                                              Password = ac.Password,
                                              Created = DateTime.Now,
                                              RoleID = ac.RoleID,
                                          }).FirstOrDefault();

                    if (account == null)
                        return (null, "Tài khoản hoặc mật khẩu không đúng");

                    account.PermissionCode = context.PERMISSIONs.First(pe => pe.RoleID == account.RoleID).PermissionCode;

                    return (account, "Đăng nhập thành công");
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        //public async Task<(bool, string, string)> createFlight(FlightDTO flight)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            string currentMaxCode = await context.FLIGHTs.MaxAsync(fl => fl.FlightID);
        //            string newCode = Helper.nextCode(currentMaxCode, "FL");

        //            FLIGHT newFlight = new FLIGHT
        //            {
        //                FlightID = newCode,
        //                PlaneID = flight.PlaneID,
        //                DepartureAirportCode = flight.DepartureAirportCode,
        //                ArrivalAirportCode = flight.ArrivalAirportCode,
        //                DepartureDateTime = flight.DepartureDateTime,
        //                FlightDuration = flight.FlightDuration,
        //                TicketPrice = flight.TicketPrice
        //            };

        //            context.FLIGHTs.Add(newFlight);

        //            context.SaveChanges();

        //            return (true, "Tạo chuyến bay thành công!", newCode);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, ex.Message, null);
        //    }
        //}

        //public async Task<(bool, List<FlightDTO>, string)> getListFlight()
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            var FlightList = (from flight in context.FLIGHTs
        //                              join departureAirport in context.AIRPORTs
        //                              on flight.DepartureAirportCode equals departureAirport.AirportID
        //                              join arrivalAirport in context.AIRPORTs
        //                              on flight.ArrivalAirportCode equals arrivalAirport.AirportID
        //                              select new FlightDTO
        //                              {
        //                                  FlightID = flight.FlightID,
        //                                  PlaneID = flight.PlaneID,
        //                                  DepartureAirportCode = flight.DepartureAirportCode,
        //                                  DepartureAirportName = departureAirport.AirportName,
        //                                  DepartureCityName = departureAirport.CityName,
        //                                  ArrivalAirportCode = flight.ArrivalAirportCode,
        //                                  ArrivalAirportName = arrivalAirport.AirportName,
        //                                  ArrivalCityName = arrivalAirport.CityName,
        //                                  TicketPrice = flight.TicketPrice,
        //                                  DepartureDateTime = flight.DepartureDateTime,
        //                                  FlightDuration = flight.FlightDuration,
        //                              }).ToListAsync();

        //            return (true, await FlightList, "Lấy danh sách chuyến bay thành công!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, null, ex.Message);
        //    }
        //}

        //public async Task<(bool, string)> deleteFlight(string flightID)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            FLIGHT flightDelete = context.FLIGHTs.FirstOrDefault(fl => fl.FlightID == flightID);

        //            context.FLIGHTs.Remove(flightDelete);
        //            context.SaveChanges();

        //            return (true, "Xoá thành công");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, ex.Message);
        //    }
        //}

        //public async Task<(bool, string)> updateFlight(FlightDTO flight)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            FLIGHT currentFlight = context.FLIGHTs.FirstOrDefault(fl => fl.FlightID == flight.FlightID);
        //            currentFlight.PlaneID = flight.PlaneID;
        //            currentFlight.DepartureAirportCode = flight.DepartureAirportCode;
        //            currentFlight.ArrivalAirportCode = flight.ArrivalAirportCode;
        //            currentFlight.DepartureDateTime = flight.DepartureDateTime;
        //            currentFlight.FlightDuration = flight.FlightDuration;
        //            currentFlight.TicketPrice = flight.TicketPrice;

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
