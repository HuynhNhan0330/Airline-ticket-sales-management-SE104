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
    public class DetailedMonthlyRevenueReportDAL
    {
        private static DetailedMonthlyRevenueReportDAL _ins;
        public static DetailedMonthlyRevenueReportDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DetailedMonthlyRevenueReportDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createDetailedMonthlyRevenueReport(List<DetailedMonthlyRevenueReportDTO> detailMonthlyRevenueReport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var detailedMonthlyRevenueReports = (from dmrr in detailMonthlyRevenueReport
                                                         select new DETAILED_MONTHLY_REVENUE_REPORT
                                                         {
                                                             Years = dmrr.Year,
                                                             Months = dmrr.Monthly,
                                                             FlightID = dmrr.FlightID,
                                                             Revenue = dmrr.Revenue,
                                                             TicketSold = dmrr.TicketSold,
                                                             Ratio = dmrr.Ratio
                                                         }).ToList();

                    context.DETAILED_MONTHLY_REVENUE_REPORT.AddRange(detailedMonthlyRevenueReports);
                    context.SaveChanges();

                    return (true, "Tạo chi tiết báo cáo tháng thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, List<DetailedMonthlyRevenueReportDTO>, string)> getListDetailedMonthlyRevenueReport(int month, int year)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var DetailedMonthlyRevenueReportList = (from dmrp in context.DETAILED_MONTHLY_REVENUE_REPORT
                                                            join flight in context.FLIGHTs
                                                            on dmrp.FlightID equals flight.FlightID
                                                            join departureAirport in context.AIRPORTs
                                                            on flight.DepartureAirportCode equals departureAirport.AirportID
                                                            join arrivalAirport in context.AIRPORTs
                                                            on flight.ArrivalAirportCode equals arrivalAirport.AirportID
                                                            where dmrp.Months == month && dmrp.Years == year
                                                           select new DetailedMonthlyRevenueReportDTO
                                                           {
                                                               Year = dmrp.Years,
                                                               Monthly = dmrp.Months,
                                                               FlightID = dmrp.FlightID,
                                                               FlightName = departureAirport.AirportName + " - " + arrivalAirport.AirportName,
                                                               Revenue = dmrp.Revenue,
                                                               Ratio = dmrp.Ratio,
                                                               TicketSold = dmrp.TicketSold,
                                                           }).ToListAsync();

                    return (true, await DetailedMonthlyRevenueReportList, "Lấy danh sách chi tiết báo cáo tháng thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<bool> checkExist(int month, int year)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var find = context.DETAILED_MONTHLY_REVENUE_REPORT.FirstOrDefault(darp => darp.Years == year && darp.Months == month);

                    if (find == null)
                        return false;
                    else
                        return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<(bool, List<DetailedMonthlyRevenueReportDTO>)> getDetailedMonthlyRevenueReportInTicket(int month, int year)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var flight = context.FLIGHTs.Where(fl => fl.DepartureDateTime.Month == month && fl.DepartureDateTime.Year == year);

                    var detailedMonthlyRevenueReports = (from fl in flight
                                                         let ticketDetails = context.FLIGHT_TICKET_CLASS_DETAIL.Where(ftcd => ftcd.FlightID == fl.FlightID)
                                                         join departureAirport in context.AIRPORTs
                                                         on fl.DepartureAirportCode equals departureAirport.AirportID
                                                         join arrivalAirport in context.AIRPORTs
                                                         on fl.ArrivalAirportCode equals arrivalAirport.AirportID
                                                         select new DetailedMonthlyRevenueReportDTO
                                                         {
                                                             Year = year,
                                                             Monthly = month,
                                                             FlightID = fl.FlightID,
                                                             FlightName = departureAirport.AirportName + " - " + arrivalAirport.AirportName,
                                                             TicketSold = ticketDetails.Sum(ftcd => ftcd.TicketSold),
                                                             Revenue = ticketDetails.Sum(ftcd => ftcd.TicketSold * ftcd.Fare),
                                                         }).ToListAsync();

                    return (true, await detailedMonthlyRevenueReports);
                }
            }
            catch (Exception ex)
            {
                return (false, null);
            }
        }
    }
}
