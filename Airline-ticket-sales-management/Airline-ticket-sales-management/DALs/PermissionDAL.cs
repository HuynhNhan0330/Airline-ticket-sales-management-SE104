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
    public class PermissionDAL
    {
        private static PermissionDAL _ins;
        public static PermissionDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new PermissionDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, List<PermissionDTO>, string)> getListPermission()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var PermissiontList = (from pe in context.PERMISSIONs
                                           select new PermissionDTO
                                           {
                                               RoleID = pe.RoleID,
                                               RoleName = pe.RoleName,
                                               PermissionCode = pe.PermissionCode
                                           }).ToListAsync();

                    return (true, await PermissiontList, "Lấy danh sách quyền thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> updatePermission(List<PermissionDTO> permissions)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    foreach (PermissionDTO permission in permissions)
                    {
                        PERMISSION permissionUpdate = context.PERMISSIONs.FirstOrDefault(pe => pe.RoleID == permission.RoleID);
                        permissionUpdate.PermissionCode = permission.PermissionCode;
                    }

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
