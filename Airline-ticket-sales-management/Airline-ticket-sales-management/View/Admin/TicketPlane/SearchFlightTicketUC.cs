using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
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
    public partial class SearchFlightTicketUC : UserControl
    {
        private ObservableCollection<TicketDTO> _ticketList;
        private ObservableCollection<TicketDTO> ticketList = new ObservableCollection<TicketDTO>();

        public SearchFlightTicketUC()
        {
            InitializeComponent();
        }

        private void SearchFlightTicketUC_Load(object sender, EventArgs e)
        {
            cbSearchType.SelectedIndex = 0;
            loadDataTicket();
        }

        private async void loadDataTicket()
        {
            (bool isGet, List<TicketDTO> listTicket, string label) = await TicketDAL.Ins.getListTicket();
            if (isGet)
            {
                _ticketList = new ObservableCollection<TicketDTO>(listTicket);
            }
        }

        private void loadPanelTicket()
        {
            pnListTicket.Controls.Clear();

            for (int i = 0; i < ticketList.Count; ++i)
            {
                TicketItemUC uc = new TicketItemUC();
                pnListTicket.Controls.Add(uc);
                uc.ticket = ticketList[i];
                uc.BringToFront();
                uc.Dock = DockStyle.Top;
            }
        }

        private void abtnSearch_Click(object sender, EventArgs e)
        {
            ticketList.Clear();

            foreach (TicketDTO ticket in _ticketList)
            {
                if (cbSearchType.SelectedIndex == 0 && ticket.TicketID.Contains(atxbKey.Texts))
                {
                    ticketList.Add(ticket);
                }
                else if (cbSearchType.SelectedIndex == 1 && ticket.FlightID.Contains(atxbKey.Texts))
                {
                    ticketList.Add(ticket);
                }
            }

            loadPanelTicket();
        }

        public void cancelTicket(TicketItemUC ticket)
        {
            pnListTicket.Controls.Remove(ticket);
        }
    }
}
