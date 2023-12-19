using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class DetailedAnnualRevenueReportDTO
    {
        public int STT { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int FlightCount { get; set; }
        public decimal Revenue { get; set; }
        public decimal Ratio {  get; set; }
    }
}
