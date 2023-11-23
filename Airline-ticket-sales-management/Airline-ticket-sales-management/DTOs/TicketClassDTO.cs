using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Builders;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class TicketClassDTO
    {
        public string TicketClassID { get; set; }
        public string TicketClassName { get; set; }
        public int PricePercentage { get; set; }
        public Color ColorTicketClass { get; set; }
        public TicketClassDTO() { }

        public TicketClassDTO(string TicketClassName, int PricePercentage, string TicketClassID = "")
        {
            this.TicketClassName = TicketClassName;
            this.PricePercentage = PricePercentage;
            this.TicketClassID = TicketClassID;
        }
    }
}
