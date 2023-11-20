using Airline_ticket_sales_management.DTOs;
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
    public partial class PlaneTicketClassItemUC : UserControl
    {
        private readonly int tbLabel = 15;
        private readonly int lrLabel = 10;
        private readonly int sizeScroll = 10;

        private TicketClassDTO _ticketClass;
        public TicketClassDTO TicketClass
        {
            get { return _ticketClass; }
            set
            {
                _ticketClass = value;
                NameTicketClass = TicketClass.TicketClassName;
            }
        }

        private string _nameTicketClass;
        public string NameTicketClass
        {
            get { return _nameTicketClass; }
            set
            {
                _nameTicketClass = value;
                lbText.MaximumSize = new Size(Width - lrLabel * 2 - sizeScroll, 0);
                lbText.Left = (this.Width - sizeScroll - lbText.Width) / 2;
                lbText.Top = tbLabel;
                lbText.Text = NameTicketClass;
                this.Height = lbText.Height + tbLabel * 2;
            }
        }

        private Color _backgroundColor;
        public Color _BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                TicketClass.ColorTicketClass = _BackgroundColor;
                this.BackColor = _BackgroundColor;
            }
        }

        public PlaneTicketClassItemUC()
        {
            InitializeComponent();
        }

        private void PlaneTicketClassItemUC_Load(object sender, EventArgs e)
        {
            loadEventClick(PlaneTicketClassItemUC_Click);
        }

        private void PlaneTicketClassItemUC_Click(object sender, EventArgs e)
        {
            Control ctrParent = this.Parent;
            while (!(ctrParent is OperationPlaneUC))
                ctrParent = ctrParent.Parent;

            OperationPlaneUC ctrOperationPlaneUC = ctrParent as OperationPlaneUC;
            ctrOperationPlaneUC.SelectedTicketClass = this.TicketClass;
        }

        private void loadEventClick(EventHandler evh)
        {
            foreach (Control ctrControl in this.Controls)
            {
                ctrControl.Click += evh;
            }
        }
    }
}
