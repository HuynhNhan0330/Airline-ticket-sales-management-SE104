using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.DTOs
{
    public class RegulationsDTO
    {
        private static int _mininumFlightTime;
        public int MinimumFlightTime
        {
            get { return _mininumFlightTime; }
            set { _mininumFlightTime = value; }
        }
        
        private static int _maxDelayAirports;
        public int MaxDelayAirports
        {
            get { return _maxDelayAirports; }
            set { _maxDelayAirports = value; }
        }

        private static int _minimumDelayTime;
        public int MinimumDelayTime
        {
            get { return _minimumDelayTime; }
            set { _minimumDelayTime = value; }
        }

        private static int _maximumDelayTime;
        public int MaximumDelayTime
        {
            get { return _maximumDelayTime; }
            set { _maximumDelayTime = value; }
        }

        private static int _latestBookingTime;
        public int LatestBookingTime
        {
            get { return _latestBookingTime; }
            set { _latestBookingTime = value; }
        }

        private static int _latestCancellationTime;
        public int LatestCancellationTime
        {
            get { return _latestCancellationTime; }
            set { _latestCancellationTime = value; }
        }

        private static RegulationsDTO _ins;
        public static RegulationsDTO Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new RegulationsDTO();

                return _ins;
            }
            private set => _ins = value;
        }

        public RegulationsDTO() { }

        public RegulationsDTO(int _mininumFlightTime, int _maxDelayAirports, int _minimumDelayTime, int _maximumDelayTime, int _latestBookingTime, int _latestCancellationTime) 
        {
            MinimumFlightTime = _mininumFlightTime;
            MaxDelayAirports = _maxDelayAirports;
            MinimumDelayTime = _minimumDelayTime;
            MaximumDelayTime = _maximumDelayTime;
            LatestBookingTime = _latestBookingTime;
            LatestCancellationTime = _latestCancellationTime;
        }
    }
}
