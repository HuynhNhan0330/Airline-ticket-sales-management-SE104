using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DALs
{
    public class DetailedAnnualRevenueReportDAL
    {
        private static DetailedAnnualRevenueReportDAL _ins;
        public static DetailedAnnualRevenueReportDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new DetailedAnnualRevenueReportDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createDetailedMonthlyRevenueReport(DetailedAnnualRevenueReportDTO detailMonthlyRevenueReport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    DETAILED_ANNUAL_REVENUE_REPORT newdetailMonthlyRevenueReport = new DETAILED_ANNUAL_REVENUE_REPORT
                    {
                        Years = detailMonthlyRevenueReport.Year,
                        Months = detailMonthlyRevenueReport.Month,
                        Revenue = detailMonthlyRevenueReport.Revenue,
                        FlightCount = detailMonthlyRevenueReport.FlightCount
                    };

                    context.DETAILED_ANNUAL_REVENUE_REPORT.Add(newdetailMonthlyRevenueReport);

                    context.SaveChanges();

                    return (true, "Tạo chi tiết báo cáo tháng thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        //public async Task<(bool, List<DetailedAnnualRevenueReportDTO>, string)> getListDetailedMonthlyRevenueReport()
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            var DetailedAnnualRevenueReportList = (from darp in context.DETAILED_ANNUAL_REVENUE_REPORT
        //                                                    select new DetailedAnnualRevenueReportDTO
        //                                                    {
        //                                                        Year = darp.Years,
        //                                                        Month = darp.Months,
        //                                                        Revenue = darp.Revenue,
        //                                                        Ratio = darp.Ratio,
        //                                                        FlightCount = darp.FlightCount
        //                                                    }).ToListAsync();

        //            return (true, await DetailedAnnualRevenueReportList, "Lấy danh sách chi tiết báo cáo năm thành công!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, null, ex.Message);
        //    }
        //}

        public async Task<DetailedAnnualRevenueReportDTO> find(int year, int month)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var find = context.DETAILED_ANNUAL_REVENUE_REPORT.FirstOrDefault(darp => darp.Years == year && darp.Months == month);

                    if (find == null) return null;

                    DetailedAnnualRevenueReportDTO darr = new DetailedAnnualRevenueReportDTO();
                    darr.Year = find.Years;
                    darr.Month = find.Months;
                    darr.Revenue = find.Revenue;
                    darr.FlightCount= find.FlightCount;
                    darr.Ratio = find.Ratio;

                    return darr;
                }
            }
            catch (Exception ex) 
            {
                return null;
            }
        }
    }
}
