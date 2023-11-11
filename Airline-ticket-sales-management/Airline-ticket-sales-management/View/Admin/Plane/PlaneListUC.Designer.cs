namespace Airline_ticket_sales_management
{
    partial class PlaneListUC
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
            panel1 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pnHeader = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            pnFlightList = new Panel();
            aTextboxUC1 = new AControls.ATextboxUC();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnHeader.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1000, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 50);
            panel1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(158, 15);
            label9.Name = "label9";
            label9.Size = new Size(83, 24);
            label9.TabIndex = 1;
            label9.Text = "Thao tác";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 24);
            label1.TabIndex = 0;
            label1.Text = "Mã máy bay";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 15);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên máy bay";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 15);
            label4.Name = "label4";
            label4.Size = new Size(124, 24);
            label4.TabIndex = 1;
            label4.Text = "Số lượng ghế";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(500, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 50);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(200, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 50);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 50);
            panel2.TabIndex = 0;
            // 
            // pnHeader
            // 
            pnHeader.Controls.Add(panel1);
            pnHeader.Controls.Add(panel6);
            pnHeader.Controls.Add(panel5);
            pnHeader.Controls.Add(panel3);
            pnHeader.Controls.Add(panel2);
            pnHeader.Location = new Point(50, 90);
            pnHeader.Margin = new Padding(3, 4, 3, 4);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(1400, 50);
            pnHeader.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(700, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 50);
            panel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 15);
            label5.Name = "label5";
            label5.Size = new Size(94, 24);
            label5.TabIndex = 1;
            label5.Text = "Trạng thái";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnFlightList
            // 
            pnFlightList.AutoScroll = true;
            pnFlightList.Location = new Point(50, 140);
            pnFlightList.Margin = new Padding(3, 4, 3, 4);
            pnFlightList.Name = "pnFlightList";
            pnFlightList.Size = new Size(1400, 550);
            pnFlightList.TabIndex = 12;
            // 
            // aTextboxUC1
            // 
            aTextboxUC1.BackColor = Color.White;
            aTextboxUC1.BorderColor = Color.FromArgb(3, 4, 94);
            aTextboxUC1.BorderFocusColor = Color.FromArgb(0, 138, 184);
            aTextboxUC1.BorderRadius = 5;
            aTextboxUC1.BorderSize = 2;
            aTextboxUC1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aTextboxUC1.ForeColor = Color.DimGray;
            aTextboxUC1.Location = new Point(50, 30);
            aTextboxUC1.Margin = new Padding(4, 5, 4, 5);
            aTextboxUC1.Multiline = false;
            aTextboxUC1.Name = "aTextboxUC1";
            aTextboxUC1.Padding = new Padding(7, 9, 7, 9);
            aTextboxUC1.PasswordChar = false;
            aTextboxUC1.PlaceholderColor = Color.DarkGray;
            aTextboxUC1.PlaceholderText = "Mã máy bay";
            aTextboxUC1.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            aTextboxUC1.Size = new Size(200, 41);
            aTextboxUC1.TabIndex = 7;
            aTextboxUC1.Texts = "";
            aTextboxUC1.UnderlinedStyle = false;
            // 
            // PlaneListUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pnHeader);
            Controls.Add(pnFlightList);
            Controls.Add(aTextboxUC1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlaneListUC";
            Size = new Size(1500, 720);
            Load += PlaneListUC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnHeader.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label4;
        private Panel panel5;
        private Panel panel3;
        private Panel panel2;
        private Panel pnHeader;
        private Panel pnFlightList;
        private AControls.ATextboxUC aTextboxUC1;
        private Panel panel6;
        private Label label5;
    }
}
