using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management.Service
{
    public class FlightService
    {
        private static FlightService _ins;
        public static FlightService Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new FlightService();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(bool, int, string, string)> createFlight(FlightDTO flight)
        {
            (AirportDTO departureAirportFind, string label1) = await AirportDAL.Ins.findAirport(flight.DepartureAirportName);
            if (departureAirportFind == null)
                return (false, 0, label1, null);

            (AirportDTO arrivalAirportFind, string label2) = await AirportDAL.Ins.findAirport(flight.ArrivalAirportName);
            if (arrivalAirportFind == null)
                return (false, 1, label2, null);

            (PlaneDTO plane, string label3) = await PlaneDAL.Ins.findPlane(flight.PlaneID);
            if (plane == null)
                return (false, 2, label3, null);

            flight.DepartureAirportCode = departureAirportFind.AirportID;
            flight.ArrivalAirportCode = arrivalAirportFind.AirportID;

            (bool isCreateFlight, string label, string newID) = await FlightDAL.Ins.createFlight(flight);

            if (isCreateFlight)
                return (true, -1, label, newID);
            else
                return (false, -1, label, null);
        }

        public async Task<(bool, string)> deleteFlight(string flightID)
        {
            (bool isDeleteFlightTicketClassDetail, string label) = await FlightTicketClassDetailDAL.Ins.deleteFlightTicketClassDetail(flightID);
            if (isDeleteFlightTicketClassDetail)
            {
                (bool isDeleteFlightDetail, string label1) = await PreventiveAirportDAL.Ins.deletePreventiveAirport(flightID);
                if (isDeleteFlightDetail)
                {
                    (bool isDeleteFlight, string label2) = await FlightDAL.Ins.deleteFlight(flightID);
                    return (isDeleteFlight, label2);
                }
                else
                    return (isDeleteFlightDetail, label1);
            }
            else
                return (isDeleteFlightTicketClassDetail, label);
        }

        public async Task<(bool, int, string)> updateFlight(FlightDTO flight, List<PreventiveAirportDTO> preventiveAirport)
        {
            (AirportDTO departureAirportFind, string label1) = await AirportDAL.Ins.findAirport(flight.DepartureAirportName);
            if (departureAirportFind == null)
                return (false, 0, label1);

            (AirportDTO arrivalAirportFind, string label2) = await AirportDAL.Ins.findAirport(flight.ArrivalAirportName);
            if (arrivalAirportFind == null)
                return (false, 1, label2);

            (PlaneDTO plane, string label3) = await PlaneDAL.Ins.findPlane(flight.PlaneID);
            if (plane == null)
                return (false, 2, label3);

            flight.DepartureAirportCode = departureAirportFind.AirportID;
            flight.ArrivalAirportCode = arrivalAirportFind.AirportID;

            (bool isCreateFlight, string label) = await FlightDAL.Ins.updateFlight(flight);

            if (isCreateFlight)
            {
                (bool isDeletePreventiveAirport, string label4) = await PreventiveAirportDAL.Ins.deletePreventiveAirport(flight.FlightID);
                (bool isDeleteFlightTicketClassDetail, string label5) = await FlightTicketClassDetailDAL.Ins.deleteFlightTicketClassDetail(flight.FlightID);

                if (isDeletePreventiveAirport && isDeleteFlightTicketClassDetail)
                {
                    (bool isCreatePreventiveAirport, string label6) = await PreventiveAirportDAL.Ins.createFlightDetail(preventiveAirport, flight.FlightID);
                    (bool isCreateFlightTicketClassDetail, string label7) = await FlightTicketClassDetailDAL.Ins.createFlgihtTicketClassDetail(flight);

                    if (isCreatePreventiveAirport && isCreateFlightTicketClassDetail)
                        return (true, -1, label);

                    return (false, -1, label);
                }

                return (false, -1, label);
            }
            else
                return (false, -1, label);
        }
    }
}
