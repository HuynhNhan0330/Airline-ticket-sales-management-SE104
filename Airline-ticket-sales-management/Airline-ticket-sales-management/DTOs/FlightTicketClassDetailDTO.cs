using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class FlightTicketClassDetailDTO
    {
        public string FlightID { get; set; }
        public string TicketClassID { get; set; }
        public decimal Fare { get; set; }
        public int SeatCapacity { get; set; }
        public int TicketSold { get; set; }
        public int SeatRemaining { get; set; }
    }
}
