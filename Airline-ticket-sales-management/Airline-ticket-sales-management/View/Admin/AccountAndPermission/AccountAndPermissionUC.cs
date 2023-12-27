using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Usercontrols;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class AccountAndPermissionUC : UserControl
    {
        private ObservableCollection<AccountDTO> accounts;
        private ObservableCollection<PermissionDTO> permissions;
        private AccountDTO accountSelected;

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
            pnEdit.Visible = false;

            if (Helper.getAccountAdmin().RoleName != "Siêu quản trị")
                abtnSavePermission.Visible = false;
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

        public void setTextboxAccount(AccountDTO account)
        {
            this.accountSelected = account;
            pnEdit.Visible = true;
            
            atxbName.Texts = account.Name;
            atxbName.isPlaceholder = false;
            atxbName.setForeColor();

            atxbEmail.Texts = account.Email;
            atxbEmail.isPlaceholder = false;
            atxbEmail.setForeColor();

            atxbPhone.Texts = account.Phone;
            atxbPhone.isPlaceholder = false;
            atxbPhone.setForeColor();

            atxbPassword.Texts = account.Password;
            atxbPassword.isPlaceholder = false;
            atxbPassword.setForeColor();
            atxbPassword.PasswordChar = true;

            cbPermissionName.Text = account.RoleName;
        }

        private void abtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu họ và tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkEmail(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Email chưa đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (!Helper.checkPhone(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Số điện thoại chưa đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                AccountDTO account = new AccountDTO();
                account.Name = atxbName.Texts.Trim();
                account.Email = atxbEmail.Texts.Trim();
                account.Phone = atxbPhone.Texts.Trim();
                account.Password = atxbPassword.Texts.Trim();
                account.RoleID = (cbPermissionName.SelectedItem as PermissionDTO).RoleID;
                account.RoleName = cbPermissionName.Text;
                account.Created = DateTime.Now;


                if (account.RoleID[5] > Helper.getAccountAdmin().RoleID[5])
                    createAccount(account);
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Không đủ quyền để tạo tài khoản có vai trò này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }
        }

        private async void createAccount(AccountDTO account)
        {
            (bool isCreate, string label, string newCode) = await AccountDAL.Ins.createAccount(account);

            if (isCreate)
            {
                account.AccountID = newCode;
                addAccount(account);

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void abtnCancel_Click(object sender, EventArgs e)
        {
            atxbName.Texts = "";
            atxbEmail.Texts = "";
            atxbPhone.Texts = "";
            atxbPassword.Texts = "";

            pnEdit.Visible = false;
        }

        private void abtnDelete_Click(object sender, EventArgs e)
        {
            AMessageBoxFrm ms = new AMessageBoxFrm("Xác nhận xoá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms.ShowDialog() == DialogResult.Yes)
                deleteAccount();
        }

        private async void deleteAccount()
        {
            (bool isDelete, string label) = await AccountDAL.Ins.deleteAccount(this.accountSelected.AccountID);

            if (isDelete)
            {
                atxbName.Texts = "";
                atxbEmail.Texts = "";
                atxbPhone.Texts = "";
                atxbPassword.Texts = "";

                pnEdit.Visible = false;

                deleteAccountItem();
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void deleteAccountItem()
        {
            Control ucSeleced = null;

            foreach (AccountItemUC uc in pnListAccount.Controls)
            {
                if (uc.account.AccountID == this.accountSelected.AccountID)
                {
                    ucSeleced = uc;
                    break;
                }
            }

            if (ucSeleced != null)
            {
                pnListAccount.Controls.Remove(ucSeleced);
            }
        }

        private void abtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(atxbName.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu họ và tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbEmail.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPhone.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else if (string.IsNullOrEmpty(atxbPassword.Texts.Trim()))
            {
                AMessageBoxFrm ms = new AMessageBoxFrm("Dữ liệu mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
            else
            {
                AccountDTO account = new AccountDTO();
                account.AccountID = this.accountSelected.AccountID;
                account.Name = atxbName.Texts.Trim();
                account.Email = atxbEmail.Texts.Trim();
                account.Phone = atxbPhone.Texts.Trim();
                account.Password = atxbPassword.Texts.Trim();
                account.RoleID = (cbPermissionName.SelectedItem as PermissionDTO).RoleID;
                account.RoleName = cbPermissionName.Text;
                account.Created = DateTime.Now;
                
                if (account.RoleID[5] > Helper.getAccountAdmin().RoleID[5])
                    updateAccount(account);
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm("Không đủ quyền để tạo tài khoản có vai trò này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }

            }
        }
        
        private async void updateAccount(AccountDTO account)
        {
            (bool isUpdate, string label) = await AccountDAL.Ins.updateAccount(account);

            if (isUpdate)
            {
                updateAccountItem(account);

                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.ShowDialog();
            }
            else
            {
                AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ms.ShowDialog();
            }
        }

        private void updateAccountItem(AccountDTO account)
        {
            foreach (AccountItemUC uc in pnListAccount.Controls)
            {
                if (uc.account.AccountID == account.AccountID)
                {
                    uc.account = account;
                    break;
                }
            }
        }

        private void atxbPhone__KeyDown(object sender, EventArgs e)
        {
            Helper.enterOnlyNumber(e);
        }

        private void atxbName__KeyDown(object sender, EventArgs e)
        {
            Helper.enterOnlyLetter(e);
        }
    }
}
