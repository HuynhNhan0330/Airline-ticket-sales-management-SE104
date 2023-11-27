using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class OperationFlightUC
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
            this.pnTicketClassDetail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atxbMinute = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbHour = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aButton3 = new Airline_ticket_sales_management.AControls.AButton();
            this.aButton2 = new Airline_ticket_sales_management.AControls.AButton();
            this.atxbPlaneID = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbArrivalAirport = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbDepartureAirport = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.abtnCreateFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.atxbTicketPrice = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbFlightDuration = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.adtpDepartureDateTime = new Airline_ticket_sales_management.AControls.ADateTimePicker();
            this.SuspendLayout();
            // 
            // pnTicketClassDetail
            // 
            this.pnTicketClassDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnTicketClassDetail.Location = new System.Drawing.Point(350, 25);
            this.pnTicketClassDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTicketClassDetail.Name = "pnTicketClassDetail";
            this.pnTicketClassDetail.Size = new System.Drawing.Size(200, 500);
            this.pnTicketClassDetail.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(600, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 540);
            this.panel1.TabIndex = 9;
            // 
            // atxbMinute
            // 
            this.atxbMinute.BackColor = System.Drawing.SystemColors.Window;
            this.atxbMinute.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbMinute.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbMinute.BorderRadius = 0;
            this.atxbMinute.BorderSize = 2;
            this.atxbMinute.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbMinute.ForeColor = System.Drawing.Color.Black;
            this.atxbMinute.isPlaceholder = true;
            this.atxbMinute.Location = new System.Drawing.Point(200, 265);
            this.atxbMinute.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbMinute.Multiline = false;
            this.atxbMinute.Name = "atxbMinute";
            this.atxbMinute.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbMinute.PasswordChar = false;
            this.atxbMinute.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbMinute.PlaceholderText = "Phút";
            this.atxbMinute.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbMinute.Size = new System.Drawing.Size(100, 35);
            this.atxbMinute.TabIndex = 18;
            this.atxbMinute.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbMinute.Texts = "";
            this.atxbMinute.UnderlinedStyle = false;
            // 
            // atxbHour
            // 
            this.atxbHour.BackColor = System.Drawing.SystemColors.Window;
            this.atxbHour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbHour.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbHour.BorderRadius = 0;
            this.atxbHour.BorderSize = 2;
            this.atxbHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbHour.ForeColor = System.Drawing.Color.Black;
            this.atxbHour.isPlaceholder = true;
            this.atxbHour.Location = new System.Drawing.Point(50, 265);
            this.atxbHour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbHour.Multiline = false;
            this.atxbHour.Name = "atxbHour";
            this.atxbHour.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbHour.PasswordChar = false;
            this.atxbHour.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbHour.PlaceholderText = "Giờ";
            this.atxbHour.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbHour.Size = new System.Drawing.Size(100, 35);
            this.atxbHour.TabIndex = 17;
            this.atxbHour.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbHour.Texts = "";
            this.atxbHour.UnderlinedStyle = false;
            // 
            // aButton3
            // 
            this.aButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton3.BorderRadius = 20;
            this.aButton3.BorderSize = 0;
            this.aButton3.FlatAppearance.BorderSize = 0;
            this.aButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton3.Font = new System.Drawing.Font("Arial", 12F);
            this.aButton3.ForeColor = System.Drawing.Color.White;
            this.aButton3.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.aButton3.Location = new System.Drawing.Point(725, 25);
            this.aButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aButton3.Name = "aButton3";
            this.aButton3.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.aButton3.Size = new System.Drawing.Size(100, 50);
            this.aButton3.TabIndex = 16;
            this.aButton3.Text = "-";
            this.aButton3.TextColor = System.Drawing.Color.White;
            this.aButton3.ThinknessLine = 0;
            this.aButton3.UseVisualStyleBackColor = false;
            // 
            // aButton2
            // 
            this.aButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton2.BorderRadius = 20;
            this.aButton2.BorderSize = 0;
            this.aButton2.FlatAppearance.BorderSize = 0;
            this.aButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton2.Font = new System.Drawing.Font("Arial", 12F);
            this.aButton2.ForeColor = System.Drawing.Color.White;
            this.aButton2.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.aButton2.Location = new System.Drawing.Point(600, 25);
            this.aButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aButton2.Name = "aButton2";
            this.aButton2.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.aButton2.Size = new System.Drawing.Size(100, 50);
            this.aButton2.TabIndex = 15;
            this.aButton2.Text = "+";
            this.aButton2.TextColor = System.Drawing.Color.White;
            this.aButton2.ThinknessLine = 0;
            this.aButton2.UseVisualStyleBackColor = false;
            // 
            // atxbPlaneID
            // 
            this.atxbPlaneID.BackColor = System.Drawing.SystemColors.Window;
            this.atxbPlaneID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbPlaneID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbPlaneID.BorderRadius = 0;
            this.atxbPlaneID.BorderSize = 2;
            this.atxbPlaneID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPlaneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbPlaneID.ForeColor = System.Drawing.Color.Black;
            this.atxbPlaneID.isPlaceholder = true;
            this.atxbPlaneID.Location = new System.Drawing.Point(50, 145);
            this.atxbPlaneID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPlaneID.Multiline = false;
            this.atxbPlaneID.Name = "atxbPlaneID";
            this.atxbPlaneID.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPlaneID.PasswordChar = false;
            this.atxbPlaneID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPlaneID.PlaceholderText = "Mã máy bay";
            this.atxbPlaneID.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPlaneID.Size = new System.Drawing.Size(250, 35);
            this.atxbPlaneID.TabIndex = 14;
            this.atxbPlaneID.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPlaneID.Texts = "";
            this.atxbPlaneID.UnderlinedStyle = false;
            this.atxbPlaneID._TextChanged += new System.EventHandler(this.atxbPlaneID__TextChanged);
            // 
            // atxbArrivalAirport
            // 
            this.atxbArrivalAirport.BackColor = System.Drawing.SystemColors.Window;
            this.atxbArrivalAirport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbArrivalAirport.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbArrivalAirport.BorderRadius = 0;
            this.atxbArrivalAirport.BorderSize = 2;
            this.atxbArrivalAirport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbArrivalAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbArrivalAirport.ForeColor = System.Drawing.Color.Black;
            this.atxbArrivalAirport.isPlaceholder = true;
            this.atxbArrivalAirport.Location = new System.Drawing.Point(50, 85);
            this.atxbArrivalAirport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbArrivalAirport.Multiline = false;
            this.atxbArrivalAirport.Name = "atxbArrivalAirport";
            this.atxbArrivalAirport.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbArrivalAirport.PasswordChar = false;
            this.atxbArrivalAirport.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbArrivalAirport.PlaceholderText = "Sân bay đến";
            this.atxbArrivalAirport.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbArrivalAirport.Size = new System.Drawing.Size(250, 35);
            this.atxbArrivalAirport.TabIndex = 13;
            this.atxbArrivalAirport.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbArrivalAirport.Texts = "";
            this.atxbArrivalAirport.UnderlinedStyle = false;
            // 
            // atxbDepartureAirport
            // 
            this.atxbDepartureAirport.BackColor = System.Drawing.SystemColors.Window;
            this.atxbDepartureAirport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbDepartureAirport.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbDepartureAirport.BorderRadius = 0;
            this.atxbDepartureAirport.BorderSize = 2;
            this.atxbDepartureAirport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbDepartureAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbDepartureAirport.ForeColor = System.Drawing.Color.Black;
            this.atxbDepartureAirport.isPlaceholder = true;
            this.atxbDepartureAirport.Location = new System.Drawing.Point(50, 25);
            this.atxbDepartureAirport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbDepartureAirport.Multiline = false;
            this.atxbDepartureAirport.Name = "atxbDepartureAirport";
            this.atxbDepartureAirport.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbDepartureAirport.PasswordChar = false;
            this.atxbDepartureAirport.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbDepartureAirport.PlaceholderText = "Sân bay đi";
            this.atxbDepartureAirport.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbDepartureAirport.Size = new System.Drawing.Size(250, 35);
            this.atxbDepartureAirport.TabIndex = 12;
            this.atxbDepartureAirport.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbDepartureAirport.Texts = "";
            this.atxbDepartureAirport.UnderlinedStyle = false;
            // 
            // abtnCreateFlight
            // 
            this.abtnCreateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlight.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnCreateFlight.BorderRadius = 20;
            this.abtnCreateFlight.BorderSize = 0;
            this.abtnCreateFlight.FlatAppearance.BorderSize = 0;
            this.abtnCreateFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCreateFlight.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCreateFlight.ForeColor = System.Drawing.Color.White;
            this.abtnCreateFlight.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCreateFlight.Location = new System.Drawing.Point(50, 590);
            this.abtnCreateFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnCreateFlight.Name = "abtnCreateFlight";
            this.abtnCreateFlight.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnCreateFlight.Size = new System.Drawing.Size(250, 50);
            this.abtnCreateFlight.TabIndex = 11;
            this.abtnCreateFlight.Text = "Tạo chuyến bay";
            this.abtnCreateFlight.TextColor = System.Drawing.Color.White;
            this.abtnCreateFlight.ThinknessLine = 0;
            this.abtnCreateFlight.UseVisualStyleBackColor = false;
            this.abtnCreateFlight.Click += new System.EventHandler(this.abtnCreateFlight_Click);
            // 
            // atxbTicketPrice
            // 
            this.atxbTicketPrice.BackColor = System.Drawing.SystemColors.Window;
            this.atxbTicketPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbTicketPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbTicketPrice.BorderRadius = 0;
            this.atxbTicketPrice.BorderSize = 2;
            this.atxbTicketPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbTicketPrice.ForeColor = System.Drawing.Color.Black;
            this.atxbTicketPrice.isPlaceholder = true;
            this.atxbTicketPrice.Location = new System.Drawing.Point(50, 385);
            this.atxbTicketPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbTicketPrice.Multiline = false;
            this.atxbTicketPrice.Name = "atxbTicketPrice";
            this.atxbTicketPrice.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbTicketPrice.PasswordChar = false;
            this.atxbTicketPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbTicketPrice.PlaceholderText = "Giá tiền";
            this.atxbTicketPrice.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbTicketPrice.Size = new System.Drawing.Size(250, 35);
            this.atxbTicketPrice.TabIndex = 10;
            this.atxbTicketPrice.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbTicketPrice.Texts = "";
            this.atxbTicketPrice.UnderlinedStyle = false;
            // 
            // atxbFlightDuration
            // 
            this.atxbFlightDuration.BackColor = System.Drawing.SystemColors.Window;
            this.atxbFlightDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbFlightDuration.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbFlightDuration.BorderRadius = 0;
            this.atxbFlightDuration.BorderSize = 2;
            this.atxbFlightDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbFlightDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbFlightDuration.ForeColor = System.Drawing.Color.Black;
            this.atxbFlightDuration.isPlaceholder = true;
            this.atxbFlightDuration.Location = new System.Drawing.Point(50, 325);
            this.atxbFlightDuration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbFlightDuration.Multiline = false;
            this.atxbFlightDuration.Name = "atxbFlightDuration";
            this.atxbFlightDuration.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbFlightDuration.PasswordChar = false;
            this.atxbFlightDuration.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbFlightDuration.PlaceholderText = "Thời gian bay (phút)";
            this.atxbFlightDuration.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbFlightDuration.Size = new System.Drawing.Size(250, 35);
            this.atxbFlightDuration.TabIndex = 8;
            this.atxbFlightDuration.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbFlightDuration.Texts = "";
            this.atxbFlightDuration.UnderlinedStyle = false;
            // 
            // adtpDepartureDateTime
            // 
            this.adtpDepartureDateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.adtpDepartureDateTime.BorderSize = 2;
            this.adtpDepartureDateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adtpDepartureDateTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.adtpDepartureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adtpDepartureDateTime.Location = new System.Drawing.Point(50, 205);
            this.adtpDepartureDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adtpDepartureDateTime.MinimumSize = new System.Drawing.Size(4, 35);
            this.adtpDepartureDateTime.Name = "adtpDepartureDateTime";
            this.adtpDepartureDateTime.Size = new System.Drawing.Size(250, 35);
            this.adtpDepartureDateTime.SkinColor = System.Drawing.Color.White;
            this.adtpDepartureDateTime.TabIndex = 4;
            this.adtpDepartureDateTime.TextColor = System.Drawing.Color.Black;
            // 
            // OperationFlightUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.atxbMinute);
            this.Controls.Add(this.atxbHour);
            this.Controls.Add(this.aButton3);
            this.Controls.Add(this.aButton2);
            this.Controls.Add(this.atxbPlaneID);
            this.Controls.Add(this.atxbArrivalAirport);
            this.Controls.Add(this.atxbDepartureAirport);
            this.Controls.Add(this.abtnCreateFlight);
            this.Controls.Add(this.atxbTicketPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.atxbFlightDuration);
            this.Controls.Add(this.pnTicketClassDetail);
            this.Controls.Add(this.adtpDepartureDateTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OperationFlightUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.Load += new System.EventHandler(this.OperationFlightUC_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private AControls.ADateTimePicker adtpDepartureDateTime;
        private Panel pnTicketClassDetail;
        private AControls.ATextboxUC atxbFlightDuration;
        private AControls.ATextboxUC atxbTicketPrice;
        private AControls.AButton abtnCreateFlight;
        private Panel panel1;
        private AControls.ATextboxUC atxbDepartureAirport;
        private AControls.ATextboxUC atxbArrivalAirport;
        private AControls.ATextboxUC atxbPlaneID;
        private AControls.AButton aButton2;
        private AControls.AButton aButton3;
        private AControls.ATextboxUC atxbHour;
        private AControls.ATextboxUC atxbMinute;
    }
}
