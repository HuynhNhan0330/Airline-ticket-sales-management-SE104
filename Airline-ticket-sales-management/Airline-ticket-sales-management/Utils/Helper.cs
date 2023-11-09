using Airline_ticket_sales_management.AControls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Utils
{
    public class Helper
    {
        public static string FormatVNMoney(decimal money)
        {
            if (money == 0)
            {
                return "0 ₫";
            }
            return String.Format(CultureInfo.InvariantCulture,
                                "{0:#,#} ₫", money);
        }

        public static string nextCode(string code, string key)
        {
            if (code is null)
                return key + "0001";

            string newCodeString = $"000{int.Parse(code.Substring(key.Length)) + 1}";
            return key + newCodeString.Substring(newCodeString.Length - 4, 4);
        }
    }
}
