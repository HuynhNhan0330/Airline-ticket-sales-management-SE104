using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public async Task<(bool, string, string)> createPlane(PlaneDTO plane)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    PLANE findPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneName == plane.PlaneName);
                    if (findPlane != null)
                        return (false, "Tên máy bay đã tồn tại", null);

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

                    return (true, "Tạo máy bay thành công!", newCode);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
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

        public async Task<(PlaneDTO, string)> findPlane(string key)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    PLANE findPlane = context.PLANEs.FirstOrDefault(pe => pe.PlaneID == key);

                    if (findPlane != null)
                    {
                        PlaneDTO planeDTO = new PlaneDTO();
                        planeDTO.PlaneID = findPlane.PlaneID;
                        planeDTO.PlaneName = findPlane.PlaneName;
                        planeDTO.SeatCount= findPlane.SeatCount;
                        return (planeDTO, "Tìm kiếm thành công máy bay");
                    }

                    return (null, "Không tồn tại máy bay tìm kiếm");
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public async Task<(List<PlaneTicketClassDetailDTO>, string)> getPlaneTicketClassDetail(string planeID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    (bool isGetSeat, List<SeatDTO> seats, string label) = await SeatDAL.Ins.getSeats(planeID);

                    List <PlaneTicketClassDetailDTO> PlaneTicketClassDetails = new List<PlaneTicketClassDetailDTO>();

                    if (isGetSeat)
                    {
                        foreach (SeatDTO seat in seats)
                        {
                            PlaneTicketClassDetailDTO PlaneTicketClassDetail = PlaneTicketClassDetails.FirstOrDefault(ptcd => ptcd.TicketClass.TicketClassID == seat.TicketClass.TicketClassID);

                            if (PlaneTicketClassDetail == null)
                            {
                                PlaneTicketClassDetail = new PlaneTicketClassDetailDTO
                                {
                                    PlaneID = planeID,
                                    TicketClass = seat.TicketClass,
                                    Quantity = 1
                                };

                                PlaneTicketClassDetails.Add(PlaneTicketClassDetail);
                            }
                            else
                                ++PlaneTicketClassDetail.Quantity;
                        }

                        return (PlaneTicketClassDetails, "Lấy danh sách chi tiết hạng vé máy bay thành công!");
                    }
                    else
                    {
                        return (null, label);
                    }
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }
    }

}
