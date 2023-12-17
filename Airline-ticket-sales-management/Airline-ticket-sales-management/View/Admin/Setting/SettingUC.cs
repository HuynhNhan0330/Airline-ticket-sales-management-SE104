using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class SettingUC : UserControl
    {
        #region properties
        private ObservableCollection<TicketClassDTO> _ticketClasses;
        public ObservableCollection<TicketClassDTO> ticketClasses
        {
            get { return _ticketClasses; }
            set { _ticketClasses = value; }
        }

        private ObservableCollection<AirportDTO> _airports;
        public ObservableCollection<AirportDTO> airports
        {
            get { return _airports; }
            set { _airports = value; }
        }

        private TicketClassDTO ticketClass;
        private AirportDTO airport;
        #endregion

        public SettingUC()
        {
            InitializeComponent();
        }
        private void SettingUC_Load(object sender, EventArgs e)
        {
            loadRegulations();
            getDataAirport();
            getDataTicketClass();
            pnOperationEditTicketClass.Visible = false;
            pnOperationEditAirport.Visible = false;
        }

        #region regulations
        private void loadRegulations()
        {
            atbMinimumFlightTime.Texts = ParametersDTO.Ins.MinimumFlightTime.ToString();
            atbMaxPreventiveAirports.Texts = ParametersDTO.Ins.MaxPreventiveAirports.ToString();
            atbMinimumStopoverTime.Texts = ParametersDTO.Ins.MinimumStopoverTime.ToString();
            atbMaximumStopoverTime.Texts = ParametersDTO.Ins.MaximumStopoverTime.ToString();
            atbEarliestBookingTime.Texts = ParametersDTO.Ins.EarliestBookingTime.ToString();
            atbLatestBookingCancellationTime.Texts = ParametersDTO.Ins.LatestBookingCancellationTime.ToString();
        }

        private async void abtnSaveRegulations_Click(object sender, EventArgs e)
        {
            (bool isSaveRegulations, string label) = await ParametersDAL.Ins.updateRegulations(
                    int.Parse(atbMinimumFlightTime.Texts),
                    int.Parse(atbMaxPreventiveAirports.Texts),
                    int.Parse(atbMinimumStopoverTime.Texts),
                    int.Parse(atbMaximumStopoverTime.Texts),
                    int.Parse(atbEarliestBookingTime.Texts),
                    int.Parse(atbLatestBookingCancellationTime.Texts)
                );

            if (isSaveRegulations)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
        #endregion

        #region Ticketclass
        private async void getDataTicketClass()
        {
            (bool isGetDataTicketClass, List<TicketClassDTO> ticketClassList, string label) = await TicketClassDAL.Ins.getListTicketClass();

            if (isGetDataTicketClass)
            {
                ticketClasses = new ObservableCollection<TicketClassDTO>(ticketClassList);

                foreach (TicketClassDTO ticketClass in ticketClasses)
                    addTicketClassItem(ticketClass);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void addTicketClassItem(TicketClassDTO ticketClass)
        {
            TicketClassItemUC uc = new TicketClassItemUC();
            uc.TicketClass = ticketClass;
            pnListTicketClass.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Top;

            Panel pn = new Panel();
            pnListTicketClass.Controls.Add(pn);
            pn.Height = 2;
            pn.BackColor = Color.Gray;
            pn.BringToFront();
            pn.Dock = DockStyle.Top;
        }

        private void abtnCreateTicketClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbTicketClassName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên hạng vé bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbTicketClassName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPricePercentage.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu phần trăm đơn giá bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbPricePercentage.Focus();
                ms.ShowDialog();
            }
            else 
                 _ = CreateTicketClassAsync();
        }

        private async Task CreateTicketClassAsync()
        {
            TicketClassDTO newTicketClass = new TicketClassDTO(atxbTicketClassName.Texts.Trim(), int.Parse(atxbPricePercentage.Texts.Trim()));

            (bool isCreateTicket, string label, string newCode) = await TicketClassDAL.Ins.createTicketClass(newTicketClass);

            if (isCreateTicket)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                newTicketClass.TicketClassID = newCode;
                addTicketClassItem(newTicketClass);

                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void setTextboxTicketClass(TicketClassDTO ticketClass)
        {
            this.ticketClass = ticketClass;
            atxbTicketClassName.Texts = ticketClass.TicketClassName;
            atxbTicketClassName.isPlaceholder = false;
            atxbTicketClassName.setForeColor();
            atxbPricePercentage.Texts = ticketClass.PricePercentage.ToString();
            atxbPricePercentage.isPlaceholder = false;
            atxbPricePercentage.setForeColor();

            abtnCreateTicketClass.Visible = false;
            pnOperationEditTicketClass.Visible = true;
            
        }

        public async void removeTicketClassItem(TicketClassDTO ticketClass)
        {
            (bool isRemoveTicketClass, string label) = await TicketClassDAL.Ins.deleteTicketClass(ticketClass);

            if (isRemoveTicketClass)
            {
                if (this.ticketClass == ticketClass)
                    abtnCancelTicketClass_Click(abtnCancelTicketClass, EventArgs.Empty);

                int indexDelete = -1;

                for (int index = 0; index < pnListTicketClass.Controls.Count; ++index)
                {
                    Control tciuc = pnListTicketClass.Controls[index];

                    if (tciuc is TicketClassItemUC)
                    {
                        if ((tciuc as TicketClassItemUC).TicketClass == ticketClass)
                            indexDelete = index;
                    }
                }

                if (indexDelete != -1)
                {
                    pnListTicketClass.Controls.RemoveAt(indexDelete);
                    pnListTicketClass.Controls.RemoveAt(indexDelete - 1);
                }

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public async void updateTicketClassItem(TicketClassDTO ticketClass)
        {
            (bool isUpdateTicketClass, string label) = await TicketClassDAL.Ins.updateTicketClass(ticketClass);

            if (isUpdateTicketClass)
            {
                TicketClassItemUC tcuc = null;

                foreach (Control tciuc in pnListTicketClass.Controls)
                {
                    if (tciuc is TicketClassItemUC)
                    {
                        if ((tciuc as TicketClassItemUC).TicketClass.TicketClassID == ticketClass.TicketClassID)
                            tcuc = tciuc as TicketClassItemUC;
                    }

                    if (tcuc != null)
                        tcuc.TicketClass = ticketClass;
                }

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnUpdateTicketClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbTicketClassName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên hạng vé bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbTicketClassName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPricePercentage.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu phần trăm đơn giá bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbPricePercentage.Focus();
                ms.ShowDialog();
            }
            else
            {
                TicketClassDTO currentTicket = new TicketClassDTO(atxbTicketClassName.Texts.Trim(), int.Parse(atxbPricePercentage.Texts.Trim()), this.ticketClass.TicketClassID);
                updateTicketClassItem(currentTicket);
            }
        }

        private void abtnCancelTicketClass_Click(object sender, EventArgs e)
        {
            atxbTicketClassName.Texts = "";
            atxbPricePercentage.Texts = "";

            abtnCreateTicketClass.Visible = true;
            pnOperationEditTicketClass.Visible = false;
        }
        #endregion

        #region Airport
        private void abtnCreateAirport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbAirportName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên sân bay vé bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbAirportName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbCityName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên thành phố bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbCityName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbCountryName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên đất nước bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbCountryName.Focus();
                ms.ShowDialog();
            }
            else
            {
                AirportDTO newAirport = new AirportDTO(atxbAirportName.Texts.Trim(), atxbCityName.Texts.Trim(), atxbCountryName.Texts.Trim());
                _ = createAirportAsync(newAirport);
            }
        }

        private async Task createAirportAsync(AirportDTO airport)
        {
            (bool isCreateAirport, string label, string newCode) = await AirportDAL.Ins.createAirport(airport);

            if (isCreateAirport)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                airport.AirportID = newCode;
                addAirportItem(airport);

                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void addAirportItem(AirportDTO airport)
        {
            AirportItemUC uc = new AirportItemUC();
            uc.airport = airport;
            pnListAirport.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Top;

            Panel pn = new Panel();
            pnListAirport.Controls.Add(pn);
            pn.Height = 2;
            pn.BackColor = Color.Gray;
            pn.BringToFront();
            pn.Dock = DockStyle.Top;
        }

        private async void getDataAirport()
        {
            (bool isGetDataAirport, List<AirportDTO> airportList, string label) = await AirportDAL.Ins.getListAirport();

            if (isGetDataAirport)
            {
                this.airports = new ObservableCollection<AirportDTO>(airportList);

                foreach (AirportDTO airport in this.airports)
                    addAirportItem(airport);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public void setTextboxAirport(AirportDTO airport)
        {
            this.airport = airport;
            atxbAirportName.Texts = airport.AirportName;
            atxbAirportName.isPlaceholder = false;
            atxbAirportName.setForeColor();

            atxbCityName.Texts = airport.CityName;
            atxbCityName.isPlaceholder = false;
            atxbCityName.setForeColor();

            atxbCountryName.Texts = airport.CountryName;
            atxbCountryName.isPlaceholder = false;
            atxbCountryName.setForeColor();

            abtnCreateAirport.Visible = false;
            pnOperationEditAirport.Visible = true;
        }

        public async void removeAirport(AirportDTO airport)
        {
            (bool isRemoveAirport, string label) = await AirportDAL.Ins.deleteAirport(airport);

            if (isRemoveAirport)
            {
                if (this.airport == airport)
                    abtnCancelAirport_Click(abtnCancelAirport, EventArgs.Empty);

                int indexDelete = -1;

                for (int index = 0; index < pnListAirport.Controls.Count; ++index)
                {
                    Control apiuc = pnListAirport.Controls[index];

                    if (apiuc is AirportItemUC)
                    {
                        if ((apiuc as AirportItemUC).airport == airport)
                            indexDelete = index;
                    }
                }

                if (indexDelete != -1)
                {
                    pnListAirport.Controls.RemoveAt(indexDelete);
                    pnListAirport.Controls.RemoveAt(indexDelete - 1);
                }

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        public async void updateAirport(AirportDTO airport)
        {
            (bool isUpdateAirport, string label) = await AirportDAL.Ins.updateAirport(airport);

            if (isUpdateAirport)
            {
                AirportItemUC apuc= null;

                foreach (Control apiuc in pnListAirport.Controls)
                {
                    if (apiuc is AirportItemUC)
                    {
                        if ((apiuc as AirportItemUC).airport.AirportID == airport.AirportID)
                            apuc = apiuc as AirportItemUC;
                    }

                    if (apuc != null)
                        apuc.airport = airport;
                }

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnUpdateAirport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbAirportName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên sân bay vé bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbAirportName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbCityName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên thành phố bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbCityName.Focus();
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbCountryName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu tên đất nước bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbCountryName.Focus();
                ms.ShowDialog();
            }
            else
            {
                AirportDTO newAirport = new AirportDTO(atxbAirportName.Texts.Trim(), atxbCityName.Texts.Trim(), atxbCountryName.Texts.Trim(), this.airport.AirportID);
                updateAirport(newAirport);
            }
        }

        private void abtnCancelAirport_Click(object sender, EventArgs e)
        {
            atxbAirportName.Texts = "";
            atxbCityName.Texts = "";
            atxbCountryName.Texts = "";

            abtnCreateAirport.Visible = true;
            pnOperationEditAirport.Visible = false;
        }
        #endregion

        private void KeyDownOnlyNumber(object sender, EventArgs e)
        {
            Helper.enterOnlyNumber(e);
        }

        private void KeyDownOnlyLetter(object sender, EventArgs e)
        {
            Helper.enterOnlyLetter(e);
        }
    }
}
