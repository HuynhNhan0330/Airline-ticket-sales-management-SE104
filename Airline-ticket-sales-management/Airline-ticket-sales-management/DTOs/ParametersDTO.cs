using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class ParametersDTO
    {
        private static int _mininumFlightTime;
        public int MinimumFlightTime
        {
            get { return _mininumFlightTime; }
            set { _mininumFlightTime = value; }
        }
        
        private static int _maxPreventiveAirports;
        public int MaxPreventiveAirports
        {
            get { return _maxPreventiveAirports; }
            set { _maxPreventiveAirports = value; }
        }

        private static int _minimumStopoverTime;
        public int MinimumStopoverTime
        {
            get { return _minimumStopoverTime; }
            set { _minimumStopoverTime = value; }
        }

        private static int _maximumStopoverTime;
        public int MaximumStopoverTime
        {
            get { return _maximumStopoverTime; }
            set { _maximumStopoverTime = value; }
        }

        private static int _earliestBookingTime;
        public int EarliestBookingTime
        {
            get { return _earliestBookingTime; }
            set { _earliestBookingTime = value; }
        }

        private static int _latestBookingCancellationTime;
        public int LatestBookingCancellationTime
        {
            get { return _latestBookingCancellationTime; }
            set { _latestBookingCancellationTime = value; }
        }

        private static ParametersDTO _ins;
        public static ParametersDTO Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new ParametersDTO();

                return _ins;
            }
            private set => _ins = value;
        }

        public ParametersDTO() { }

        public ParametersDTO(int _mininumFlightTime, int _maxPreventiveAirports, int _minimumStopoverTime, int _maximumStopoverTime, int _earliestBookingTime, int _latestBookingCancellationTime) 
        {
            MinimumFlightTime = _mininumFlightTime;
            MaxPreventiveAirports = _maxPreventiveAirports;
            MinimumStopoverTime = _minimumStopoverTime;
            MaximumStopoverTime = _maximumStopoverTime;
            EarliestBookingTime = _earliestBookingTime;
            LatestBookingCancellationTime = _latestBookingCancellationTime;
        }
    }
}
