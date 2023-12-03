using Airline_ticket_sales_management.DALs;
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

namespace Airline_ticket_sales_management
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test();
        }

        private async void test()
        {
            (List<PlaneTicketClassDetailDTO> x, string label) = await PlaneDAL.Ins.getPlaneTicketClassDetail(textBox1.Text);

            MessageBox.Show(label);
        }
    }
}
