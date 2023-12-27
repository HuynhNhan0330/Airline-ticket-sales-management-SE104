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
            this.pnPreventiveAirport = new System.Windows.Forms.Panel();
            this.atxbMinute = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbHour = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.abtnRemovePreventiveAirport = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnAddPreventiveAirport = new Airline_ticket_sales_management.AControls.AButton();
            this.atxbPlaneID = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbArrivalAirport = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbDepartureAirport = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.abtnCreateFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.atxbTicketPrice = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbFlightDuration = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.adtpDepartureDateTime = new Airline_ticket_sales_management.AControls.ADateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.abtnCancel = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnUpdateFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnEdit.SuspendLayout();
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
            // pnPreventiveAirport
            // 
            this.pnPreventiveAirport.BackColor = System.Drawing.Color.Transparent;
            this.pnPreventiveAirport.Location = new System.Drawing.Point(600, 145);
            this.pnPreventiveAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPreventiveAirport.Name = "pnPreventiveAirport";
            this.pnPreventiveAirport.Size = new System.Drawing.Size(850, 482);
            this.pnPreventiveAirport.TabIndex = 9;
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
            this.atxbMinute.isFocused = false;
            this.atxbMinute.isPlaceholder = true;
            this.atxbMinute.Location = new System.Drawing.Point(200, 335);
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
            this.atxbMinute._KeyDown += new System.EventHandler(this.KeyDownOnlyNumber);
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
            this.atxbHour.isFocused = false;
            this.atxbHour.isPlaceholder = true;
            this.atxbHour.Location = new System.Drawing.Point(50, 335);
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
            this.atxbHour._KeyDown += new System.EventHandler(this.KeyDownOnlyNumber);
            // 
            // abtnRemovePreventiveAirport
            // 
            this.abtnRemovePreventiveAirport.BackColor = System.Drawing.Color.Gray;
            this.abtnRemovePreventiveAirport.BackgroundColor = System.Drawing.Color.Gray;
            this.abtnRemovePreventiveAirport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnRemovePreventiveAirport.BorderRadius = 15;
            this.abtnRemovePreventiveAirport.BorderSize = 0;
            this.abtnRemovePreventiveAirport.FlatAppearance.BorderSize = 0;
            this.abtnRemovePreventiveAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnRemovePreventiveAirport.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnRemovePreventiveAirport.ForeColor = System.Drawing.Color.White;
            this.abtnRemovePreventiveAirport.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnRemovePreventiveAirport.Location = new System.Drawing.Point(725, 25);
            this.abtnRemovePreventiveAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnRemovePreventiveAirport.Name = "abtnRemovePreventiveAirport";
            this.abtnRemovePreventiveAirport.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnRemovePreventiveAirport.Size = new System.Drawing.Size(100, 50);
            this.abtnRemovePreventiveAirport.TabIndex = 16;
            this.abtnRemovePreventiveAirport.Text = "-";
            this.abtnRemovePreventiveAirport.TextColor = System.Drawing.Color.White;
            this.abtnRemovePreventiveAirport.ThinknessLine = 0;
            this.abtnRemovePreventiveAirport.UseVisualStyleBackColor = false;
            this.abtnRemovePreventiveAirport.Click += new System.EventHandler(this.abtnRemovePreventiveAirport_Click);
            // 
            // abtnAddPreventiveAirport
            // 
            this.abtnAddPreventiveAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnAddPreventiveAirport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnAddPreventiveAirport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnAddPreventiveAirport.BorderRadius = 15;
            this.abtnAddPreventiveAirport.BorderSize = 0;
            this.abtnAddPreventiveAirport.FlatAppearance.BorderSize = 0;
            this.abtnAddPreventiveAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnAddPreventiveAirport.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnAddPreventiveAirport.ForeColor = System.Drawing.Color.White;
            this.abtnAddPreventiveAirport.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnAddPreventiveAirport.Location = new System.Drawing.Point(600, 25);
            this.abtnAddPreventiveAirport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnAddPreventiveAirport.Name = "abtnAddPreventiveAirport";
            this.abtnAddPreventiveAirport.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnAddPreventiveAirport.Size = new System.Drawing.Size(100, 50);
            this.abtnAddPreventiveAirport.TabIndex = 15;
            this.abtnAddPreventiveAirport.Text = "+";
            this.abtnAddPreventiveAirport.TextColor = System.Drawing.Color.White;
            this.abtnAddPreventiveAirport.ThinknessLine = 0;
            this.abtnAddPreventiveAirport.UseVisualStyleBackColor = false;
            this.abtnAddPreventiveAirport.Click += new System.EventHandler(this.abtnAddPreventiveAirport_Click);
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
            this.atxbPlaneID.isFocused = false;
            this.atxbPlaneID.isPlaceholder = true;
            this.atxbPlaneID.Location = new System.Drawing.Point(50, 215);
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
            this.atxbArrivalAirport.isFocused = false;
            this.atxbArrivalAirport.isPlaceholder = true;
            this.atxbArrivalAirport.Location = new System.Drawing.Point(50, 155);
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
            this.atxbDepartureAirport.isFocused = false;
            this.atxbDepartureAirport.isPlaceholder = true;
            this.atxbDepartureAirport.Location = new System.Drawing.Point(50, 95);
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
            this.atxbTicketPrice.isFocused = false;
            this.atxbTicketPrice.isPlaceholder = true;
            this.atxbTicketPrice.Location = new System.Drawing.Point(50, 455);
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
            this.atxbTicketPrice._KeyDown += new System.EventHandler(this.KeyDownOnlyNumber);
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
            this.atxbFlightDuration.isFocused = false;
            this.atxbFlightDuration.isPlaceholder = true;
            this.atxbFlightDuration.Location = new System.Drawing.Point(50, 395);
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
            this.atxbFlightDuration._KeyDown += new System.EventHandler(this.KeyDownOnlyNumber);
            // 
            // adtpDepartureDateTime
            // 
            this.adtpDepartureDateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.adtpDepartureDateTime.BorderSize = 2;
            this.adtpDepartureDateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adtpDepartureDateTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.adtpDepartureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.adtpDepartureDateTime.Location = new System.Drawing.Point(50, 275);
            this.adtpDepartureDateTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adtpDepartureDateTime.MinimumSize = new System.Drawing.Size(4, 35);
            this.adtpDepartureDateTime.Name = "adtpDepartureDateTime";
            this.adtpDepartureDateTime.Size = new System.Drawing.Size(250, 35);
            this.adtpDepartureDateTime.SkinColor = System.Drawing.Color.White;
            this.adtpDepartureDateTime.TabIndex = 4;
            this.adtpDepartureDateTime.TextColor = System.Drawing.Color.Black;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(600, 100);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 40);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "STT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(605, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thời gian dừng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label10.Location = new System.Drawing.Point(140, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tên sân bay";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(922, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(243, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "Sân bay trung gian";
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.abtnCancel);
            this.pnEdit.Controls.Add(this.abtnUpdateFlight);
            this.pnEdit.Location = new System.Drawing.Point(50, 590);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(250, 50);
            this.pnEdit.TabIndex = 21;
            // 
            // abtnCancel
            // 
            this.abtnCancel.BackColor = System.Drawing.Color.Gray;
            this.abtnCancel.BackgroundColor = System.Drawing.Color.Gray;
            this.abtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnCancel.BorderRadius = 15;
            this.abtnCancel.BorderSize = 0;
            this.abtnCancel.FlatAppearance.BorderSize = 0;
            this.abtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.abtnCancel.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCancel.Location = new System.Drawing.Point(140, 0);
            this.abtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnCancel.Name = "abtnCancel";
            this.abtnCancel.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnCancel.Size = new System.Drawing.Size(110, 50);
            this.abtnCancel.TabIndex = 11;
            this.abtnCancel.Text = "Huỷ";
            this.abtnCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.abtnCancel.ThinknessLine = 0;
            this.abtnCancel.UseVisualStyleBackColor = false;
            this.abtnCancel.Click += new System.EventHandler(this.abtnCancel_Click);
            // 
            // abtnUpdateFlight
            // 
            this.abtnUpdateFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnUpdateFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnUpdateFlight.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnUpdateFlight.BorderRadius = 15;
            this.abtnUpdateFlight.BorderSize = 0;
            this.abtnUpdateFlight.FlatAppearance.BorderSize = 0;
            this.abtnUpdateFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnUpdateFlight.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnUpdateFlight.ForeColor = System.Drawing.Color.White;
            this.abtnUpdateFlight.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnUpdateFlight.Location = new System.Drawing.Point(0, 0);
            this.abtnUpdateFlight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnUpdateFlight.Name = "abtnUpdateFlight";
            this.abtnUpdateFlight.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnUpdateFlight.Size = new System.Drawing.Size(110, 50);
            this.abtnUpdateFlight.TabIndex = 10;
            this.abtnUpdateFlight.Text = "Lưu";
            this.abtnUpdateFlight.TextColor = System.Drawing.Color.White;
            this.abtnUpdateFlight.ThinknessLine = 0;
            this.abtnUpdateFlight.UseVisualStyleBackColor = false;
            this.abtnUpdateFlight.Click += new System.EventHandler(this.abtnUpdateFlight_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Thông tin chuyến bay";
            // 
            // OperationFlightUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnEdit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.atxbMinute);
            this.Controls.Add(this.atxbHour);
            this.Controls.Add(this.abtnRemovePreventiveAirport);
            this.Controls.Add(this.abtnAddPreventiveAirport);
            this.Controls.Add(this.atxbPlaneID);
            this.Controls.Add(this.atxbArrivalAirport);
            this.Controls.Add(this.atxbDepartureAirport);
            this.Controls.Add(this.abtnCreateFlight);
            this.Controls.Add(this.atxbTicketPrice);
            this.Controls.Add(this.pnPreventiveAirport);
            this.Controls.Add(this.atxbFlightDuration);
            this.Controls.Add(this.pnTicketClassDetail);
            this.Controls.Add(this.adtpDepartureDateTime);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OperationFlightUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.Load += new System.EventHandler(this.OperationFlightUC_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AControls.ADateTimePicker adtpDepartureDateTime;
        private Panel pnTicketClassDetail;
        private AControls.ATextboxUC atxbFlightDuration;
        private AControls.ATextboxUC atxbTicketPrice;
        private AControls.AButton abtnCreateFlight;
        private Panel pnPreventiveAirport;
        private AControls.ATextboxUC atxbDepartureAirport;
        private AControls.ATextboxUC atxbArrivalAirport;
        private AControls.ATextboxUC atxbPlaneID;
        private AControls.AButton abtnAddPreventiveAirport;
        private AControls.AButton abtnRemovePreventiveAirport;
        private AControls.ATextboxUC atxbHour;
        private AControls.ATextboxUC atxbMinute;
        private Panel panel2;
        private Label label10;
        private Label label14;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel pnEdit;
        private AControls.AButton abtnCancel;
        private AControls.AButton abtnUpdateFlight;
        private Label label4;
    }
}
