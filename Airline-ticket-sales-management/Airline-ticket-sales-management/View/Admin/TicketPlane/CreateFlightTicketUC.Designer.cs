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
            this.aTextboxuc1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc2 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aPanel1 = new Airline_ticket_sales_management.AControls.APanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aTextboxuc6 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc3 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc5 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc4 = new Airline_ticket_sales_management.AControls.ATextboxUC();
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
            this.abtnCreateFlightTicket = new Airline_ticket_sales_management.AControls.AButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pnTicketClass = new System.Windows.Forms.Panel();
            this.aPanel1.SuspendLayout();
            this.aPanel3.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // aTextboxuc1
            // 
            this.aTextboxuc1.BackColor = System.Drawing.Color.White;
            this.aTextboxuc1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc1.BorderRadius = 8;
            this.aTextboxuc1.BorderSize = 2;
            this.aTextboxuc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc1.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc1.isFocused = false;
            this.aTextboxuc1.isPlaceholder = true;
            this.aTextboxuc1.Location = new System.Drawing.Point(25, 25);
            this.aTextboxuc1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc1.Multiline = false;
            this.aTextboxuc1.Name = "aTextboxuc1";
            this.aTextboxuc1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc1.PasswordChar = false;
            this.aTextboxuc1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc1.PlaceholderText = "Mã chuyến bay";
            this.aTextboxuc1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc1.Size = new System.Drawing.Size(200, 35);
            this.aTextboxuc1.TabIndex = 0;
            this.aTextboxuc1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc1.Texts = "";
            this.aTextboxuc1.UnderlinedStyle = false;
            // 
            // aTextboxuc2
            // 
            this.aTextboxuc2.BackColor = System.Drawing.Color.White;
            this.aTextboxuc2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc2.BorderRadius = 8;
            this.aTextboxuc2.BorderSize = 2;
            this.aTextboxuc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc2.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc2.isFocused = false;
            this.aTextboxuc2.isPlaceholder = true;
            this.aTextboxuc2.Location = new System.Drawing.Point(25, 140);
            this.aTextboxuc2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc2.Multiline = false;
            this.aTextboxuc2.Name = "aTextboxuc2";
            this.aTextboxuc2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc2.PasswordChar = false;
            this.aTextboxuc2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc2.PlaceholderText = "Giá tiền";
            this.aTextboxuc2.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc2.Size = new System.Drawing.Size(200, 35);
            this.aTextboxuc2.TabIndex = 2;
            this.aTextboxuc2.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc2.Texts = "";
            this.aTextboxuc2.UnderlinedStyle = false;
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.White;
            this.aPanel1.BackgroundColor = System.Drawing.Color.White;
            this.aPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.aPanel1.BorderRadius = 30;
            this.aPanel1.BorderSize = 2;
            this.aPanel1.Controls.Add(this.comboBox1);
            this.aPanel1.Controls.Add(this.aTextboxuc6);
            this.aPanel1.Controls.Add(this.aTextboxuc3);
            this.aPanel1.Controls.Add(this.aTextboxuc2);
            this.aPanel1.Controls.Add(this.aTextboxuc5);
            this.aPanel1.Controls.Add(this.aTextboxuc4);
            this.aPanel1.Controls.Add(this.aTextboxuc1);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 92);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(250, 450);
            this.aPanel1.TabIndex = 2;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 30);
            this.comboBox1.TabIndex = 8;
            // 
            // aTextboxuc6
            // 
            this.aTextboxuc6.BackColor = System.Drawing.Color.White;
            this.aTextboxuc6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc6.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc6.BorderRadius = 8;
            this.aTextboxuc6.BorderSize = 2;
            this.aTextboxuc6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc6.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc6.isFocused = false;
            this.aTextboxuc6.isPlaceholder = true;
            this.aTextboxuc6.Location = new System.Drawing.Point(25, 380);
            this.aTextboxuc6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc6.Multiline = false;
            this.aTextboxuc6.Name = "aTextboxuc6";
            this.aTextboxuc6.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc6.PasswordChar = false;
            this.aTextboxuc6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc6.PlaceholderText = "Email";
            this.aTextboxuc6.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc6.Size = new System.Drawing.Size(200, 35);
            this.aTextboxuc6.TabIndex = 7;
            this.aTextboxuc6.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc6.Texts = "";
            this.aTextboxuc6.UnderlinedStyle = false;
            // 
            // aTextboxuc3
            // 
            this.aTextboxuc3.BackColor = System.Drawing.Color.White;
            this.aTextboxuc3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc3.BorderRadius = 8;
            this.aTextboxuc3.BorderSize = 2;
            this.aTextboxuc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc3.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc3.isFocused = false;
            this.aTextboxuc3.isPlaceholder = true;
            this.aTextboxuc3.Location = new System.Drawing.Point(25, 200);
            this.aTextboxuc3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc3.Multiline = false;
            this.aTextboxuc3.Name = "aTextboxuc3";
            this.aTextboxuc3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc3.PasswordChar = false;
            this.aTextboxuc3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc3.PlaceholderText = "Họ và tên";
            this.aTextboxuc3.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc3.Size = new System.Drawing.Size(200, 35);
            this.aTextboxuc3.TabIndex = 4;
            this.aTextboxuc3.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc3.Texts = "";
            this.aTextboxuc3.UnderlinedStyle = false;
            // 
            // aTextboxuc5
            // 
            this.aTextboxuc5.BackColor = System.Drawing.Color.White;
            this.aTextboxuc5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc5.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc5.BorderRadius = 8;
            this.aTextboxuc5.BorderSize = 2;
            this.aTextboxuc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc5.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc5.isFocused = false;
            this.aTextboxuc5.isPlaceholder = true;
            this.aTextboxuc5.Location = new System.Drawing.Point(25, 320);
            this.aTextboxuc5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc5.Multiline = false;
            this.aTextboxuc5.Name = "aTextboxuc5";
            this.aTextboxuc5.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc5.PasswordChar = false;
            this.aTextboxuc5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc5.PlaceholderText = "Số điện thoại";
            this.aTextboxuc5.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc5.Size = new System.Drawing.Size(200, 35);
            this.aTextboxuc5.TabIndex = 6;
            this.aTextboxuc5.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc5.Texts = "";
            this.aTextboxuc5.UnderlinedStyle = false;
            // 
            // aTextboxuc4
            // 
            this.aTextboxuc4.BackColor = System.Drawing.Color.White;
            this.aTextboxuc4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc4.BorderRadius = 8;
            this.aTextboxuc4.BorderSize = 2;
            this.aTextboxuc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc4.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc4.isFocused = false;
            this.aTextboxuc4.isPlaceholder = true;
            this.aTextboxuc4.Location = new System.Drawing.Point(25, 260);
            this.aTextboxuc4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc4.Multiline = false;
            this.aTextboxuc4.Name = "aTextboxuc4";
            this.aTextboxuc4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc4.PasswordChar = false;
            this.aTextboxuc4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc4.PlaceholderText = "CMND/CCCD";
            this.aTextboxuc4.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc4.Size = new System.Drawing.Size(200, 35);
            this.aTextboxuc4.TabIndex = 5;
            this.aTextboxuc4.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc4.Texts = "";
            this.aTextboxuc4.UnderlinedStyle = false;
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
            this.abtnCreateFlightTicket.Location = new System.Drawing.Point(50, 600);
            this.abtnCreateFlightTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnCreateFlightTicket.Name = "abtnCreateFlightTicket";
            this.abtnCreateFlightTicket.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnCreateFlightTicket.Size = new System.Drawing.Size(250, 40);
            this.abtnCreateFlightTicket.TabIndex = 6;
            this.abtnCreateFlightTicket.Text = "Tạo vé";
            this.abtnCreateFlightTicket.TextColor = System.Drawing.Color.White;
            this.abtnCreateFlightTicket.ThinknessLine = 0;
            this.abtnCreateFlightTicket.UseVisualStyleBackColor = false;
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
            this.pnTicketClass.Location = new System.Drawing.Point(326, 92);
            this.pnTicketClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTicketClass.Name = "pnTicketClass";
            this.pnTicketClass.Size = new System.Drawing.Size(230, 450);
            this.pnTicketClass.TabIndex = 8;
            // 
            // CreateFlightTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
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
            this.aPanel1.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC aTextboxuc1;
        private AControls.ATextboxUC aTextboxuc2;
        private AControls.APanel aPanel1;
        private AControls.ATextboxUC aTextboxuc5;
        private AControls.ATextboxUC aTextboxuc4;
        private AControls.ATextboxUC aTextboxuc3;
        private AControls.ATextboxUC aTextboxuc6;
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
        private ComboBox comboBox1;
        private Label label8;
        private Panel pnTicketClass;
    }
}
