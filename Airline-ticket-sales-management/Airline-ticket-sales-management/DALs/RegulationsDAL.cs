using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.DALs
{
    public class RegulationsDAL
    {
        private static RegulationsDAL _ins;
        public static RegulationsDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new RegulationsDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        /// <summary>
        /// Lấy dữ liệu tham số
        /// </summary>
        /// <returns></returns>
        public async Task getRegulations()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var _regulations = context.REGULATIONS.FirstOrDefault();
                    RegulationsDTO regulations = new RegulationsDTO(_regulations.MinimumFlightTime, _regulations.MaxDelayAirports, _regulations.MinimumDelayTime, _regulations.MaximumDelayTime, _regulations.LatestBookingTime, _regulations.LatestCancellationTime);
                }
            }
            catch (Exception ex)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        /// <summary>
        /// Cập nhật lại dữ liệu tham số
        /// </summary>
        /// <param name="_mininumFlightTime"></param>
        /// <param name="_maxDelayAirports"></param>
        /// <param name="_minimumDelayTime"></param>
        /// <param name="_maximumDelayTime"></param>
        /// <param name="_latestBookingTime"></param>
        /// <param name="_latestCancellationTime"></param>
        /// <returns>
        ///     - True nếu cập nhật thành công, false nếu ngược lại
        ///     - Văn bản về trạng thái hàm
        /// </returns>
        public async Task<(bool, string)> updateRegulations(int _mininumFlightTime, int _maxDelayAirports, int _minimumDelayTime, int _maximumDelayTime, int _latestBookingTime, int _latestCancellationTime)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var _regulations = context.REGULATIONS.FirstOrDefault();
                    _regulations.MinimumFlightTime = _mininumFlightTime;
                    _regulations.MaxDelayAirports = _maxDelayAirports;
                    _regulations.MinimumDelayTime = _minimumDelayTime;
                    _regulations.MaximumDelayTime = _maximumDelayTime;
                    _regulations.LatestBookingTime = _latestBookingTime;
                    _regulations.LatestCancellationTime = _latestCancellationTime;

                    context.SaveChanges();
                }

                RegulationsDTO regulations = new RegulationsDTO(_mininumFlightTime, _maxDelayAirports, _minimumDelayTime, _maximumDelayTime, _latestBookingTime, _latestCancellationTime);

                return (true, "Lưu tham số thành công!");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
