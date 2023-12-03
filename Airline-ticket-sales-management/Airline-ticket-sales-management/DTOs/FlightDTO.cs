using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class FlightDTO
    {
        public string FlightID { get; set; }
        public string PlaneID { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DepartureAirportName { get; set; }
        public string DepartureCityName { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string ArrivalAirportName {  get; set; }
        public string ArrivalCityName { get; set; }
        public decimal TicketPrice { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public int FlightDuration { get; set; }

        public FlightDTO() { }
    }
}
