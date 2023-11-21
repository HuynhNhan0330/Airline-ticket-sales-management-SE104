using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DALs
{
    public class SeatDAL
    {
        private static SeatDAL _ins;
        public static SeatDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new SeatDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createSeats(List<SeatDTO> seats, string planeID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var seatList= (from s in seats
                                   select new SEAT
                                   {
                                       SeatID = s.SeatID,
                                       PlaneID = planeID,
                                       TicketClassID = s.TicketClass.TicketClassID
                                   }).ToList();


                    context.SEATs.AddRange(seatList);
                    context.SaveChanges();

                    return (true, "Thêm ghế thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        //public async Task<(bool, List<PlaneDTO>, string)> getListPlane()
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            var PlaneList = (from plane in context.PLANEs
        //                             select new PlaneDTO
        //                             {
        //                                 PlaneID = plane.PlaneID,
        //                                 PlaneName = plane.PlaneName,
        //                                 SeatCount = plane.SeatCount
        //                             }).ToListAsync();

        //            return (true, await PlaneList, "Lấy danh sách máy bay thành công!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, null, ex.Message);
        //    }
        //}

        //public async Task<(bool, string)> deletePlane(PlaneDTO plane)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            PLANE planeDelete = context.PLANEs.FirstOrDefault(pe => pe.PlaneID == plane.PlaneID);

        //            context.PLANEs.Remove(planeDelete);
        //            context.SaveChanges();

        //            return (true, "Xoá thành công");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, ex.Message);
        //    }
        //}

        //public async Task<(bool, string)> updatePlane(PlaneDTO plane)
        //{
        //    try
        //    {
        //        using (var context = new FlightTicketManagementEntities())
        //        {
        //            PLANE findPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneName == plane.PlaneName && pe.PlaneID != plane.PlaneID);
        //            if (findPlane != null)
        //                return (false, "Tên máy bay đã tồn tại");

        //            PLANE currentPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneID == plane.PlaneID);
        //            currentPlane.PlaneName = plane.PlaneName;
        //            currentPlane.SeatCount = plane.SeatCount;

        //            context.SaveChanges();

        //            return (true, "Cập nhật thành công");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return (false, ex.Message);
        //    }
        //}
    }
}
