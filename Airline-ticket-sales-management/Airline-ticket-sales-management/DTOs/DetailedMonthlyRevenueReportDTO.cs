using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class DetailedMonthlyRevenueReportDTO
    {
        public int STT { get; set; }
        public int Year { get; set; }
        public int Monthly { get; set; }
        public string FlightID {  get; set; }
        public string FlightName { get; set; }
        public int TicketSold { get; set; }
        public decimal Revenue { get; set; }
        public decimal Ratio { get; set; }
    }
}
