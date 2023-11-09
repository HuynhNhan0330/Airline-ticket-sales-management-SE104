using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using System;
using System.Collections.Generic;
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
        public SettingUC()
        {
            InitializeComponent();
        }
        private void SettingUC_Load(object sender, EventArgs e)
        {
            loadRegulations();

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

            //for (int i = 0; i < 20; ++i)
            //{
            //    TicketClassItemUC uc = new TicketClassItemUC();
            //    pnListTicketClass.Controls.Add(uc);
            //    uc.BringToFront();
            //    uc.Dock = DockStyle.Top;

            //    Panel pn = new Panel();
            //    pnListTicketClass.Controls.Add(pn);
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
    }
}
