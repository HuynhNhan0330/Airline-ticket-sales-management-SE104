using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DALs
{
    public class AnnualRevenueReportDAL
    {
        private static AnnualRevenueReportDAL _ins;
        public static AnnualRevenueReportDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new AnnualRevenueReportDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createAnnualRevenueReport(AnnualRevenueReportDTO annualRevenueReport)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    ANNUAL_REVENUE_REPORT newAnnualRevenueReport = new ANNUAL_REVENUE_REPORT
                    {
                        Years = annualRevenueReport.Years,
                        TotalRevenue = annualRevenueReport.TotalRevenue
                    };

                    context.ANNUAL_REVENUE_REPORT.Add(newAnnualRevenueReport);

                    context.SaveChanges();

                    return (true, "Tạo báo cáo năm thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<AnnualRevenueReportDTO> find(int year)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var find = context.ANNUAL_REVENUE_REPORT.FirstOrDefault(arr => arr.Years == year);

                    if (find == null) return null;

                    AnnualRevenueReportDTO farr = new AnnualRevenueReportDTO();
                    farr.Years = find.Years;
                    farr.TotalRevenue = find.TotalRevenue;

                    return farr;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

