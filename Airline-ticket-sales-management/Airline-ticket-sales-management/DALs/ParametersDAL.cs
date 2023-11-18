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
    public class ParametersDAL
    {
        private static ParametersDAL _ins;
        public static ParametersDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ParametersDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        /// <summary>
        /// Lấy dữ liệu tham số
        /// </summary>
        /// <returns></returns>
        public async Task getParameters()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var _parameters = context.Parameters.FirstOrDefault();
                    ParametersDTO regulations = new ParametersDTO(_parameters.MinimumFlightTime, _parameters.MaxPreventiveAirports, _parameters.MinimumStopoverTime, _parameters.MaximumStopoverTime, _parameters.EarliestBookingTime, _parameters.LatestBookingCancellationTime);
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
        /// <param name="_maxPreventiveAirports"></param>
        /// <param name="_minimumStopoverTime"></param>
        /// <param name="_maximumStopoverTime"></param>
        /// <param name="_earliestBookingTime"></param>
        /// <param name="_latestBookingCancellationTime"></param>
        /// <returns>
        ///     - True nếu cập nhật thành công, false nếu ngược lại
        ///     - Văn bản về trạng thái hàm
        /// </returns>
        public async Task<(bool, string)> updateRegulations(int _mininumFlightTime, int _maxPreventiveAirports, int _minimumStopoverTime, int _maximumStopoverTime, int _earliestBookingTime, int _latestBookingCancellationTime)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var _parameters = context.Parameters.FirstOrDefault();
                    _parameters.MinimumFlightTime = _mininumFlightTime;
                    _parameters.MaxPreventiveAirports = _maxPreventiveAirports;
                    _parameters.MinimumStopoverTime = _minimumStopoverTime;
                    _parameters.MaximumStopoverTime = _maximumStopoverTime;
                    _parameters.EarliestBookingTime = _earliestBookingTime;
                    _parameters.LatestBookingCancellationTime = _latestBookingCancellationTime;

                    context.SaveChanges();
                }

                ParametersDTO regulations = new ParametersDTO(_mininumFlightTime, _maxPreventiveAirports, _minimumStopoverTime, _maximumStopoverTime, _earliestBookingTime, _latestBookingCancellationTime);

                return (true, "Lưu tham số thành công!");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}
