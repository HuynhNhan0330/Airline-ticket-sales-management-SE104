using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Usercontrols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class AccountAndPermissionUC : UserControl
    {
        private ObservableCollection<AccountDTO> accounts;
        private ObservableCollection<PermissionDTO> permissions;

        public AccountAndPermissionUC()
        {
            InitializeComponent();
        }

        private void pibHideViewPassword_Click(object sender, EventArgs e)
        {
            if (atxbPassword.PasswordChar)
            {
                atxbPassword.PasswordChar = false;
                pibHideViewPassword.BackgroundImage = Properties.Resources.hide;
            }
            else
            {
                atxbPassword.PasswordChar = true;
                pibHideViewPassword.BackgroundImage = Properties.Resources.view;
            }
        }

        private void AccountAndPermissionUC_Load(object sender, EventArgs e)
        {
            loadAccount();
            loadPermission();
        }

        private void setCombobox()
        {
            cbPermissionName.DataSource = permissions;
            cbPermissionName.DisplayMember = "RoleName";
        }

        private async void loadAccount()
        {
            (bool isGet, List<AccountDTO> accounts, string label) = await AccountDAL.Ins.getListAccount();

            if (isGet)
            {
                this.accounts = new ObservableCollection<AccountDTO>(accounts);
                loadPanelAccount();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void addAccount(AccountDTO account)
        {
            AccountItemUC uc = new AccountItemUC();
            uc.account = account;
            pnListAccount.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Top;
        }

        private void loadPanelAccount()
        {
            foreach (AccountDTO account in this.accounts)
            {
                addAccount(account);
            }
        }

        private async void loadPermission()
        {
            (bool isGet, List<PermissionDTO> permissions, string label) = await PermissionDAL.Ins.getListPermission();

            if (isGet)
            {
                this.permissions = new ObservableCollection<PermissionDTO>(permissions);
                loadPanelPermission();
                setCombobox();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void addPermission(PermissionDTO permission)
        {
            PermissiontItemUC uc = new PermissiontItemUC();
            uc.permission = permission;
            pnListPermission.Controls.Add(uc);
            uc.BringToFront();
            uc.Dock = DockStyle.Top;
        }

        private void loadPanelPermission()
        {
            foreach (PermissionDTO permission in this.permissions)
            {
                addPermission(permission);
            }
        }

        private void abtnSavePermission_Click(object sender, EventArgs e)
        {
            List <PermissionDTO> permissions = new List<PermissionDTO>();

            foreach (PermissiontItemUC uc in pnListPermission.Controls)
                permissions.Add(uc.getPermission());

            updatePermission(permissions);
        }

        private async void updatePermission(List<PermissionDTO> permissions)
        {
            (bool isUpdate, string label) = await PermissionDAL.Ins.updatePermission(permissions);

            if (isUpdate)
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }
    }
}
