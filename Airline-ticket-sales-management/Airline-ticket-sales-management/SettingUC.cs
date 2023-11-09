using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Usercontrols;
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
        private ObservableCollection<TicketClassDTO> _ticketClasses;
        public ObservableCollection<TicketClassDTO> ticketClasses
        {
            get { return _ticketClasses; }
            set { _ticketClasses = value; }
        }

        private TicketClassDTO ticketClass;

        public SettingUC()
        {
            InitializeComponent();
        }
        private void SettingUC_Load(object sender, EventArgs e)
        {
            loadRegulations();
            getDataTicketClass();
            pnOperationEditTicketClass.Visible = false;

            //for (int i = 0; i < 20; ++i)
            //{
            //    AirportItemUC uc = new AirportItemUC();
            //    pnListAirport.Controls.Add(uc);
            //    uc.BringToFront();
            //    uc.Dock = DockStyle.Top;

            //    Panel pn = new Panel();
            //    pnListAirport.Controls.Add(pn);
            //    pn.Height = 2;
            //    pn.BackColor = Color.Gray;
            //    pn.BringToFront();
            //    pn.Dock = DockStyle.Top;
            //}


        }

        private void loadRegulations()
        {
            atbMinimumFlightTime.Texts = RegulationsDTO.Ins.MinimumFlightTime.ToString();
            atbMaxDelayAirports.Texts = RegulationsDTO.Ins.MaxDelayAirports.ToString();
            atbMinimumDelayTime.Texts = RegulationsDTO.Ins.MinimumDelayTime.ToString();
            atbMaximumDelayTime.Texts = RegulationsDTO.Ins.MaximumDelayTime.ToString();
            atbLatestBookingTime.Texts = RegulationsDTO.Ins.LatestBookingTime.ToString();
            atbLatestCancellationTime.Texts = RegulationsDTO.Ins.LatestCancellationTime.ToString();
        }

        private async void abtnSaveRegulations_Click(object sender, EventArgs e)
        {
            (bool isSaveRegulations, string label) = await RegulationsDAL.Ins.updateRegulations(
                    int.Parse(atbMinimumFlightTime.Texts),
                    int.Parse(atbMaxDelayAirports.Texts),
                    int.Parse(atbMinimumDelayTime.Texts),
                    int.Parse(atbMaximumDelayTime.Texts),
                    int.Parse(atbLatestBookingTime.Texts),
                    int.Parse(atbLatestCancellationTime.Texts)
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
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu phần trăm đơn giá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                newTicketClass.TicketClassCode = newCode;
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
                        if ((tciuc as TicketClassItemUC).TicketClass.TicketClassCode == ticketClass.TicketClassCode)
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
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu phần trăm đơn giá", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                atxbPricePercentage.Focus();
                ms.ShowDialog();
            }
            else
            {
                TicketClassDTO currentTicket = new TicketClassDTO(atxbTicketClassName.Texts.Trim(), int.Parse(atxbPricePercentage.Texts.Trim()), this.ticketClass.TicketClassCode);
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
    }
}
