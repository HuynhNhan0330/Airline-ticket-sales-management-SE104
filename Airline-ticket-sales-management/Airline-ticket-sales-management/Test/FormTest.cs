using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Utils;
using IronXL;
using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string PATH_TEMPLATE = @"../../Excel/TemplateReportByMonth.xlsx";
                string PATH_EXPORT = saveFileDialog.FileName;

                var value = new
                {
                    reportType = "Báo cáo năm",
                    reportTime = DateTime.Now.ToString("dd/MM/yyyy"),
                    nameUser = "Huỳnh Mai Cao Nhân"
                };

                MiniExcel.SaveAsByTemplate(PATH_EXPORT, PATH_TEMPLATE, value);

                Process.Start(PATH_EXPORT);

                //WorkBook workBook = WorkBook.Load(PATH_EXPORT);
                //WorkSheet workSheet = workBook.DefaultWorkSheet;

                //// Apply auto resize on row 2
                //workSheet.AutoSizeRow(1);

                //// Apply auto resize on column A
                //workSheet.AutoSizeColumn(0);

                //// Apply auto resize on column D
                //workSheet.AutoSizeColumn(3, true);

                //workBook.SaveAs("autoResize.xlsx");
            }
        }
    }
}
