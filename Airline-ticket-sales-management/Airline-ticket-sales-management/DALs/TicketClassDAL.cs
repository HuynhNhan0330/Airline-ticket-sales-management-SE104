using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Airline_ticket_sales_management.DALs
{
    public class TicketClassDAL
    {
        private static TicketClassDAL _ins;
        public static TicketClassDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new TicketClassDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, List<TicketClassDTO>, string)> getListTicketClass()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var TicketClassList = (from ticketclass in context.TICKET_CLASS
                                           select new TicketClassDTO
                                           {
                                               TicketClassID = ticketclass.TicketClassID,
                                               TicketClassName = ticketclass.TicketClassName,
                                               PricePercentage = (int)ticketclass.PricePercentage
                                           }).ToListAsync();
                
                    return (true, await TicketClassList, "Lấy danh sách hạng vé thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string, string)> createTicketClass(TicketClassDTO _ticketClass)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    TICKET_CLASS findTicketClass = context.TICKET_CLASS.FirstOrDefault(tc => tc.TicketClassName == _ticketClass.TicketClassName);
                    if (findTicketClass != null)
                        return (false, "Tên hạng vé đã tồn tại", null);

                    string currentMaxCode = await context.TICKET_CLASS.MaxAsync(tc => tc.TicketClassID);
                    string newCode = Helper.nextCode(currentMaxCode, "TC");

                    TICKET_CLASS newTicketClass = new TICKET_CLASS
                    {
                        TicketClassID = newCode,
                        TicketClassName = _ticketClass.TicketClassName,
                        PricePercentage = _ticketClass.PricePercentage
                    };

                    context.TICKET_CLASS.Add(newTicketClass);

                    context.SaveChanges();

                    return (true, "Tạo hạng vé thành công!", newCode);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool, string)> deleteTicketClass(TicketClassDTO _ticketClass)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    TICKET_CLASS ticketClass = context.TICKET_CLASS.FirstOrDefault(tc => tc.TicketClassID == _ticketClass.TicketClassID);

                    context.TICKET_CLASS.Remove(ticketClass);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> updateTicketClass(TicketClassDTO _ticketClass)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    TICKET_CLASS findTicketClass = context.TICKET_CLASS.FirstOrDefault(tc => tc.TicketClassName == _ticketClass.TicketClassName && tc.TicketClassID != _ticketClass.TicketClassID);
                    if (findTicketClass != null)
                        return (false, "Tên hạng vé đã tồn tại");

                    TICKET_CLASS currentTicketClass = context.TICKET_CLASS.FirstOrDefault(tc => tc.TicketClassID == _ticketClass.TicketClassID);
                    currentTicketClass.TicketClassName = _ticketClass.TicketClassName;
                    currentTicketClass.PricePercentage = _ticketClass.PricePercentage;

                    context.SaveChanges();

                    return (true, "Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<TicketClassDTO> getFirst()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    TICKET_CLASS findTicketClass = context.TICKET_CLASS.FirstOrDefault();

                    TicketClassDTO ticketClass = new TicketClassDTO(findTicketClass.TicketClassName, findTicketClass.PricePercentage, findTicketClass.TicketClassID);

                    return ticketClass;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
