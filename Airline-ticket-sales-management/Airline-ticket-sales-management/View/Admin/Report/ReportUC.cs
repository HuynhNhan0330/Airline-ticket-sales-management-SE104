using Airline_ticket_sales_management.AControls;
using Airline_ticket_sales_management.DALs;
using Airline_ticket_sales_management.DTOs;
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
                    adtpTime.CustomFormat = "MM/yyyy";
                    adtpTime_ValueChanged(sender, e);
                    break;
                case 1:
                    loadBody(new ReportByYearUC());
                    adtpTime.CustomFormat = "yyyy";
                    break;
            }
        }

        private void adtpTime_ValueChanged(object sender, EventArgs e)
        {
            switch (cbTypeReport.SelectedIndex)
            {
                // Xử lý trên tháng
                case 0:
                    loadReportByMonth();
                    break;

                // Xử lý trên năm
                case 1:
                    break;
            }
        }

        private async void loadReportByMonth()
        {
            // Xem đã có chi tiết báo cáo năm của tháng này chưa

            DetailedAnnualRevenueReportDTO findDetailedAnnualRevenueReport = await DetailedAnnualRevenueReportDAL.Ins.find(adtpTime.Value.Year, adtpTime.Value.Month);

            List<DetailedMonthlyRevenueReportDTO> listReportByMonthDetail = null;

            // Không tồn tại
            if (findDetailedAnnualRevenueReport == null)
            {
                listReportByMonthDetail = await calculateMonth(adtpTime.Value.Month, adtpTime.Value.Year);
            }
            else
            {
                (bool isGet, List< DetailedMonthlyRevenueReportDTO> x, string label) = await DetailedMonthlyRevenueReportDAL.Ins.getListDetailedMonthlyRevenueReport(adtpTime.Value.Month, adtpTime.Value.Year);
                if (isGet)
                {
                    listReportByMonthDetail = new List<DetailedMonthlyRevenueReportDTO>(x);
                }
                else
                {
                    AMessageBoxFrm ms = new AMessageBoxFrm(label, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ms.ShowDialog();
                }
            }

            ReportByMonthUC uc = pnBodyReport.Controls[0] as ReportByMonthUC;
            uc.loadData(listReportByMonthDetail);
        }


        public async Task<List<DetailedMonthlyRevenueReportDTO>> calculateMonth(int month, int year)
        {
            // Tính toán chi tiết theo tháng

            // Bước 1: Lấy thông tin báo cáo tháng chi tiết dụa trên chi tiết hạng vé chuyến bay
            (bool isGet, List<DetailedMonthlyRevenueReportDTO> detailedMonthlyRevenueReports) = await DetailedMonthlyRevenueReportDAL.Ins.getDetailedMonthlyRevenueReportInTicket(month, year);

            if (isGet)
            {
                decimal totalRevenue = detailedMonthlyRevenueReports.Sum(dmrr => dmrr.Revenue);

                // Tính tỉ lệ cho chi tiết báo cáo tháng
                foreach (DetailedMonthlyRevenueReportDTO dmrr in detailedMonthlyRevenueReports)
                    dmrr.Ratio = dmrr.Revenue * 100 / totalRevenue;

                // Kiểm tra điều kiên phù hợp sẽ lưu lên cơ sở dữ liệu của mình
                // Trên bảng chi tiết báo cáo tháng (Detailed Monthly Revenue Report)
                if (month < DateTime.Now.Month && year <= DateTime.Now.Year)
                {
                    // Tạo chi tiết báo cáo theo năm
                    DetailedAnnualRevenueReportDTO detailedAnnualRevenueReport = new DetailedAnnualRevenueReportDTO();
                    detailedAnnualRevenueReport.Year = year;
                    detailedAnnualRevenueReport.Month = month;
                    detailedAnnualRevenueReport.Revenue = totalRevenue;
                    detailedAnnualRevenueReport.FlightCount = detailedMonthlyRevenueReports.Count();

                    (bool isCreateDetailedAnnualRevenueReport, string label) = await DetailedAnnualRevenueReportDAL.Ins.createDetailedMonthlyRevenueReport(detailedAnnualRevenueReport);

                    if (isCreateDetailedAnnualRevenueReport)
                    {
                        // Lưu danh sách báo cáo chi tiết theo tháng
                        (bool isCreateDetailMonthlyRevenueReport, string label1) = await DetailedMonthlyRevenueReportDAL.Ins.createDetailedMonthlyRevenueReport(detailedMonthlyRevenueReports);

                        if (!isCreateDetailMonthlyRevenueReport)
                        {
                            AMessageBoxFrm ms = new AMessageBoxFrm(label1, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ms.ShowDialog();
                        }
                    }
                    else
                    {
                        AMessageBoxFrm ms = new AMessageBoxFrm(label, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ms.ShowDialog();
                    }

                }

                // Hiển thị lên view
                return detailedMonthlyRevenueReports;
            }
            else
            {
                return null;
            }
        }

        public async void calculateYear(int year)
        {
            for (int month = 1; month <= 12; ++month)
            {
                // Kiểm tra tháng này đã tồn tại chưa
                //bool isCheck = await DetailedAnnualRevenueReportDAL.Ins.checkExist(year, month);

                //// Đã tồn tại thì get báo cáo tháng
                //if (isCheck)
                //{
                    
                //}
                //else // Chưa tồn tại thì tính
                //{
                //    calculateMonth(month, year);
                //}
            }
        }
    }
}
