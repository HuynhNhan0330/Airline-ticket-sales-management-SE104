using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
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

namespace Airline_ticket_sales_management
{
    public partial class CreateFlightTicketUC : UserControl
    {
        private ObservableCollection<TicketClassDTO> ticketClasses;

        public CreateFlightTicketUC()
        {
            InitializeComponent();
        }

        private void CreateFlightTicketUC_Load(object sender, EventArgs e)
        {
            loadTicketClass();
        }

        private async void loadTicketClass()
        {
            (bool isGetList, List<TicketClassDTO> listTicketClass, string lb) = await TicketClassDAL.Ins.getListTicketClass();

            if (isGetList)
            {
                ticketClasses = new ObservableCollection<TicketClassDTO>(listTicketClass);

                for (int index = 0; index < ticketClasses.Count; ++index)
                    addTicketClassItem(ticketClasses[index], index % ColorCodes.ColorList.Count);
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(lb, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void addTicketClassItem(TicketClassDTO ticketClass, int colorPosition)
        {
            PlaneTicketClassItemUC uc = new PlaneTicketClassItemUC();
            uc.TicketClass = ticketClass;
            ticketClass.ColorTicketClass = ColorTranslator.FromHtml(ColorCodes.ColorList[colorPosition]);
            uc._BackgroundColor = ticketClass.ColorTicketClass;
            pnTicketClass.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Top;

            Panel pn = new Panel();
            pnTicketClass.Controls.Add(pn);
            pn.Height = 2;
            pn.BackColor = Color.Transparent;
            pn.BringToFront();
            pn.Dock = DockStyle.Top;
        }

    }
}
