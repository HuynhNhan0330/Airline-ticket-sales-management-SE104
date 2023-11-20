using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DALs
{
    public class PlaneDAL
    {
        private static PlaneDAL _ins;
        public static PlaneDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new PlaneDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, string)> createPlane(PlaneDTO plane)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    PLANE findPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneName == plane.PlaneName);
                    if (findPlane != null)
                        return (false, "Tên máy bay đã tồn tại");

                    string currentMaxCode = await context.PLANEs.MaxAsync(pe => pe.PlaneID);
                    string newCode = Helper.nextCode(currentMaxCode, "PE");

                    PLANE newPlane = new PLANE
                    {
                        PlaneID = newCode,
                        PlaneName = plane.PlaneName,
                        SeatCount = plane.SeatCount
                    };

                    context.PLANEs.Add(newPlane);

                    context.SaveChanges();

                    return (true, "Tạo máy bay thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, List<PlaneDTO>, string)> getListPlane()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var PlaneList = (from plane in context.PLANEs
                                       select new PlaneDTO
                                       {
                                           PlaneID = plane.PlaneID,
                                           PlaneName = plane.PlaneName,
                                           SeatCount = plane.SeatCount
                                       }).ToListAsync();

                    return (true, await PlaneList, "Lấy danh sách máy bay thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> deletePlane(PlaneDTO plane)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    PLANE planeDelete = context.PLANEs.FirstOrDefault(pe => pe.PlaneID == plane.PlaneID);

                    context.PLANEs.Remove(planeDelete);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> updatePlane(PlaneDTO plane)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    PLANE findPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneName == plane.PlaneName && pe.PlaneID != plane.PlaneID);
                    if (findPlane != null)
                        return (false, "Tên máy bay đã tồn tại");

                    PLANE currentPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneID == plane.PlaneID);
                    currentPlane.PlaneName = plane.PlaneName;
                    currentPlane.SeatCount = plane.SeatCount;

                    context.SaveChanges();

                    return (true, "Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }

}
