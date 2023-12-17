using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class CreateFlightTicketUC
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
            this.label8 = new System.Windows.Forms.Label();
            this.pnTicketClass = new System.Windows.Forms.Panel();
            this.pnCurrentTicketClass = new System.Windows.Forms.Panel();
            this.lbTextTicketClass = new System.Windows.Forms.Label();
            this.abtnCreateFlightTicket = new Airline_ticket_sales_management.AControls.AButton();
            this.aPanel3 = new Airline_ticket_sales_management.AControls.APanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnSeat = new System.Windows.Forms.Panel();
            this.aPanel1 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbEmail = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbFullName = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbPrice = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbPhone = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbIDCard = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbFlightID = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pnCurrentTicketClass.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(95, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thông tin vé";
            // 
            // pnTicketClass
            // 
            this.pnTicketClass.AutoScroll = true;
            this.pnTicketClass.Location = new System.Drawing.Point(325, 90);
            this.pnTicketClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTicketClass.Name = "pnTicketClass";
            this.pnTicketClass.Size = new System.Drawing.Size(230, 390);
            this.pnTicketClass.TabIndex = 8;
            // 
            // pnCurrentTicketClass
            // 
            this.pnCurrentTicketClass.AutoScroll = true;
            this.pnCurrentTicketClass.BackColor = System.Drawing.Color.Gray;
            this.pnCurrentTicketClass.Controls.Add(this.lbTextTicketClass);
            this.pnCurrentTicketClass.Location = new System.Drawing.Point(325, 590);
            this.pnCurrentTicketClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCurrentTicketClass.Name = "pnCurrentTicketClass";
            this.pnCurrentTicketClass.Size = new System.Drawing.Size(230, 50);
            this.pnCurrentTicketClass.TabIndex = 9;
            // 
            // lbTextTicketClass
            // 
            this.lbTextTicketClass.AutoSize = true;
            this.lbTextTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbTextTicketClass.ForeColor = System.Drawing.Color.White;
            this.lbTextTicketClass.Location = new System.Drawing.Point(40, 15);
            this.lbTextTicketClass.Name = "lbTextTicketClass";
            this.lbTextTicketClass.Size = new System.Drawing.Size(146, 22);
            this.lbTextTicketClass.TabIndex = 0;
            this.lbTextTicketClass.Text = "Chưa có hạng vé";
            // 
            // abtnCreateFlightTicket
            // 
            this.abtnCreateFlightTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlightTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlightTicket.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnCreateFlightTicket.BorderRadius = 15;
            this.abtnCreateFlightTicket.BorderSize = 0;
            this.abtnCreateFlightTicket.FlatAppearance.BorderSize = 0;
            this.abtnCreateFlightTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCreateFlightTicket.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCreateFlightTicket.ForeColor = System.Drawing.Color.White;
            this.abtnCreateFlightTicket.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCreateFlightTicket.Location = new System.Drawing.Point(50, 590);
            this.abtnCreateFlightTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnCreateFlightTicket.Name = "abtnCreateFlightTicket";
            this.abtnCreateFlightTicket.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnCreateFlightTicket.Size = new System.Drawing.Size(250, 50);
            this.abtnCreateFlightTicket.TabIndex = 6;
            this.abtnCreateFlightTicket.Text = "Tạo vé";
            this.abtnCreateFlightTicket.TextColor = System.Drawing.Color.White;
            this.abtnCreateFlightTicket.ThinknessLine = 0;
            this.abtnCreateFlightTicket.UseVisualStyleBackColor = false;
            this.abtnCreateFlightTicket.Click += new System.EventHandler(this.abtnCreateFlightTicket_Click);
            // 
            // aPanel3
            // 
            this.aPanel3.BackColor = System.Drawing.Color.Transparent;
            this.aPanel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.aPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.aPanel3.BorderRadius = 30;
            this.aPanel3.BorderSize = 5;
            this.aPanel3.Controls.Add(this.pnHeader);
            this.aPanel3.Controls.Add(this.pnSeat);
            this.aPanel3.ForeColor = System.Drawing.Color.White;
            this.aPanel3.Location = new System.Drawing.Point(580, 92);
            this.aPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aPanel3.Name = "aPanel3";
            this.aPanel3.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Top;
            this.aPanel3.Size = new System.Drawing.Size(870, 460);
            this.aPanel3.TabIndex = 4;
            this.aPanel3.TextColor = System.Drawing.Color.White;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.panel7);
            this.pnHeader.Controls.Add(this.panel6);
            this.pnHeader.Controls.Add(this.panel5);
            this.pnHeader.Controls.Add(this.panel4);
            this.pnHeader.Controls.Add(this.panel3);
            this.pnHeader.Controls.Add(this.panel8);
            this.pnHeader.Location = new System.Drawing.Point(25, 7);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(820, 32);
            this.pnHeader.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(700, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 32);
            this.panel7.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(40, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "6";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(575, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 32);
            this.panel6.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(40, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "5";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(450, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 32);
            this.panel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "4";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 32);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "3";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(125, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 32);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "2";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 32);
            this.panel8.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "1";
            // 
            // pnSeat
            // 
            this.pnSeat.AutoScroll = true;
            this.pnSeat.Location = new System.Drawing.Point(25, 40);
            this.pnSeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSeat.Name = "pnSeat";
            this.pnSeat.Size = new System.Drawing.Size(820, 410);
            this.pnSeat.TabIndex = 0;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BackgroundColor = System.Drawing.Color.White;
            this.aPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.aPanel1.BorderRadius = 30;
            this.aPanel1.BorderSize = 2;
            this.aPanel1.Controls.Add(this.atxbEmail);
            this.aPanel1.Controls.Add(this.atxbFullName);
            this.aPanel1.Controls.Add(this.atxbPrice);
            this.aPanel1.Controls.Add(this.atxbPhone);
            this.aPanel1.Controls.Add(this.atxbIDCard);
            this.aPanel1.Controls.Add(this.atxbFlightID);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 90);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(250, 390);
            this.aPanel1.TabIndex = 2;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // atxbEmail
            // 
            this.atxbEmail.BackColor = System.Drawing.Color.White;
            this.atxbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbEmail.BorderRadius = 8;
            this.atxbEmail.BorderSize = 2;
            this.atxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbEmail.ForeColor = System.Drawing.Color.Black;
            this.atxbEmail.isFocused = false;
            this.atxbEmail.isPlaceholder = true;
            this.atxbEmail.Location = new System.Drawing.Point(25, 325);
            this.atxbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbEmail.Multiline = false;
            this.atxbEmail.Name = "atxbEmail";
            this.atxbEmail.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbEmail.PasswordChar = false;
            this.atxbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbEmail.PlaceholderText = "Email";
            this.atxbEmail.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbEmail.Size = new System.Drawing.Size(200, 35);
            this.atxbEmail.TabIndex = 7;
            this.atxbEmail.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbEmail.Texts = "";
            this.atxbEmail.UnderlinedStyle = false;
            // 
            // atxbFullName
            // 
            this.atxbFullName.BackColor = System.Drawing.Color.White;
            this.atxbFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbFullName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbFullName.BorderRadius = 8;
            this.atxbFullName.BorderSize = 2;
            this.atxbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbFullName.ForeColor = System.Drawing.Color.Black;
            this.atxbFullName.isFocused = false;
            this.atxbFullName.isPlaceholder = true;
            this.atxbFullName.Location = new System.Drawing.Point(25, 145);
            this.atxbFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbFullName.Multiline = false;
            this.atxbFullName.Name = "atxbFullName";
            this.atxbFullName.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbFullName.PasswordChar = false;
            this.atxbFullName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbFullName.PlaceholderText = "Họ và tên";
            this.atxbFullName.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbFullName.Size = new System.Drawing.Size(200, 35);
            this.atxbFullName.TabIndex = 4;
            this.atxbFullName.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbFullName.Texts = "";
            this.atxbFullName.UnderlinedStyle = false;
            // 
            // atxbPrice
            // 
            this.atxbPrice.BackColor = System.Drawing.Color.White;
            this.atxbPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbPrice.BorderRadius = 8;
            this.atxbPrice.BorderSize = 2;
            this.atxbPrice.Enabled = false;
            this.atxbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbPrice.ForeColor = System.Drawing.Color.Black;
            this.atxbPrice.isFocused = false;
            this.atxbPrice.isPlaceholder = true;
            this.atxbPrice.Location = new System.Drawing.Point(25, 85);
            this.atxbPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPrice.Multiline = false;
            this.atxbPrice.Name = "atxbPrice";
            this.atxbPrice.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPrice.PasswordChar = false;
            this.atxbPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPrice.PlaceholderText = "Giá tiền";
            this.atxbPrice.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPrice.Size = new System.Drawing.Size(200, 35);
            this.atxbPrice.TabIndex = 2;
            this.atxbPrice.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPrice.Texts = "";
            this.atxbPrice.UnderlinedStyle = false;
            // 
            // atxbPhone
            // 
            this.atxbPhone.BackColor = System.Drawing.Color.White;
            this.atxbPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbPhone.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbPhone.BorderRadius = 8;
            this.atxbPhone.BorderSize = 2;
            this.atxbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbPhone.ForeColor = System.Drawing.Color.Black;
            this.atxbPhone.isFocused = false;
            this.atxbPhone.isPlaceholder = true;
            this.atxbPhone.Location = new System.Drawing.Point(25, 265);
            this.atxbPhone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPhone.Multiline = false;
            this.atxbPhone.Name = "atxbPhone";
            this.atxbPhone.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPhone.PasswordChar = false;
            this.atxbPhone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPhone.PlaceholderText = "Số điện thoại";
            this.atxbPhone.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPhone.Size = new System.Drawing.Size(200, 35);
            this.atxbPhone.TabIndex = 6;
            this.atxbPhone.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPhone.Texts = "";
            this.atxbPhone.UnderlinedStyle = false;
            this.atxbPhone._KeyDown += new System.EventHandler(this.KeyDownOnlyNumber);
            // 
            // atxbIDCard
            // 
            this.atxbIDCard.BackColor = System.Drawing.Color.White;
            this.atxbIDCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbIDCard.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbIDCard.BorderRadius = 8;
            this.atxbIDCard.BorderSize = 2;
            this.atxbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbIDCard.ForeColor = System.Drawing.Color.Black;
            this.atxbIDCard.isFocused = false;
            this.atxbIDCard.isPlaceholder = true;
            this.atxbIDCard.Location = new System.Drawing.Point(25, 205);
            this.atxbIDCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbIDCard.Multiline = false;
            this.atxbIDCard.Name = "atxbIDCard";
            this.atxbIDCard.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbIDCard.PasswordChar = false;
            this.atxbIDCard.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbIDCard.PlaceholderText = "CMND/CCCD";
            this.atxbIDCard.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbIDCard.Size = new System.Drawing.Size(200, 35);
            this.atxbIDCard.TabIndex = 5;
            this.atxbIDCard.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbIDCard.Texts = "";
            this.atxbIDCard.UnderlinedStyle = false;
            this.atxbIDCard._KeyDown += new System.EventHandler(this.KeyDownOnlyNumber);
            // 
            // atxbFlightID
            // 
            this.atxbFlightID.BackColor = System.Drawing.Color.White;
            this.atxbFlightID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbFlightID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbFlightID.BorderRadius = 8;
            this.atxbFlightID.BorderSize = 2;
            this.atxbFlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbFlightID.ForeColor = System.Drawing.Color.Black;
            this.atxbFlightID.isFocused = false;
            this.atxbFlightID.isPlaceholder = true;
            this.atxbFlightID.Location = new System.Drawing.Point(25, 25);
            this.atxbFlightID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbFlightID.Multiline = false;
            this.atxbFlightID.Name = "atxbFlightID";
            this.atxbFlightID.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbFlightID.PasswordChar = false;
            this.atxbFlightID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbFlightID.PlaceholderText = "Mã chuyến bay";
            this.atxbFlightID.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbFlightID.Size = new System.Drawing.Size(200, 35);
            this.atxbFlightID.TabIndex = 0;
            this.atxbFlightID.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbFlightID.Texts = "";
            this.atxbFlightID.UnderlinedStyle = false;
            this.atxbFlightID._TextChanged += new System.EventHandler(this.atxbFlightID__TextChanged);
            // 
            // CreateFlightTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnCurrentTicketClass);
            this.Controls.Add(this.pnTicketClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.abtnCreateFlightTicket);
            this.Controls.Add(this.aPanel3);
            this.Controls.Add(this.aPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateFlightTicketUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.Load += new System.EventHandler(this.CreateFlightTicketUC_Load);
            this.pnCurrentTicketClass.ResumeLayout(false);
            this.pnCurrentTicketClass.PerformLayout();
            this.aPanel3.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
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
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.aPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC atxbFlightID;
        private AControls.ATextboxUC atxbPrice;
        private AControls.APanel aPanel1;
        private AControls.ATextboxUC atxbPhone;
        private AControls.ATextboxUC atxbIDCard;
        private AControls.ATextboxUC atxbFullName;
        private AControls.ATextboxUC atxbEmail;
        private AControls.APanel aPanel3;
        private Panel pnHeader;
        private Panel panel7;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel8;
        private Label label2;
        private Panel pnSeat;
        private AControls.AButton abtnCreateFlightTicket;
        private Label label8;
        private Panel pnTicketClass;
        private Panel pnCurrentTicketClass;
        private Label lbTextTicketClass;
    }
}
