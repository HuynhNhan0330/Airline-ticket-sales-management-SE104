using Airline_ticket_sales_management.AControls;
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
using System.Xml;

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class TicketClassItemUC : UserControl
    {
        private TicketClassDTO _TicketClass;
        public TicketClassDTO TicketClass
        {
            get { return _TicketClass; }
            set
            {
                _TicketClass = value;
                TicketClassName = _TicketClass.TicketClassName;
                PricePercentage = _TicketClass.PricePercentage;
            }
        }

        private string _TicketClassName;
        public string TicketClassName
        {
            get { return _TicketClassName; }
            set
            {
                _TicketClassName = value;
                lbTicketClassName.Text = _TicketClassName;
                lbTicketClassName.Left = (pnTicketClassName.Width - lbTicketClassName.Width) / 2;

                renderLabel(lbTicketClassName);

                renderOperation();
            }
        }

        private int _PricePercentage;
        public int PricePercentage
        {
            get { return _PricePercentage; }
            set
            {
                _PricePercentage = value;
                lbPricePercentage.Text = _PricePercentage.ToString();
                lbPricePercentage.Left = (pnPricePercentage.Width - lbPricePercentage.Width) / 2;

                renderLabel(lbPricePercentage);

                renderOperation();
            }
        }

        public TicketClassItemUC()
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

        private void pibEdit_Click(object sender, EventArgs e)
        {
            Control ct = this.Parent;

            while (!(ct is SettingUC))
                ct = ct.Parent;

            SettingUC  settingUC = ct as SettingUC;

            settingUC.setTextboxTicketClass(TicketClass);
        }

        private void pibDelete_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ms.ShowDialog() == DialogResult.Yes)
            {
                Control ct = this.Parent;

                while (!(ct is SettingUC))
                    ct = ct.Parent;

                SettingUC settingUC = ct as SettingUC;
                settingUC.removeTicketClassItem(TicketClass);

            }
        }
    }
}
