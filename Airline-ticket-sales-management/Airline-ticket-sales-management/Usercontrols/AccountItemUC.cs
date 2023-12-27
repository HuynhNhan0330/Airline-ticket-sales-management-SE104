using Airline_ticket_sales_management.AControls;
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
            setClick(this);
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

        private void AccountItemUC_Click(object sender, EventArgs e)
        {
            if (account.RoleID[5] <= Helper.getAccountAdmin().RoleID[5])
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Không đủ quyền truy cập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
                return;
            }

            Control ct = this;

            while (!(ct is AccountAndPermissionUC))
                ct = ct.Parent;

            AccountAndPermissionUC uc = ct as AccountAndPermissionUC;
            uc.setTextboxAccount(this.account);
        }

        private void setClick(Control ctr)
        {
            ctr.Click += AccountItemUC_Click;

            if (!(ctr is Label))
                foreach (Control c in ctr.Controls)
                    setClick(c);
        }
    }
}
