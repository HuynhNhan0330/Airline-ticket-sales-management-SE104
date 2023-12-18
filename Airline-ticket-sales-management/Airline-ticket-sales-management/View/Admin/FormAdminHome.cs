using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Utils;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    public partial class FormAdminHome : Form
    {
        private AccountDTO _account = new AccountDTO();
        public AccountDTO account
        {
            get { return _account; }
            set
            {
                _account = value;
            }
        }

        private AButton currentButton = null;
        private UserControl oldBody = null;

        public FormAdminHome()
        {
            InitializeComponent();
            loadBody(new HomeAdminUC());
        }

        public FormAdminHome(AccountDTO account)
        {
            InitializeComponent();
            loadBody(new HomeAdminUC());
            
            this.account = account;

            for (int i = 0; i < account.PermissionCode.Length; ++i)
            {
                if (account.PermissionCode[i] == '0')
                {
                    switch (i)
                    {
                        case 0:
                            abtnFlight.Visible = false;
                            break;
                        case 1:
                            abtnFlightTicket.Visible = false;
                            break;
                        case 2:
                            abtnReport.Visible = false;
                            break;
                        case 3:
                            abtnPlane.Visible = false;
                            break;
                        case 4:
                            abtnAccountAndPermission.Visible = false;
                            break;
                        case 5:
                            abtnSetting.Visible = false;
                            break;
                    }
                }
            }
        }

        private void FormAdminHome_Load(object sender, EventArgs e)
        {
            _ = ParametersDAL.Ins.getParameters();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = RoundedRectangle.Create(this.Width, this.Height, 20);

            // Đặt Region cho Form để tạo hình dạng bo tròn
            this.Region = new Region(path);
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadBody(UserControl uc)
        {
            if (oldBody != null)
            {
                pnBody.Controls.Remove(oldBody);
            }

            pnBody.Controls.Add(uc);
            oldBody = uc;
        }

        #region Menu
        private void doActivateButton(AButton abtn)
        {
            abtn.ForeColor = BaseColor.XanhDam;
            abtn.Font = new Font(abtn.Font, FontStyle.Bold);
            abtn.LineType = AButton.LineStyles.Bottom;
        }

        private void doDeactivateButton(AButton abtn)
        {
            abtn.ForeColor = BaseColor.Xam;
            abtn.Font = new Font(abtn.Font, FontStyle.Regular);
            abtn.LineType = AButton.LineStyles.None;
        }

        private void abtnPlane_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnPlane)
            {
                if (currentButton != null)
                    doDeactivateButton(currentButton);

                currentButton = abtnPlane;
                doActivateButton(currentButton);
                loadBody(new PlaneUC());
            }
        }

        private void abtnSetting_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnSetting)
            {
                if (currentButton != null)
                    doDeactivateButton(currentButton);

                currentButton = abtnSetting;
                doActivateButton(currentButton);
                loadBody(new SettingUC());
            }
        }

        private void abtnFlight_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnFlight)
            {
                if (currentButton != null)
                    doDeactivateButton(currentButton);

                currentButton = abtnFlight;
                doActivateButton(currentButton);
                loadBody(new FlightUC());
            }
        }

        private void abtnReport_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnReport)
            {
                if (currentButton != null)
                    doDeactivateButton(currentButton);

                currentButton = abtnReport;
                doActivateButton(currentButton);
                loadBody(new ReportUC());
            }
        }

        private void abtnFlightTicket_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnFlightTicket)
            {
                if (currentButton != null)
                    doDeactivateButton(currentButton);

                currentButton = abtnFlightTicket;
                doActivateButton(currentButton);
                loadBody(new FlightTicketUC());
            }
        }

        private void abtnAccountAndPermission_Click(object sender, EventArgs e)
        {
            if (currentButton != abtnAccountAndPermission)
            {
                if (currentButton != null)
                    doDeactivateButton(currentButton);

                currentButton = abtnAccountAndPermission;
                doActivateButton(currentButton);
                loadBody(new AccountAndPermissionUC());
            }
        }
        #endregion


        public void goToTicket(FlightDTO flight)
        {
            if (currentButton != null)
                doDeactivateButton(currentButton);

            currentButton = abtnFlightTicket;
            doActivateButton(currentButton);
            loadBody(new FlightTicketUC(flight));
        }
    }
}
