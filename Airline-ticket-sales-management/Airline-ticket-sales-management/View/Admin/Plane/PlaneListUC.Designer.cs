using System.Drawing;
using System.Windows.Forms;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnPlaneList = new System.Windows.Forms.Panel();
            this.aTextboxUC1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1000, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 40);
            this.panel1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(158, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Thao tác";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(94, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã máy bay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.label2.Location = new System.Drawing.Point(143, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên máy bay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(88, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng ghế";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(700, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 40);
            this.panel5.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 40);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 0;
            // 
            // pnHeader
            // 
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Controls.Add(this.panel5);
            this.pnHeader.Controls.Add(this.panel3);
            this.pnHeader.Controls.Add(this.panel2);
            this.pnHeader.Location = new System.Drawing.Point(50, 72);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1400, 40);
            this.pnHeader.TabIndex = 6;
            // 
            // pnPlaneList
            // 
            this.pnPlaneList.AutoScroll = true;
            this.pnPlaneList.Location = new System.Drawing.Point(50, 112);
            this.pnPlaneList.Name = "pnPlaneList";
            this.pnPlaneList.Size = new System.Drawing.Size(1400, 440);
            this.pnPlaneList.TabIndex = 12;
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
            this.aTextboxUC1.Location = new System.Drawing.Point(50, 24);
            this.aTextboxUC1.Margin = new System.Windows.Forms.Padding(4);
            this.aTextboxUC1.Multiline = false;
            this.aTextboxUC1.Name = "aTextboxUC1";
            this.aTextboxUC1.Padding = new System.Windows.Forms.Padding(7);
            this.aTextboxUC1.PasswordChar = false;
            this.aTextboxUC1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxUC1.PlaceholderText = "Mã máy bay";
            this.aTextboxUC1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxUC1.Size = new System.Drawing.Size(200, 37);
            this.aTextboxUC1.TabIndex = 7;
            this.aTextboxUC1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxUC1.Texts = "";
            this.aTextboxUC1.UnderlinedStyle = false;
            // 
            // PlaneListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.pnPlaneList);
            this.Controls.Add(this.aTextboxUC1);
            this.Name = "PlaneListUC";
            this.Size = new System.Drawing.Size(1500, 576);
            this.Load += new System.EventHandler(this.PlaneListUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Panel pnPlaneList;
        private AControls.ATextboxUC aTextboxUC1;
    }
}
