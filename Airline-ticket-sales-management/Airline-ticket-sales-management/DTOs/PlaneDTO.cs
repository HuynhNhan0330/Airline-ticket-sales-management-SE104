using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class PlaneDTO
    {
        public string PlaneID {  get; set; }
        public string PlaneName { get; set; }
        public int SeatCount { get; set; }

        public PlaneDTO(string planeName, int seatCount, string planeID = "")
        {
            PlaneName = planeName;
            SeatCount = seatCount;
            PlaneID = planeID;
        }

        public PlaneDTO() { }
    }
}
