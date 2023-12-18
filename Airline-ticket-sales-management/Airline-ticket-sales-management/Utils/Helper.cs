using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public static void enterOnlyNumber(EventArgs e1)
        {
            KeyEventArgs e = e1 as KeyEventArgs;

            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) &&
               !(e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) &&
               e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                // Không phải phím số hoặc phím xóa
                // Hủy bỏ sự kiện KeyDown
                e.SuppressKeyPress = true;
            }
        }
        
        public static void enterOnlyLetter(EventArgs e1)
        {
            KeyEventArgs e = e1 as KeyEventArgs;

            if (!((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || e.KeyCode == Keys.Space ||
            Regex.IsMatch(e.KeyCode.ToString(), @"^[a-zA-ZÀ-ỹà-ỹ\s]+$"))
            && e.KeyCode != Keys.Back && e.KeyCode != Keys.Delete)
            {
                // Không phải chữ cái bình thường hoặc khoảng trắng
                // Hủy bỏ sự kiện KeyDown
                e.SuppressKeyPress = true;
            }
        }

        public static void enterNotSpecialCharacters(EventArgs e1)
        {
            
        }

        public static bool checkPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^0\d{9}$");
        }
        
        public static bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^([\w\.-]+)@([\w-]+)((\.(\w){2,3})+)$");
        }

        public static bool checkCardID(string cardID)
        {
            return Regex.IsMatch(cardID, @"^\d{9}$|^\d{12}$");
        }

        public static AccountDTO getAccountAdmin()
        {
            FormAdminHome form = Application.OpenForms.OfType<FormAdminHome>().FirstOrDefault();
            return form.account;
        }
    }
}
