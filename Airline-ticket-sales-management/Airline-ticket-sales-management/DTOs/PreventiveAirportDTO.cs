using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class PreventiveAirportDTO
    {
        public string FlightID { get; set; }
        public string PreventiveAirportID { get; set; }
        public string AirportName { get; set; }
        public string CityName { get; set; }
        public int StopoverDuration { get; set; }
        public string Note { get; set; }
    }
}
