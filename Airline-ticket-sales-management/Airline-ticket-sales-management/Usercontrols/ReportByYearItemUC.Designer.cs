using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class ReportByYearItemUC
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
            this.pnMonth = new System.Windows.Forms.Panel();
            this.lbMonth = new System.Windows.Forms.Label();
            this.pnFlightCount = new System.Windows.Forms.Panel();
            this.lbFlightCount = new System.Windows.Forms.Label();
            this.pnRevenue = new System.Windows.Forms.Panel();
            this.lbRevenue = new System.Windows.Forms.Label();
            this.pnRatio = new System.Windows.Forms.Panel();
            this.lbRatio = new System.Windows.Forms.Label();
            this.pnSTT.SuspendLayout();
            this.pnMonth.SuspendLayout();
            this.pnFlightCount.SuspendLayout();
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
            this.pnSTT.TabIndex = 1;
            // 
            // lbSTT
            // 
            this.lbSTT.AutoSize = true;
            this.lbSTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbSTT.ForeColor = System.Drawing.Color.Black;
            this.lbSTT.Location = new System.Drawing.Point(40, 11);
            this.lbSTT.Name = "lbSTT";
            this.lbSTT.Size = new System.Drawing.Size(20, 22);
            this.lbSTT.TabIndex = 0;
            this.lbSTT.Text = "1";
            // 
            // pnMonth
            // 
            this.pnMonth.Controls.Add(this.lbMonth);
            this.pnMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMonth.Location = new System.Drawing.Point(100, 0);
            this.pnMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMonth.Name = "pnMonth";
            this.pnMonth.Size = new System.Drawing.Size(100, 40);
            this.pnMonth.TabIndex = 2;
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbMonth.ForeColor = System.Drawing.Color.Black;
            this.lbMonth.Location = new System.Drawing.Point(47, 11);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(20, 22);
            this.lbMonth.TabIndex = 0;
            this.lbMonth.Text = "2";
            // 
            // pnFlightCount
            // 
            this.pnFlightCount.Controls.Add(this.lbFlightCount);
            this.pnFlightCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFlightCount.Location = new System.Drawing.Point(200, 0);
            this.pnFlightCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFlightCount.Name = "pnFlightCount";
            this.pnFlightCount.Size = new System.Drawing.Size(200, 40);
            this.pnFlightCount.TabIndex = 3;
            // 
            // lbFlightCount
            // 
            this.lbFlightCount.AutoSize = true;
            this.lbFlightCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbFlightCount.ForeColor = System.Drawing.Color.Black;
            this.lbFlightCount.Location = new System.Drawing.Point(88, 11);
            this.lbFlightCount.Name = "lbFlightCount";
            this.lbFlightCount.Size = new System.Drawing.Size(50, 22);
            this.lbFlightCount.TabIndex = 0;
            this.lbFlightCount.Text = "1000";
            // 
            // pnRevenue
            // 
            this.pnRevenue.Controls.Add(this.lbRevenue);
            this.pnRevenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnRevenue.Location = new System.Drawing.Point(400, 0);
            this.pnRevenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRevenue.Name = "pnRevenue";
            this.pnRevenue.Size = new System.Drawing.Size(300, 40);
            this.pnRevenue.TabIndex = 4;
            // 
            // lbRevenue
            // 
            this.lbRevenue.AutoSize = true;
            this.lbRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRevenue.ForeColor = System.Drawing.Color.Black;
            this.lbRevenue.Location = new System.Drawing.Point(125, 11);
            this.lbRevenue.Name = "lbRevenue";
            this.lbRevenue.Size = new System.Drawing.Size(50, 22);
            this.lbRevenue.TabIndex = 0;
            this.lbRevenue.Text = "1000";
            // 
            // pnRatio
            // 
            this.pnRatio.Controls.Add(this.lbRatio);
            this.pnRatio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnRatio.Location = new System.Drawing.Point(700, 0);
            this.pnRatio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnRatio.Name = "pnRatio";
            this.pnRatio.Size = new System.Drawing.Size(100, 40);
            this.pnRatio.TabIndex = 6;
            // 
            // lbRatio
            // 
            this.lbRatio.AutoSize = true;
            this.lbRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbRatio.ForeColor = System.Drawing.Color.Black;
            this.lbRatio.Location = new System.Drawing.Point(48, 11);
            this.lbRatio.Name = "lbRatio";
            this.lbRatio.Size = new System.Drawing.Size(30, 22);
            this.lbRatio.TabIndex = 0;
            this.lbRatio.Text = "10";
            // 
            // ReportByYearItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnRatio);
            this.Controls.Add(this.pnRevenue);
            this.Controls.Add(this.pnFlightCount);
            this.Controls.Add(this.pnMonth);
            this.Controls.Add(this.pnSTT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportByYearItemUC";
            this.Size = new System.Drawing.Size(800, 40);
            this.pnSTT.ResumeLayout(false);
            this.pnSTT.PerformLayout();
            this.pnMonth.ResumeLayout(false);
            this.pnMonth.PerformLayout();
            this.pnFlightCount.ResumeLayout(false);
            this.pnFlightCount.PerformLayout();
            this.pnRevenue.ResumeLayout(false);
            this.pnRevenue.PerformLayout();
            this.pnRatio.ResumeLayout(false);
            this.pnRatio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnSTT;
        private Label lbSTT;
        private Panel pnMonth;
        private Label lbMonth;
        private Panel pnFlightCount;
        private Label lbFlightCount;
        private Panel pnRevenue;
        private Label lbRevenue;
        private Panel pnRatio;
        private Label lbRatio;
    }
}
