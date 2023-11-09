using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class TicketClassDTO
    {
        public string TicketClassCode { get; set; }
        public string TicketClassName { get; set; }
        public int PricePercentage { get; set; }

        public TicketClassDTO() { }

        public TicketClassDTO(string TicketClassName, int PricePercentage, string TicketClassCode = "")
        {
            this.TicketClassName = TicketClassName;
            this.PricePercentage = PricePercentage;
            this.TicketClassCode = TicketClassCode;
        }
    }
}
