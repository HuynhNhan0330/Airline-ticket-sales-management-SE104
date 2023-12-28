using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class OperationPlaneUC
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
            this.pnTicketClass = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReloadSeat = new System.Windows.Forms.Label();
            this.pnCurrentTicketClass = new System.Windows.Forms.Panel();
            this.lbTextTicketClass = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnTicketClassDetail = new System.Windows.Forms.Panel();
            this.pnEdit = new System.Windows.Forms.Panel();
            this.abtnCancel = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnUpdatePlane = new Airline_ticket_sales_management.AControls.AButton();
            this.atbSeatCount = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.abtnCreatePlane = new Airline_ticket_sales_management.AControls.AButton();
            this.aPanel1 = new Airline_ticket_sales_management.AControls.APanel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnSeat = new System.Windows.Forms.Panel();
            this.atbPlaneName = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.label9 = new System.Windows.Forms.Label();
            this.pnCurrentTicketClass.SuspendLayout();
            this.pnEdit.SuspendLayout();
            this.aPanel1.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTicketClass
            // 
            this.pnTicketClass.AutoScroll = true;
            this.pnTicketClass.Location = new System.Drawing.Point(300, 64);
            this.pnTicketClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTicketClass.Name = "pnTicketClass";
            this.pnTicketClass.Size = new System.Drawing.Size(230, 486);
            this.pnTicketClass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hạng vé";
            // 
            // lbReloadSeat
            // 
            this.lbReloadSeat.AutoSize = true;
            this.lbReloadSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbReloadSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbReloadSeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.lbReloadSeat.Location = new System.Drawing.Point(110, 180);
            this.lbReloadSeat.Name = "lbReloadSeat";
            this.lbReloadSeat.Size = new System.Drawing.Size(144, 17);
            this.lbReloadSeat.TabIndex = 6;
            this.lbReloadSeat.Text = "Tải lại danh sách ghế";
            this.lbReloadSeat.Click += new System.EventHandler(this.lbReloadSeat_Click);
            // 
            // pnCurrentTicketClass
            // 
            this.pnCurrentTicketClass.AutoScroll = true;
            this.pnCurrentTicketClass.BackColor = System.Drawing.Color.Gray;
            this.pnCurrentTicketClass.Controls.Add(this.lbTextTicketClass);
            this.pnCurrentTicketClass.Location = new System.Drawing.Point(300, 590);
            this.pnCurrentTicketClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCurrentTicketClass.Name = "pnCurrentTicketClass";
            this.pnCurrentTicketClass.Size = new System.Drawing.Size(230, 50);
            this.pnCurrentTicketClass.TabIndex = 7;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.label8.Location = new System.Drawing.Point(50, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Chi tiết hạng vé";
            // 
            // pnTicketClassDetail
            // 
            this.pnTicketClassDetail.Location = new System.Drawing.Point(50, 270);
            this.pnTicketClassDetail.Name = "pnTicketClassDetail";
            this.pnTicketClassDetail.Size = new System.Drawing.Size(200, 280);
            this.pnTicketClassDetail.TabIndex = 9;
            // 
            // pnEdit
            // 
            this.pnEdit.Controls.Add(this.abtnCancel);
            this.pnEdit.Controls.Add(this.abtnUpdatePlane);
            this.pnEdit.Location = new System.Drawing.Point(50, 590);
            this.pnEdit.Name = "pnEdit";
            this.pnEdit.Size = new System.Drawing.Size(200, 50);
            this.pnEdit.TabIndex = 10;
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
            this.abtnCancel.ForeColor = System.Drawing.Color.White;
            this.abtnCancel.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCancel.Location = new System.Drawing.Point(110, 0);
            this.abtnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnCancel.Name = "abtnCancel";
            this.abtnCancel.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnCancel.Size = new System.Drawing.Size(90, 50);
            this.abtnCancel.TabIndex = 11;
            this.abtnCancel.Text = "Huỷ";
            this.abtnCancel.TextColor = System.Drawing.Color.White;
            this.abtnCancel.ThinknessLine = 0;
            this.abtnCancel.UseVisualStyleBackColor = false;
            this.abtnCancel.Click += new System.EventHandler(this.abtnCancel_Click);
            // 
            // abtnUpdatePlane
            // 
            this.abtnUpdatePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnUpdatePlane.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnUpdatePlane.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnUpdatePlane.BorderRadius = 15;
            this.abtnUpdatePlane.BorderSize = 0;
            this.abtnUpdatePlane.FlatAppearance.BorderSize = 0;
            this.abtnUpdatePlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnUpdatePlane.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnUpdatePlane.ForeColor = System.Drawing.Color.White;
            this.abtnUpdatePlane.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnUpdatePlane.Location = new System.Drawing.Point(0, 0);
            this.abtnUpdatePlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnUpdatePlane.Name = "abtnUpdatePlane";
            this.abtnUpdatePlane.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnUpdatePlane.Size = new System.Drawing.Size(90, 50);
            this.abtnUpdatePlane.TabIndex = 10;
            this.abtnUpdatePlane.Text = "Lưu";
            this.abtnUpdatePlane.TextColor = System.Drawing.Color.White;
            this.abtnUpdatePlane.ThinknessLine = 0;
            this.abtnUpdatePlane.UseVisualStyleBackColor = false;
            this.abtnUpdatePlane.Click += new System.EventHandler(this.abtnUpdatePlane_Click);
            // 
            // atbSeatCount
            // 
            this.atbSeatCount.BackColor = System.Drawing.Color.White;
            this.atbSeatCount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atbSeatCount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atbSeatCount.BorderRadius = 5;
            this.atbSeatCount.BorderSize = 2;
            this.atbSeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atbSeatCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.atbSeatCount.isFocused = false;
            this.atbSeatCount.isPlaceholder = true;
            this.atbSeatCount.Location = new System.Drawing.Point(50, 130);
            this.atbSeatCount.Margin = new System.Windows.Forms.Padding(4);
            this.atbSeatCount.Multiline = false;
            this.atbSeatCount.Name = "atbSeatCount";
            this.atbSeatCount.Padding = new System.Windows.Forms.Padding(7);
            this.atbSeatCount.PasswordChar = false;
            this.atbSeatCount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atbSeatCount.PlaceholderText = "Số lượng ghế";
            this.atbSeatCount.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atbSeatCount.Size = new System.Drawing.Size(200, 37);
            this.atbSeatCount.TabIndex = 5;
            this.atbSeatCount.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atbSeatCount.Texts = "";
            this.atbSeatCount.UnderlinedStyle = false;
            this.atbSeatCount._KeyDown += new System.EventHandler(this.atbSeatCount__KeyDown);
            // 
            // abtnCreatePlane
            // 
            this.abtnCreatePlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreatePlane.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreatePlane.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnCreatePlane.BorderRadius = 20;
            this.abtnCreatePlane.BorderSize = 0;
            this.abtnCreatePlane.FlatAppearance.BorderSize = 0;
            this.abtnCreatePlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCreatePlane.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCreatePlane.ForeColor = System.Drawing.Color.White;
            this.abtnCreatePlane.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCreatePlane.Location = new System.Drawing.Point(50, 590);
            this.abtnCreatePlane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnCreatePlane.Name = "abtnCreatePlane";
            this.abtnCreatePlane.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnCreatePlane.Size = new System.Drawing.Size(200, 50);
            this.abtnCreatePlane.TabIndex = 4;
            this.abtnCreatePlane.Text = "Tạo máy bay";
            this.abtnCreatePlane.TextColor = System.Drawing.Color.White;
            this.abtnCreatePlane.ThinknessLine = 0;
            this.abtnCreatePlane.UseVisualStyleBackColor = false;
            this.abtnCreatePlane.Click += new System.EventHandler(this.abtnCreatePlane_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.Transparent;
            this.aPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.aPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.aPanel1.BorderRadius = 30;
            this.aPanel1.BorderSize = 5;
            this.aPanel1.Controls.Add(this.pnHeader);
            this.aPanel1.Controls.Add(this.pnSeat);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(580, 25);
            this.aPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Top;
            this.aPanel1.Size = new System.Drawing.Size(870, 615);
            this.aPanel1.TabIndex = 1;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.Controls.Add(this.panel7);
            this.pnHeader.Controls.Add(this.panel6);
            this.pnHeader.Controls.Add(this.panel5);
            this.pnHeader.Controls.Add(this.panel4);
            this.pnHeader.Controls.Add(this.panel2);
            this.pnHeader.Controls.Add(this.panel3);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(125, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 32);
            this.panel2.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 32);
            this.panel3.TabIndex = 0;
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
            this.pnSeat.Size = new System.Drawing.Size(820, 560);
            this.pnSeat.TabIndex = 0;
            // 
            // atbPlaneName
            // 
            this.atbPlaneName.BackColor = System.Drawing.Color.White;
            this.atbPlaneName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atbPlaneName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atbPlaneName.BorderRadius = 5;
            this.atbPlaneName.BorderSize = 2;
            this.atbPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atbPlaneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.atbPlaneName.isFocused = false;
            this.atbPlaneName.isPlaceholder = true;
            this.atbPlaneName.Location = new System.Drawing.Point(50, 64);
            this.atbPlaneName.Margin = new System.Windows.Forms.Padding(4);
            this.atbPlaneName.Multiline = false;
            this.atbPlaneName.Name = "atbPlaneName";
            this.atbPlaneName.Padding = new System.Windows.Forms.Padding(7);
            this.atbPlaneName.PasswordChar = false;
            this.atbPlaneName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atbPlaneName.PlaceholderText = "Tên máy bay";
            this.atbPlaneName.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atbPlaneName.Size = new System.Drawing.Size(200, 37);
            this.atbPlaneName.TabIndex = 0;
            this.atbPlaneName.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atbPlaneName.Texts = "";
            this.atbPlaneName.UnderlinedStyle = false;
            this.atbPlaneName._KeyDown += new System.EventHandler(this.atbPlaneName__KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(30, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Thông tin máy bay";
            // 
            // OperationPlaneUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnEdit);
            this.Controls.Add(this.pnTicketClassDetail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnCurrentTicketClass);
            this.Controls.Add(this.lbReloadSeat);
            this.Controls.Add(this.atbSeatCount);
            this.Controls.Add(this.abtnCreatePlane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnTicketClass);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.atbPlaneName);
            this.Name = "OperationPlaneUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.Load += new System.EventHandler(this.OperationPlaneUC_Load);
            this.pnCurrentTicketClass.ResumeLayout(false);
            this.pnCurrentTicketClass.PerformLayout();
            this.pnEdit.ResumeLayout(false);
            this.aPanel1.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC atbPlaneName;
        private AControls.APanel aPanel1;
        private Panel pnSeat;
        private Panel pnTicketClass;
        private Label label1;
        private AControls.AButton abtnCreatePlane;
        private Panel pnHeader;
        private Panel panel7;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private AControls.ATextboxUC atbSeatCount;
        private Label lbReloadSeat;
        private Panel pnCurrentTicketClass;
        private Label lbTextTicketClass;
        private Label label8;
        private Panel pnTicketClassDetail;
        private Panel pnEdit;
        private AControls.AButton abtnCancel;
        private AControls.AButton abtnUpdatePlane;
        private Label label9;
    }
}
