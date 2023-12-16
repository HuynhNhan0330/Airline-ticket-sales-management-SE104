using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public async Task<(bool, string)> createDetailedAnnualRevenueReport(DetailedAnnualRevenueReportDTO detailAnnualRevenueReport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    DETAILED_ANNUAL_REVENUE_REPORT newdetailAnnualRevenueReport = new DETAILED_ANNUAL_REVENUE_REPORT
                    {
                        Years = detailAnnualRevenueReport.Year,
                        Months = detailAnnualRevenueReport.Month,
                        Revenue = detailAnnualRevenueReport.Revenue,
                        FlightCount = detailAnnualRevenueReport.FlightCount
                    };

                    context.DETAILED_ANNUAL_REVENUE_REPORT.Add(newdetailAnnualRevenueReport);

                    context.SaveChanges();

                    return (true, "Tạo chi tiết báo cáo năm thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> createDetailedAnnualRevenueReport(List<DetailedAnnualRevenueReportDTO> detailedAnnualRevenueReport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var detailedAnnualRevenueReports = (from darr in detailedAnnualRevenueReport
                                                         select new DETAILED_ANNUAL_REVENUE_REPORT
                                                         {
                                                             Years = darr.Year,
                                                             Months = darr.Month,
                                                             Revenue = darr.Revenue,
                                                             FlightCount = darr.FlightCount,
                                                             Ratio = darr.Ratio,
                                                         }).ToList();

                    context.DETAILED_ANNUAL_REVENUE_REPORT.AddRange(detailedAnnualRevenueReports);
                    context.SaveChanges();

                    return (true, "Tạo chi tiết báo cáo tháng thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, List<DetailedAnnualRevenueReportDTO>, string)> getListDetailedAnnualRevenueReport(int year)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var DetailedAnnualRevenueReportList = (from darp in context.DETAILED_ANNUAL_REVENUE_REPORT
                                                           select new DetailedAnnualRevenueReportDTO
                                                           {
                                                               Year = darp.Years,
                                                               Month = darp.Months,
                                                               Revenue = darp.Revenue,
                                                               Ratio = darp.Ratio,
                                                               FlightCount = darp.FlightCount
                                                           }).ToListAsync();

                    return (true, await DetailedAnnualRevenueReportList, "Lấy danh sách chi tiết báo cáo năm thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

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

        public async Task update(List<DetailedAnnualRevenueReportDTO> ListAnnualRevenueReport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    foreach (var arr in ListAnnualRevenueReport)
                    {
                        var detailedAnnualRevenueReport = context.DETAILED_ANNUAL_REVENUE_REPORT.FirstOrDefault(darr => darr.Years == arr.Year && darr.Months == arr.Month);
                        if (detailedAnnualRevenueReport != null)
                            detailedAnnualRevenueReport.Ratio = arr.Ratio;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
