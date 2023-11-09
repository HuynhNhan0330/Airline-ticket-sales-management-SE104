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
                    var TicketClassList = (from ticketclass in context.TICKETCLASSes
                                           select new TicketClassDTO
                                           {
                                               TicketClassCode = ticketclass.TicketClassCode,
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
                    TICKETCLASS findTicketClass = context.TICKETCLASSes.FirstOrDefault(tc => tc.TicketClassName == _ticketClass.TicketClassName);
                    if (findTicketClass != null)
                        return (false, "Tên hạng vé đã tồn tại", null);

                    string currentMaxCode = await context.TICKETCLASSes.MaxAsync(tc => tc.TicketClassCode);
                    string newCode = Helper.nextCode(currentMaxCode, "TC");

                    TICKETCLASS newTicketClass = new TICKETCLASS
                    {
                        TicketClassCode = newCode,
                        TicketClassName = _ticketClass.TicketClassName,
                        PricePercentage = _ticketClass.PricePercentage
                    };

                    context.TICKETCLASSes.Add(newTicketClass);

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
                    TICKETCLASS ticketClass = context.TICKETCLASSes.FirstOrDefault(tc => tc.TicketClassCode == _ticketClass.TicketClassCode);

                    context.TICKETCLASSes.Remove(ticketClass);
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
                    TICKETCLASS findTicketClass = context.TICKETCLASSes.FirstOrDefault(tc => tc.TicketClassName == _ticketClass.TicketClassName && tc.TicketClassCode != _ticketClass.TicketClassCode);
                    if (findTicketClass != null)
                        return (false, "Tên hạng vé đã tồn tại");

                    TICKETCLASS currentTicketClass = context.TICKETCLASSes.FirstOrDefault(tc => tc.TicketClassCode == _ticketClass.TicketClassCode);
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
    }
}
