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
    public partial class DetailTicketClassUC : UserControl
    {
        private string _nameTicketClass;
        public string NameTicketClass
        {
            get { return _nameTicketClass; }
            set
            {
                _nameTicketClass = value;
            }
        }

        private int _seatCount;
        public int SeatCount
        {
            get { return _seatCount; }
            set
            {
                _seatCount = value;
            }
        }

        public DetailTicketClassUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbName.Text = NameTicketClass;
            lbNumber.Text = SeatCount.ToString();
            
            lbNumber.Left = (pnNumber.Width - lbNumber.Width) / 2;

            this.Height = 15 * 2 + lbNumber.Height;
            this.Height = Math.Max(15 * 2 + lbName.Height, this.Height);

            lbName.Top = (this.Height - lbName.Height) / 2;
            lbNumber.Top = (this.Height - lbNumber.Height) / 2;
        }
    }
}
