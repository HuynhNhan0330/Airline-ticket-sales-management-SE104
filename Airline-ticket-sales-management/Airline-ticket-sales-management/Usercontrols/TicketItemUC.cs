using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
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
    public partial class TicketItemUC : UserControl
    {
        private TicketDTO _ticket;
        public TicketDTO ticket
        {
            get {  return _ticket; }
            set
            {
                _ticket = value;
                render();
            }
        }

        public TicketItemUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbTicketID.Text = ticket.TicketID;
            lbFlightID.Text = ticket.FlightID;
            lbName.Text = ticket.FullName;
            lbCardID.Text = ticket.IDCard;
            lbPhone.Text = ticket.PhoneNumber;
            lbEmail.Text = ticket.Email;
            lbSeat.Text = ticket.SeatID;
            lbClassTicketName.Text = ticket.TicketClassName;
            lbPrice.Text = Helper.FormatVNMoney(ticket.Price);

            lbTicketID.Left = (pnTicketID.Width - lbTicketID.Width) / 2;
            lbFlightID.Left = (pnFlightID.Width - lbFlightID.Width) / 2;
            lbName.Left = (pnName.Width - lbName.Width) / 2;
            lbCardID.Left = (pnCardID.Width - lbCardID.Width) / 2;
            lbPhone.Left = (pnPhone.Width - lbPhone.Width) / 2;
            lbEmail.Left = (pnEmail.Width - lbEmail.Width) / 2;
            lbSeat.Left = (pnSeat.Width - lbSeat.Width) / 2;
            lbClassTicketName.Left = (pnClassTicketName.Width - lbClassTicketName.Width) / 2;
            lbPrice.Left = (pnPrice.Width - lbPrice.Width) / 2;

            this.Height = lbTicketID.Height + 15 * 2 + pnLine.Height;
            this.Height = Math.Max(this.Height, lbFlightID.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbName.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbCardID.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbPhone.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbEmail.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbSeat.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbClassTicketName.Height + 15 * 2 + pnLine.Height);
            this.Height = Math.Max(this.Height, lbPrice.Height + 15 * 2 + pnLine.Height);

            lbTicketID.Top = (this.Height - pnLine.Height - lbTicketID.Height) / 2;
            lbFlightID.Top = (this.Height - pnLine.Height - lbFlightID.Height) / 2;
            lbName.Top = (this.Height - pnLine.Height - lbName.Height) / 2;
            lbCardID.Top = (this.Height - pnLine.Height - lbCardID.Height) / 2;
            lbPhone.Top = (this.Height - pnLine.Height - lbPhone.Height) / 2;
            lbEmail.Top = (this.Height - pnLine.Height - lbEmail.Height) / 2;
            lbSeat.Top = (this.Height - pnLine.Height - lbSeat.Height) / 2;
            lbClassTicketName.Top = (this.Height - pnLine.Height - lbClassTicketName.Height) / 2;
            lbPrice.Top = (this.Height - pnLine.Height - lbPrice.Height) / 2;
            pibCancel.Top = (this.Height - pnLine.Height - pibCancel.Height) / 2;
        }

        private void pibCancel_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận huỷ vé", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
            {
                if (DateTime.Now.AddDays(ParametersDTO.Ins.LatestBookingCancellationTime) <= ticket.DepartureDateTime)
                {
                    cancelTicket();
                }
                else
                {
                    AMessageBoxFrm ms1 = new AMessageBoxFrm("Hiện tại đã trễ để huỷ vé chuyến bay này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms1.ShowDialog();
                }
            }
        }

        private async void cancelTicket()
        {
            (bool isCancel, string label) = await TicketDAL.Ins.cancelTicket(ticket);

            if (isCancel)
            {
                Control ctr = this;

                while (!(ctr is SearchFlightTicketUC))
                    ctr = ctr.Parent;

                SearchFlightTicketUC uc = ctr as SearchFlightTicketUC;
                uc.cancelTicket(this);

                FlightTicketClassDetailDAL.Ins.updateFlightTicketClassDetail(ticket.FlightID, ticket.TicketClassID, 1);

                AMessageBoxFrm ms = new AMessageBoxFrm("Huỷ vé thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
