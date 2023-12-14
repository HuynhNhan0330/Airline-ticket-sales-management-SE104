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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Airline_ticket_sales_management.Usercontrols
{
    public partial class PermissiontItemUC : UserControl
    {
        private PermissionDTO _permission;
        public PermissionDTO permission
        {
            get { return _permission; }
            set
            {
                _permission = value;
                render();
            }
        }

        public PermissiontItemUC()
        {
            InitializeComponent();
        }

        private void render()
        {
            lbName.Text = permission.RoleName;
            lbName.Left = (pnName.Width - lbName.Width) / 2;
            this.Height = lbName.Height + 15 * 2;

            for (int i = 0; i < permission.PermissionCode.Length; i++)
            {
                if (permission.PermissionCode[i] == '1')
                {
                    switch (i)
                    {
                        case 0:
                            cb0.Checked = true;
                            break;
                        case 1:
                            cb1.Checked = true;
                            break;
                        case 2:
                            cb2.Checked = true;
                            break;
                        case 3:
                            cb3.Checked = true;
                            break;
                        case 4:
                            cb4.Checked = true;
                            break;
                        case 5:
                            cb5.Checked = true;
                            break;
                        case 6:
                            cb6.Checked = true;
                            break;
                    }
                }
            }
        }

        public PermissionDTO getPermission()
        {
            string s = "";

            s = cb0.Checked ? s + "1" : s + "0";
            s = cb1.Checked ? s + "1" : s + "0";
            s = cb2.Checked ? s + "1" : s + "0";
            s = cb3.Checked ? s + "1" : s + "0";
            s = cb4.Checked ? s + "1" : s + "0";
            s = cb5.Checked ? s + "1" : s + "0";
            //s = cb6.Checked ? s + "1" : s + "0";

            permission.PermissionCode = s;
            return permission;
        }
    }
}
