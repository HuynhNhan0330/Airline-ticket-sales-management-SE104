using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_ticket_sales_management
{
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
            cbTypeReport.SelectedIndex = 0;
        }

        private void loadBody(UserControl uc)
        {
            pnBodyReport.Controls.Clear();
            pnBodyReport.Controls.Add(uc);
        }

        private void cbTypeReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTypeReport.SelectedIndex)
            {
                case 0:
                    loadBody(new ReportByMonthUC());
                    break;
                case 1:
                    loadBody(new ReportByYearUC());
                    break;
            }
        }
    }
}
