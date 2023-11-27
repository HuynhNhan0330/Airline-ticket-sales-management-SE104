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
            this.aTextboxUC3 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxUC2 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxUC1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aButton1 = new Airline_ticket_sales_management.AControls.AButton();
            this.aDateTimePicker1 = new Airline_ticket_sales_management.AControls.ADateTimePicker();
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
            this.pnFlightList.Size = new System.Drawing.Size(1400, 432);
            this.pnFlightList.TabIndex = 5;
            // 
            // pnHeader
            // 
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
            this.panel1.Location = new System.Drawing.Point(1030, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 48);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(143, 12);
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
            this.panel9.Location = new System.Drawing.Point(960, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(70, 48);
            this.panel9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.MaximumSize = new System.Drawing.Size(65, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 48);
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
            this.panel8.Size = new System.Drawing.Size(70, 48);
            this.panel8.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.MaximumSize = new System.Drawing.Size(60, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 44);
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
            // aTextboxUC3
            // 
            this.aTextboxUC3.BackColor = System.Drawing.Color.White;
            this.aTextboxUC3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxUC3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxUC3.BorderRadius = 5;
            this.aTextboxUC3.BorderSize = 2;
            this.aTextboxUC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxUC3.ForeColor = System.Drawing.Color.DimGray;
            this.aTextboxUC3.isPlaceholder = true;
            this.aTextboxUC3.Location = new System.Drawing.Point(675, 24);
            this.aTextboxUC3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aTextboxUC3.Multiline = false;
            this.aTextboxUC3.Name = "aTextboxUC3";
            this.aTextboxUC3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.aTextboxUC3.PasswordChar = false;
            this.aTextboxUC3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxUC3.PlaceholderText = "Nơi hạ cánh";
            this.aTextboxUC3.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxUC3.Size = new System.Drawing.Size(200, 37);
            this.aTextboxUC3.TabIndex = 3;
            this.aTextboxUC3.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxUC3.Texts = "";
            this.aTextboxUC3.UnderlinedStyle = false;
            // 
            // aTextboxUC2
            // 
            this.aTextboxUC2.BackColor = System.Drawing.Color.White;
            this.aTextboxUC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxUC2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxUC2.BorderRadius = 5;
            this.aTextboxUC2.BorderSize = 2;
            this.aTextboxUC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxUC2.ForeColor = System.Drawing.Color.DimGray;
            this.aTextboxUC2.isPlaceholder = true;
            this.aTextboxUC2.Location = new System.Drawing.Point(467, 24);
            this.aTextboxUC2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aTextboxUC2.Multiline = false;
            this.aTextboxUC2.Name = "aTextboxUC2";
            this.aTextboxUC2.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.aTextboxUC2.PasswordChar = false;
            this.aTextboxUC2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxUC2.PlaceholderText = "Nơi cất cánh";
            this.aTextboxUC2.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxUC2.Size = new System.Drawing.Size(200, 37);
            this.aTextboxUC2.TabIndex = 2;
            this.aTextboxUC2.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxUC2.Texts = "";
            this.aTextboxUC2.UnderlinedStyle = false;
            // 
            // aTextboxUC1
            // 
            this.aTextboxUC1.BackColor = System.Drawing.Color.White;
            this.aTextboxUC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxUC1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxUC1.BorderRadius = 5;
            this.aTextboxUC1.BorderSize = 2;
            this.aTextboxUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxUC1.ForeColor = System.Drawing.Color.DimGray;
            this.aTextboxUC1.isPlaceholder = true;
            this.aTextboxUC1.Location = new System.Drawing.Point(50, 25);
            this.aTextboxUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aTextboxUC1.Multiline = false;
            this.aTextboxUC1.Name = "aTextboxUC1";
            this.aTextboxUC1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.aTextboxUC1.PasswordChar = false;
            this.aTextboxUC1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxUC1.PlaceholderText = "Mã chuyến bay";
            this.aTextboxUC1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxUC1.Size = new System.Drawing.Size(200, 37);
            this.aTextboxUC1.TabIndex = 0;
            this.aTextboxUC1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxUC1.Texts = "";
            this.aTextboxUC1.UnderlinedStyle = false;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton1.BorderRadius = 10;
            this.aButton1.BorderSize = 0;
            this.aButton1.FlatAppearance.BorderSize = 0;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("Arial", 10.8F);
            this.aButton1.ForeColor = System.Drawing.Color.White;
            this.aButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aButton1.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.aButton1.Location = new System.Drawing.Point(1330, 24);
            this.aButton1.Name = "aButton1";
            this.aButton1.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.aButton1.Size = new System.Drawing.Size(120, 33);
            this.aButton1.TabIndex = 4;
            this.aButton1.Text = "Tìm kiếm";
            this.aButton1.TextColor = System.Drawing.Color.White;
            this.aButton1.ThinknessLine = 0;
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // aDateTimePicker1
            // 
            this.aDateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aDateTimePicker1.BorderSize = 2;
            this.aDateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aDateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aDateTimePicker1.Location = new System.Drawing.Point(260, 26);
            this.aDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aDateTimePicker1.MinimumSize = new System.Drawing.Size(4, 35);
            this.aDateTimePicker1.Name = "aDateTimePicker1";
            this.aDateTimePicker1.Size = new System.Drawing.Size(200, 35);
            this.aDateTimePicker1.SkinColor = System.Drawing.Color.White;
            this.aDateTimePicker1.TabIndex = 6;
            this.aDateTimePicker1.TextColor = System.Drawing.Color.Black;
            // 
            // FlightListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.aDateTimePicker1);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnFlightList);
            this.Controls.Add(this.aButton1);
            this.Controls.Add(this.aTextboxUC3);
            this.Controls.Add(this.aTextboxUC2);
            this.Controls.Add(this.aTextboxUC1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.Name = "FlightListUC";
            this.Size = new System.Drawing.Size(1500, 576);
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
        private AControls.ATextboxUC aTextboxUC1;
        private AControls.ATextboxUC aTextboxUC2;
        private AControls.ATextboxUC aTextboxUC3;
        private AControls.AButton aButton1;
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
        private AControls.ADateTimePicker aDateTimePicker1;
    }
}
