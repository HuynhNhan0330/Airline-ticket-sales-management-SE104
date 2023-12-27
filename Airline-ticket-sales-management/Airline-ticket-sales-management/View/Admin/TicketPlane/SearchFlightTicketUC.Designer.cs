using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class SearchFlightTicketUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.abtnSearch = new Airline_ticket_sales_management.AControls.AButton();
            this.atxbKey = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pnListTicket = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrice = new System.Windows.Forms.Panel();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pnClassTicketName = new System.Windows.Forms.Panel();
            this.lbClassTicketName = new System.Windows.Forms.Label();
            this.pnSeat = new System.Windows.Forms.Panel();
            this.lbSeat = new System.Windows.Forms.Label();
            this.pnEmail = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pnPhone = new System.Windows.Forms.Panel();
            this.lbPhone = new System.Windows.Forms.Label();
            this.pnCardID = new System.Windows.Forms.Panel();
            this.lbCardID = new System.Windows.Forms.Label();
            this.pnName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnFlightID = new System.Windows.Forms.Panel();
            this.lbFlightID = new System.Windows.Forms.Label();
            this.pnTicketID = new System.Windows.Forms.Panel();
            this.lbTicketID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnPrice.SuspendLayout();
            this.pnClassTicketName.SuspendLayout();
            this.pnSeat.SuspendLayout();
            this.pnEmail.SuspendLayout();
            this.pnPhone.SuspendLayout();
            this.pnCardID.SuspendLayout();
            this.pnName.SuspendLayout();
            this.pnFlightID.SuspendLayout();
            this.pnTicketID.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSearchType);
            this.panel1.Controls.Add(this.abtnSearch);
            this.panel1.Controls.Add(this.atxbKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 65);
            this.panel1.TabIndex = 3;
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Tìm kiếm theo mã vé",
            "Tìm kiếm theo mã chuyến bay"});
            this.cbSearchType.Location = new System.Drawing.Point(50, 28);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(300, 30);
            this.cbSearchType.TabIndex = 3;
            // 
            // abtnSearch
            // 
            this.abtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSearch.BorderRadius = 10;
            this.abtnSearch.BorderSize = 0;
            this.abtnSearch.FlatAppearance.BorderSize = 0;
            this.abtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnSearch.ForeColor = System.Drawing.Color.White;
            this.abtnSearch.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnSearch.Location = new System.Drawing.Point(700, 25);
            this.abtnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnSearch.Name = "abtnSearch";
            this.abtnSearch.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnSearch.Size = new System.Drawing.Size(200, 37);
            this.abtnSearch.TabIndex = 2;
            this.abtnSearch.Text = "Tìm kiếm";
            this.abtnSearch.TextColor = System.Drawing.Color.White;
            this.abtnSearch.ThinknessLine = 0;
            this.abtnSearch.UseVisualStyleBackColor = false;
            this.abtnSearch.Click += new System.EventHandler(this.abtnSearch_Click);
            // 
            // atxbKey
            // 
            this.atxbKey.BackColor = System.Drawing.SystemColors.Window;
            this.atxbKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.atxbKey.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.atxbKey.BorderRadius = 10;
            this.atxbKey.BorderSize = 2;
            this.atxbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.atxbKey.ForeColor = System.Drawing.Color.Black;
            this.atxbKey.isFocused = false;
            this.atxbKey.isPlaceholder = true;
            this.atxbKey.Location = new System.Drawing.Point(375, 25);
            this.atxbKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbKey.Multiline = false;
            this.atxbKey.Name = "atxbKey";
            this.atxbKey.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbKey.PasswordChar = false;
            this.atxbKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbKey.PlaceholderText = "Nhập từ khoá tìm kiếm";
            this.atxbKey.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbKey.Size = new System.Drawing.Size(300, 37);
            this.atxbKey.TabIndex = 1;
            this.atxbKey.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbKey.Texts = "";
            this.atxbKey.UnderlinedStyle = false;
            // 
            // pnListTicket
            // 
            this.pnListTicket.AutoScroll = true;
            this.pnListTicket.Location = new System.Drawing.Point(50, 130);
            this.pnListTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnListTicket.Name = "pnListTicket";
            this.pnListTicket.Size = new System.Drawing.Size(1400, 500);
            this.pnListTicket.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pnPrice);
            this.panel2.Controls.Add(this.pnClassTicketName);
            this.panel2.Controls.Add(this.pnSeat);
            this.panel2.Controls.Add(this.pnEmail);
            this.panel2.Controls.Add(this.pnPhone);
            this.panel2.Controls.Add(this.pnCardID);
            this.panel2.Controls.Add(this.pnName);
            this.panel2.Controls.Add(this.pnFlightID);
            this.panel2.Controls.Add(this.pnTicketID);
            this.panel2.Location = new System.Drawing.Point(50, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 50);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1286, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 50);
            this.panel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.MaximumSize = new System.Drawing.Size(180, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thao tác";
            // 
            // pnPrice
            // 
            this.pnPrice.Controls.Add(this.lbPrice);
            this.pnPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPrice.Location = new System.Drawing.Point(1086, 0);
            this.pnPrice.Name = "pnPrice";
            this.pnPrice.Size = new System.Drawing.Size(200, 50);
            this.pnPrice.TabIndex = 10;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrice.Location = new System.Drawing.Point(66, 15);
            this.lbPrice.MaximumSize = new System.Drawing.Size(180, 0);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(67, 20);
            this.lbPrice.TabIndex = 0;
            this.lbPrice.Text = "Giá tiền";
            // 
            // pnClassTicketName
            // 
            this.pnClassTicketName.Controls.Add(this.lbClassTicketName);
            this.pnClassTicketName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnClassTicketName.Location = new System.Drawing.Point(936, 0);
            this.pnClassTicketName.Name = "pnClassTicketName";
            this.pnClassTicketName.Size = new System.Drawing.Size(150, 50);
            this.pnClassTicketName.TabIndex = 9;
            // 
            // lbClassTicketName
            // 
            this.lbClassTicketName.AutoSize = true;
            this.lbClassTicketName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbClassTicketName.Location = new System.Drawing.Point(39, 15);
            this.lbClassTicketName.MaximumSize = new System.Drawing.Size(170, 0);
            this.lbClassTicketName.Name = "lbClassTicketName";
            this.lbClassTicketName.Size = new System.Drawing.Size(71, 20);
            this.lbClassTicketName.TabIndex = 0;
            this.lbClassTicketName.Text = "Hạng vé";
            // 
            // pnSeat
            // 
            this.pnSeat.Controls.Add(this.lbSeat);
            this.pnSeat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSeat.Location = new System.Drawing.Point(876, 0);
            this.pnSeat.Name = "pnSeat";
            this.pnSeat.Size = new System.Drawing.Size(60, 50);
            this.pnSeat.TabIndex = 8;
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbSeat.Location = new System.Drawing.Point(10, 15);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(40, 20);
            this.lbSeat.TabIndex = 0;
            this.lbSeat.Text = "Ghế";
            // 
            // pnEmail
            // 
            this.pnEmail.Controls.Add(this.lbEmail);
            this.pnEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnEmail.Location = new System.Drawing.Point(678, 0);
            this.pnEmail.Name = "pnEmail";
            this.pnEmail.Size = new System.Drawing.Size(198, 50);
            this.pnEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEmail.Location = new System.Drawing.Point(73, 15);
            this.lbEmail.MaximumSize = new System.Drawing.Size(180, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(51, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // pnPhone
            // 
            this.pnPhone.Controls.Add(this.lbPhone);
            this.pnPhone.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPhone.Location = new System.Drawing.Point(548, 0);
            this.pnPhone.Name = "pnPhone";
            this.pnPhone.Size = new System.Drawing.Size(130, 50);
            this.pnPhone.TabIndex = 6;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPhone.Location = new System.Drawing.Point(12, 15);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(106, 20);
            this.lbPhone.TabIndex = 0;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // pnCardID
            // 
            this.pnCardID.Controls.Add(this.lbCardID);
            this.pnCardID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCardID.Location = new System.Drawing.Point(398, 0);
            this.pnCardID.Name = "pnCardID";
            this.pnCardID.Size = new System.Drawing.Size(150, 50);
            this.pnCardID.TabIndex = 5;
            // 
            // lbCardID
            // 
            this.lbCardID.AutoSize = true;
            this.lbCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCardID.Location = new System.Drawing.Point(18, 15);
            this.lbCardID.Name = "lbCardID";
            this.lbCardID.Size = new System.Drawing.Size(114, 20);
            this.lbCardID.TabIndex = 0;
            this.lbCardID.Text = "CMND/CCCD";
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnName.Location = new System.Drawing.Point(200, 0);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(198, 50);
            this.pnName.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.Location = new System.Drawing.Point(58, 15);
            this.lbName.MaximumSize = new System.Drawing.Size(190, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ và tên";
            // 
            // pnFlightID
            // 
            this.pnFlightID.Controls.Add(this.lbFlightID);
            this.pnFlightID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFlightID.Location = new System.Drawing.Point(100, 0);
            this.pnFlightID.Name = "pnFlightID";
            this.pnFlightID.Size = new System.Drawing.Size(100, 50);
            this.pnFlightID.TabIndex = 3;
            // 
            // lbFlightID
            // 
            this.lbFlightID.AutoSize = true;
            this.lbFlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFlightID.Location = new System.Drawing.Point(3, 5);
            this.lbFlightID.MaximumSize = new System.Drawing.Size(120, 0);
            this.lbFlightID.Name = "lbFlightID";
            this.lbFlightID.Size = new System.Drawing.Size(90, 40);
            this.lbFlightID.TabIndex = 0;
            this.lbFlightID.Text = "Mã chuyến bay";
            this.lbFlightID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnTicketID
            // 
            this.pnTicketID.Controls.Add(this.lbTicketID);
            this.pnTicketID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTicketID.Location = new System.Drawing.Point(0, 0);
            this.pnTicketID.Name = "pnTicketID";
            this.pnTicketID.Size = new System.Drawing.Size(100, 50);
            this.pnTicketID.TabIndex = 2;
            // 
            // lbTicketID
            // 
            this.lbTicketID.AutoSize = true;
            this.lbTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTicketID.Location = new System.Drawing.Point(23, 15);
            this.lbTicketID.Name = "lbTicketID";
            this.lbTicketID.Size = new System.Drawing.Size(54, 20);
            this.lbTicketID.TabIndex = 0;
            this.lbTicketID.Text = "Mã vé";
            // 
            // SearchFlightTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnListTicket);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchFlightTicketUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.Load += new System.EventHandler(this.SearchFlightTicketUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnPrice.ResumeLayout(false);
            this.pnPrice.PerformLayout();
            this.pnClassTicketName.ResumeLayout(false);
            this.pnClassTicketName.PerformLayout();
            this.pnSeat.ResumeLayout(false);
            this.pnSeat.PerformLayout();
            this.pnEmail.ResumeLayout(false);
            this.pnEmail.PerformLayout();
            this.pnPhone.ResumeLayout(false);
            this.pnPhone.PerformLayout();
            this.pnCardID.ResumeLayout(false);
            this.pnCardID.PerformLayout();
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.pnFlightID.ResumeLayout(false);
            this.pnFlightID.PerformLayout();
            this.pnTicketID.ResumeLayout(false);
            this.pnTicketID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.ATextboxUC atxbKey;
        private AControls.AButton abtnSearch;
        private Panel panel1;
        private Panel pnListTicket;
        private ComboBox cbSearchType;
        private Panel panel2;
        private Panel pnTicketID;
        private Label lbTicketID;
        private Panel pnFlightID;
        private Label lbFlightID;
        private Panel pnName;
        private Label lbName;
        private Panel pnCardID;
        private Label lbCardID;
        private Panel pnPhone;
        private Label lbPhone;
        private Panel pnEmail;
        private Label lbEmail;
        private Panel pnSeat;
        private Label lbSeat;
        private Panel pnClassTicketName;
        private Label lbClassTicketName;
        private Panel pnPrice;
        private Label lbPrice;
        private Panel panel3;
        private Label label1;
    }
}
