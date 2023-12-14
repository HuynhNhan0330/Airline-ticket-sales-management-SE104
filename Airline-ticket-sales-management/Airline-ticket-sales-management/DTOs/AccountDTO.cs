using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.DTOs
{
    public class AccountDTO
    {
        public string AccountID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public string RoleID { get; set; }
        public string PermissionCode { get; set; }
        public string RoleName { get; set; }
    }
}
