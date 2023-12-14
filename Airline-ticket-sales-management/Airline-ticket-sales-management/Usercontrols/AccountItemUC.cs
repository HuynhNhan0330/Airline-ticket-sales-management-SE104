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
    public partial class AccountItemUC : UserControl
    {
        private AccountDTO _account;
        public AccountDTO account
        {
            get { return _account; }
            set
            {
                _account = value;
                render();
            }
        }

        public AccountItemUC()
        {
            InitializeComponent();
        }

        public void render()
        {
            lbName.Text = account.Name;
            lbName.Left = (pnName.Width - lbName.Width) / 2;

            lbCreated.Text = account.Created.ToString("dd-MM-yyyy");
            lbCreated.Left = (pnCreated.Width - lbCreated.Width) / 2;

            lbPermission.Text = account.RoleName;
            lbPermission.Left = (pnPermission.Width - lbPermission.Width) / 2;
            this.Height = Math.Max(this.Height, lbPermission.Height + 15 * 2);
        }
    }
}
