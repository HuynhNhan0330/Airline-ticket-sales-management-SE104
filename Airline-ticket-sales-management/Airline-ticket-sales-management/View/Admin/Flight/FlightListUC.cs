using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Usercontrols;

namespace Airline_ticket_sales_management
{
    public partial class FlightListUC : UserControl
    {
        private ObservableCollection<FlightDTO> _flights;
        private ObservableCollection<FlightDTO> flights;

        public FlightListUC()
        {
            InitializeComponent();
        }

        private async void loadDataFlight()
        {
            (bool isGetFlights, List<FlightDTO> flights, string label) = await FlightDAL.Ins.getListFlight();

            if (isGetFlights)
            {
                _flights = new ObservableCollection<FlightDTO>(flights);
                this.flights = new ObservableCollection<FlightDTO>(flights);
                //loadListFlight();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void loadListFlight()
        {
            foreach (FlightDTO flight in flights)
            {
                FlightItemUC uc = new FlightItemUC();
                uc.flight = flight;
                pnFlightList.Controls.Add(uc);
                uc.BringToFront();
                uc.Dock = DockStyle.Top;

                Panel pn = new Panel();
                pnFlightList.Controls.Add(pn);
                pn.Height = 2;
                pn.BackColor = Color.Gray;
                pn.BringToFront();
                pn.Dock = DockStyle.Top;
            }
        }

        private async void loadAirport()
        {
            (bool isGet, List<AirportDTO> airport, string label) = await AirportDAL.Ins.getListAirport();
            
            cbDepatureAirport.DisplayMember = "CityName";
            cbDepatureAirport.DataSource = new List<AirportDTO>(airport);

            cbArrivalAirport.DisplayMember = "CityName";
            cbArrivalAirport.DataSource = new List<AirportDTO>(airport);
        }

        private void FlightListUC_Load(object sender, EventArgs e)
        {
            loadAirport();
            loadDataFlight();
        }

        public void deleteFlightItem(Control uc)
        {
            int indexRemove = pnFlightList.Controls.IndexOf(uc);

            pnFlightList.Controls.RemoveAt(indexRemove);
            pnFlightList.Controls.RemoveAt(indexRemove - 1);
        }

        private void abtnSearchFlight_Click(object sender, EventArgs e)
        {
            if (cbDepatureAirport.Text == cbArrivalAirport.Text)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Thông tin nơi đi và nơi đến không được trùng nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                pnFlightList.Controls.Clear();
                flights.Clear();

                foreach (FlightDTO flight in _flights)
                {
                    if (flight.DepartureCityName == cbDepatureAirport.Text && flight.ArrivalCityName == cbArrivalAirport.Text && flight.DepartureDateTime.Date == adtpTime.Value.Date)
                        flights.Add(flight);
                }

                loadListFlight();
            }
        }
    }
}
