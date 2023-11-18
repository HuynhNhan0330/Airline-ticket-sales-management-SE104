using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class AirportDTO
    {
        public string AirportID { get; set; }
        public string AirportName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }

        public AirportDTO() { }

        public AirportDTO(string airportName, string cityName, string countryName, string airportID = "")
        {
            AirportID = airportID;
            AirportName = airportName;
            CityName = cityName;
            CountryName = countryName;
        }
    }
}
