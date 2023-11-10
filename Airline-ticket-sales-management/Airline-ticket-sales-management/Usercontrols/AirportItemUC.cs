using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class AirportItemUC : UserControl
    {
        private AirportDTO _airport;
        public AirportDTO airport
        {
            get { return _airport; }
            set
            {
                _airport = value;

                this.airportName = airport.AirportName;
                this.cityName = airport.CityName;
                this.countryName = airport.CountryName;
            }
        }

        private string _airportName;
        public string airportName
        {
            get { return _airportName; }
            set
            {
                _airportName = value;

                lbAirportName.Text = airportName;
                lbAirportName.Left = (pnAirportName.Width - lbAirportName.Width) / 2;
                renderLabel(lbAirportName);
                renderOperation();
            }
        }

        private string _cityName;
        public string cityName
        {
            get { return _cityName; }
            set
            {
                _cityName = value;

                lbCityName.Text = cityName;
                lbCityName.Left = (pnCityName.Width - lbCityName.Width) / 2;
                renderLabel(lbCityName);
                renderOperation();
            }
        }

        private string _countryName;
        public string countryName
        {
            get { return _countryName; }
            set
            {
                _countryName = value;

                lbCountryName.Text = countryName;
                lbCountryName.Left = (pnCountryName.Width - lbCountryName.Width) / 2;
                renderLabel(lbCountryName);
                renderOperation();
            }
        }

        public AirportItemUC()
        {
            InitializeComponent();
        }

        private void renderOperation()
        {
            int topNew = (this.Height - this.pibEdit.Height) / 2;
            this.pibEdit.Top = topNew;
            this.pibDelete.Top = topNew;
        }

        private void renderLabel(Label lb)
        {
            this.Height = Math.Max(this.Height, lb.Height + lb.Top * 2);
            lb.Top = (this.Height - lb.Height) / 2;
        }

        private void pibDelete_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
            {
                Control ct = this.Parent;

                while (!(ct is SettingUC))
                    ct = ct.Parent;

                SettingUC settingUC = ct as SettingUC;
                settingUC.removeAirport(airport);
            }
        }

        private void pibEdit_Click(object sender, EventArgs e)
        {
            Control ct = this.Parent;

            while (!(ct is SettingUC))
                ct = ct.Parent;

            SettingUC settingUC = ct as SettingUC;

            settingUC.setTextboxAirport(airport);
        }
    }
}
