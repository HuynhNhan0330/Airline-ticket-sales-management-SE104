//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airline_ticket_sales_management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FLIGHT_TICKET
    {
        public string FlightTicketID { get; set; }
        public string FlightID { get; set; }
        public string TicketClassID { get; set; }
        public decimal Price { get; set; }
        public string FullName { get; set; }
        public string IDCard { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SeatID { get; set; }
        public string FlightStatus { get; set; }
    
        public virtual FLIGHT FLIGHT { get; set; }
        public virtual TICKET_CLASS TICKET_CLASS { get; set; }
    }
}
