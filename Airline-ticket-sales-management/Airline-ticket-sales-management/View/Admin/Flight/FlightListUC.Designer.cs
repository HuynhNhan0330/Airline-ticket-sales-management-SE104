using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class FlightListUC
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
            this.pnFlightList = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.abtnSearchFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.adtpTime = new Airline_ticket_sales_management.AControls.ADateTimePicker();
            this.cbDepatureAirport = new System.Windows.Forms.ComboBox();
            this.cbArrivalAirport = new System.Windows.Forms.ComboBox();
            this.pnHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFlightList
            // 
            this.pnFlightList.AutoScroll = true;
            this.pnFlightList.Location = new System.Drawing.Point(50, 120);
            this.pnFlightList.Name = "pnFlightList";
            this.pnFlightList.Size = new System.Drawing.Size(1400, 520);
            this.pnFlightList.TabIndex = 5;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Controls.Add(this.panel9);
            this.pnHeader.Controls.Add(this.panel8);
            this.pnHeader.Controls.Add(this.panel7);
            this.pnHeader.Controls.Add(this.panel6);
            this.pnHeader.Controls.Add(this.panel5);
            this.pnHeader.Controls.Add(this.panel4);
            this.pnHeader.Controls.Add(this.panel3);
            this.pnHeader.Controls.Add(this.panel2);
            this.pnHeader.Location = new System.Drawing.Point(50, 72);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1400, 48);
            this.pnHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1110, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 48);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(101, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thao tác";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(990, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(120, 48);
            this.panel9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(8, 12);
            this.label8.MaximumSize = new System.Drawing.Size(200, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ghế đã đặt";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(890, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 48);
            this.panel8.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(5, 12);
            this.label7.MaximumSize = new System.Drawing.Size(100, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ghế trống";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(750, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(140, 48);
            this.panel7.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(25, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Thời gian";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(600, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 48);
            this.panel6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(19, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nơi hạ cánh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(450, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 48);
            this.panel5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(0, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sân bay hạ cánh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(300, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 48);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nơi cất cánh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(150, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 48);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(0, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sân bay cất cánh";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 48);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã chuyến bay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abtnSearchFlight
            // 
            this.abtnSearchFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearchFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearchFlight.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSearchFlight.BorderRadius = 15;
            this.abtnSearchFlight.BorderSize = 0;
            this.abtnSearchFlight.FlatAppearance.BorderSize = 0;
            this.abtnSearchFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSearchFlight.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnSearchFlight.ForeColor = System.Drawing.Color.White;
            this.abtnSearchFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abtnSearchFlight.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnSearchFlight.Location = new System.Drawing.Point(1330, 24);
            this.abtnSearchFlight.Name = "abtnSearchFlight";
            this.abtnSearchFlight.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnSearchFlight.Size = new System.Drawing.Size(120, 37);
            this.abtnSearchFlight.TabIndex = 4;
            this.abtnSearchFlight.Text = "Tìm kiếm";
            this.abtnSearchFlight.TextColor = System.Drawing.Color.White;
            this.abtnSearchFlight.ThinknessLine = 0;
            this.abtnSearchFlight.UseVisualStyleBackColor = false;
            this.abtnSearchFlight.Click += new System.EventHandler(this.abtnSearchFlight_Click);
            // 
            // adtpTime
            // 
            this.adtpTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.adtpTime.BorderSize = 2;
            this.adtpTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.adtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adtpTime.Location = new System.Drawing.Point(50, 25);
            this.adtpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adtpTime.MinimumSize = new System.Drawing.Size(4, 30);
            this.adtpTime.Name = "adtpTime";
            this.adtpTime.Size = new System.Drawing.Size(200, 30);
            this.adtpTime.SkinColor = System.Drawing.Color.White;
            this.adtpTime.TabIndex = 6;
            this.adtpTime.TextColor = System.Drawing.Color.Black;
            // 
            // cbDepatureAirport
            // 
            this.cbDepatureAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbDepatureAirport.FormattingEnabled = true;
            this.cbDepatureAirport.Location = new System.Drawing.Point(300, 25);
            this.cbDepatureAirport.Name = "cbDepatureAirport";
            this.cbDepatureAirport.Size = new System.Drawing.Size(200, 30);
            this.cbDepatureAirport.TabIndex = 7;
            this.cbDepatureAirport.Text = "Nơi cất cánh";
            // 
            // cbArrivalAirport
            // 
            this.cbArrivalAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbArrivalAirport.FormattingEnabled = true;
            this.cbArrivalAirport.Location = new System.Drawing.Point(550, 25);
            this.cbArrivalAirport.Name = "cbArrivalAirport";
            this.cbArrivalAirport.Size = new System.Drawing.Size(200, 30);
            this.cbArrivalAirport.TabIndex = 8;
            this.cbArrivalAirport.Text = "Nơi hạ cánh";
            // 
            // FlightListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.cbArrivalAirport);
            this.Controls.Add(this.cbDepatureAirport);
            this.Controls.Add(this.adtpTime);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnFlightList);
            this.Controls.Add(this.abtnSearchFlight);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Name = "FlightListUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.Load += new System.EventHandler(this.FlightListUC_Load);
            this.pnHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AControls.AButton abtnSearchFlight;
        private Panel pnFlightList;
        private Panel pnHeader;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Label label1;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private AControls.ADateTimePicker adtpTime;
        private ComboBox cbDepatureAirport;
        private ComboBox cbArrivalAirport;
    }
}
