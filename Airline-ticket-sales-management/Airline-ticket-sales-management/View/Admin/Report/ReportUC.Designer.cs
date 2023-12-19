using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class ReportUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnBodyReport = new System.Windows.Forms.Panel();
            this.cbTypeReport = new System.Windows.Forms.ComboBox();
            this.abtnExportExcel = new Airline_ticket_sales_management.AControls.AButton();
            this.adtpTime = new Airline_ticket_sales_management.AControls.ADateTimePicker();
            this.SuspendLayout();
            // 
            // pnBodyReport
            // 
            this.pnBodyReport.Location = new System.Drawing.Point(0, 60);
            this.pnBodyReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBodyReport.Name = "pnBodyReport";
            this.pnBodyReport.Size = new System.Drawing.Size(1500, 690);
            this.pnBodyReport.TabIndex = 3;
            // 
            // cbTypeReport
            // 
            this.cbTypeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cbTypeReport.FormattingEnabled = true;
            this.cbTypeReport.Items.AddRange(new object[] {
            "Báo cáo theo tháng",
            "Báo cáo theo năm"});
            this.cbTypeReport.Location = new System.Drawing.Point(50, 25);
            this.cbTypeReport.Name = "cbTypeReport";
            this.cbTypeReport.Size = new System.Drawing.Size(200, 30);
            this.cbTypeReport.TabIndex = 5;
            this.cbTypeReport.SelectedIndexChanged += new System.EventHandler(this.cbTypeReport_SelectedIndexChanged);
            // 
            // abtnExportExcel
            // 
            this.abtnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.abtnExportExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.abtnExportExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnExportExcel.BorderRadius = 10;
            this.abtnExportExcel.BorderSize = 0;
            this.abtnExportExcel.FlatAppearance.BorderSize = 0;
            this.abtnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnExportExcel.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnExportExcel.ForeColor = System.Drawing.Color.White;
            this.abtnExportExcel.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnExportExcel.Location = new System.Drawing.Point(1250, 24);
            this.abtnExportExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnExportExcel.Name = "abtnExportExcel";
            this.abtnExportExcel.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnExportExcel.Size = new System.Drawing.Size(200, 32);
            this.abtnExportExcel.TabIndex = 4;
            this.abtnExportExcel.Text = "Xuất excel";
            this.abtnExportExcel.TextColor = System.Drawing.Color.White;
            this.abtnExportExcel.ThinknessLine = 0;
            this.abtnExportExcel.UseVisualStyleBackColor = false;
            this.abtnExportExcel.Click += new System.EventHandler(this.abtnExportExcel_Click);
            // 
            // adtpTime
            // 
            this.adtpTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.adtpTime.BorderSize = 1;
            this.adtpTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.adtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.adtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.adtpTime.Location = new System.Drawing.Point(277, 26);
            this.adtpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adtpTime.MinimumSize = new System.Drawing.Size(4, 25);
            this.adtpTime.Name = "adtpTime";
            this.adtpTime.Size = new System.Drawing.Size(150, 25);
            this.adtpTime.SkinColor = System.Drawing.Color.White;
            this.adtpTime.TabIndex = 1;
            this.adtpTime.TextColor = System.Drawing.Color.Black;
            this.adtpTime.ValueChanged += new System.EventHandler(this.adtpTime_ValueChanged);
            // 
            // ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.cbTypeReport);
            this.Controls.Add(this.abtnExportExcel);
            this.Controls.Add(this.pnBodyReport);
            this.Controls.Add(this.adtpTime);
            this.Name = "ReportUC";
            this.Size = new System.Drawing.Size(1500, 750);
            this.ResumeLayout(false);

        }

        #endregion
        private AControls.ADateTimePicker adtpTime;
        private Panel pnBodyReport;
        private AControls.AButton abtnExportExcel;
        private ComboBox cbTypeReport;
    }
}
