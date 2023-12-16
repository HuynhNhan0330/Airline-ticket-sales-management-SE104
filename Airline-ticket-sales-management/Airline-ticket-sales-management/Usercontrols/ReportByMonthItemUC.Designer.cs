using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class ReportByMonthItemUC
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
            this.pnSTT = new System.Windows.Forms.Panel();
            this.lbSTT = new System.Windows.Forms.Label();
            this.pnFlightName = new System.Windows.Forms.Panel();
            this.lbFlightName = new System.Windows.Forms.Label();
            this.pnTicket = new System.Windows.Forms.Panel();
            this.lbTicket = new System.Windows.Forms.Label();
            this.pnRevenue = new System.Windows.Forms.Panel();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.pnRatio = new System.Windows.Forms.Panel();
            this.lbRatio = new System.Windows.Forms.Label();
            this.pnSTT.SuspendLayout();
            this.pnFlightName.SuspendLayout();
            this.pnTicket.SuspendLayout();
            this.pnRevenue.SuspendLayout();
            this.pnRatio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSTT
            // 
            this.pnSTT.Controls.Add(this.lbSTT);
            this.pnSTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSTT.Location = new System.Drawing.Point(0, 0);
            this.pnSTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSTT.Name = "pnSTT";
            this.pnSTT.Size = new System.Drawing.Size(100, 40);
            this.pnSTT.TabIndex = 0;
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbSTT.ForeColor = System.Drawing.Color.Black;
            this.lbSTT.Location = new System.Drawing.Point(40, 10);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(20, 22);
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "1";
            // 
            // pnFlightName
            // 
            this.pnFlightName.Controls.Add(this.lbFlightName);
            this.pnFlightName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFlightName.Location = new System.Drawing.Point(100, 0);
            this.pnFlightName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFlightName.Name = "pnFlightName";
            this.pnFlightName.Size = new System.Drawing.Size(600, 40);
            this.pnFlightName.TabIndex = 1;
            // 
            // lbFlightName
            // 
            this.lbFlightName.AutoSize = true;
            this.lbFlightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbFlightName.ForeColor = System.Drawing.Color.Black;
            this.lbFlightName.Location = new System.Drawing.Point(202, 10);
            this.lbFlightName.MaximumSize = new System.Drawing.Size(580, 0);
            this.lbFlightName.Name = "lbFlightName";
            this.lbFlightName.Size = new System.Drawing.Size(195, 22);
            this.lbFlightName.TabIndex = 1;
            this.lbFlightName.Text = "Đà Nẵng - Hồ Chí Minh";
            // 
            // pnTicket
            // 
            this.pnTicket.Controls.Add(this.lbTicket);
            this.pnTicket.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTicket.Location = new System.Drawing.Point(700, 0);
            this.pnTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTicket.Name = "pnTicket";
            this.pnTicket.Size = new System.Drawing.Size(300, 40);
            this.pnTicket.TabIndex = 2;
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbTicket.ForeColor = System.Drawing.Color.Black;
            this.lbTicket.Location = new System.Drawing.Point(125, 10);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(50, 22);
            this.lbTicket.TabIndex = 1;
            this.lbTicket.Text = "1000";
            // 
            // pnRevenue
            // 
            this.pnRevenue.Controls.Add(this.lbRevenue);
            this.pnRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnRevenue.Location = new System.Drawing.Point(1000, 0);
            this.pnRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRevenue.Name = "pnRevenue";
            this.pnRevenue.Size = new System.Drawing.Size(300, 40);
            this.pnRevenue.TabIndex = 3;
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRevenue.ForeColor = System.Drawing.Color.Black;
            this.lbRevenue.Location = new System.Drawing.Point(120, 10);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(60, 22);
            this.lbRevenue.TabIndex = 1;
            this.lbRevenue.Text = "20000";
            // 
            // pnRatio
            // 
            this.pnRatio.Controls.Add(this.lbRatio);
            this.pnRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRatio.Location = new System.Drawing.Point(1300, 0);
            this.pnRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRatio.Name = "pnRatio";
            this.pnRatio.Size = new System.Drawing.Size(100, 40);
            this.pnRatio.TabIndex = 4;
            // 
            // lbRatio
            // 
            this.lbRatio.AutoSize = true;
            this.lbRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRatio.ForeColor = System.Drawing.Color.Black;
            this.lbRatio.Location = new System.Drawing.Point(35, 10);
            this.lbRatio.Name = "lbRatio";
            this.lbRatio.Size = new System.Drawing.Size(30, 22);
            this.lbRatio.TabIndex = 1;
            this.lbRatio.Text = "10";
            // 
            // ReportByMonthItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnRatio);
            this.Controls.Add(this.pnRevenue);
            this.Controls.Add(this.pnTicket);
            this.Controls.Add(this.pnFlightName);
            this.Controls.Add(this.pnSTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportByMonthItemUC";
            this.Size = new System.Drawing.Size(1400, 40);
            this.pnSTT.ResumeLayout(false);
            this.pnSTT.PerformLayout();
            this.pnFlightName.ResumeLayout(false);
            this.pnFlightName.PerformLayout();
            this.pnTicket.ResumeLayout(false);
            this.pnTicket.PerformLayout();
            this.pnRevenue.ResumeLayout(false);
            this.pnRevenue.PerformLayout();
            this.pnRatio.ResumeLayout(false);
            this.pnRatio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnSTT;
        private Label lbSTT;
        private Panel pnFlightName;
        private Panel pnTicket;
        private Panel pnRevenue;
        private Panel pnRatio;
        private Label lbFlightName;
        private Label lbTicket;
        private Label lbRevenue;
        private Label lbRatio;
    }
}
