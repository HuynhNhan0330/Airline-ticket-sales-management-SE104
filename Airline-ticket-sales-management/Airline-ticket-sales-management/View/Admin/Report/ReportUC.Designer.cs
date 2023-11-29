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
            this.aButton1 = new Airline_ticket_sales_management.AControls.AButton();
            this.aDateTimePicker1 = new Airline_ticket_sales_management.AControls.ADateTimePicker();
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
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.aButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(124)))), ((int)(((byte)(68)))));
            this.aButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton1.BorderRadius = 10;
            this.aButton1.BorderSize = 0;
            this.aButton1.FlatAppearance.BorderSize = 0;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("Arial", 12F);
            this.aButton1.ForeColor = System.Drawing.Color.White;
            this.aButton1.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.aButton1.Location = new System.Drawing.Point(1250, 24);
            this.aButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aButton1.Name = "aButton1";
            this.aButton1.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.aButton1.Size = new System.Drawing.Size(200, 32);
            this.aButton1.TabIndex = 4;
            this.aButton1.Text = "Xuất excel";
            this.aButton1.TextColor = System.Drawing.Color.White;
            this.aButton1.ThinknessLine = 0;
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aDateTimePicker1.BorderSize = 1;
            this.aDateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.aDateTimePicker1.Location = new System.Drawing.Point(277, 26);
            this.aDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aDateTimePicker1.MinimumSize = new System.Drawing.Size(4, 25);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(150, 25);
            this.aDateTimePicker1.SkinColor = System.Drawing.Color.White;
            this.aDateTimePicker1.TabIndex = 1;
            this.aDateTimePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // ReportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.cbTypeReport);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.pnBodyReport);
            this.Controls.Add(this.aDateTimePicker1);
            this.Name = "ReportUC";
            this.Size = new System.Drawing.Size(1500, 750);
            this.ResumeLayout(false);

        }

        #endregion
        private AControls.ADateTimePicker aDateTimePicker1;
        private Panel pnBodyReport;
        private AControls.AButton aButton1;
        private ComboBox cbTypeReport;
    }
}
