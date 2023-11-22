using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class PlaneSeatItemUC
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
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.pn3 = new System.Windows.Forms.Panel();
            this.pn4 = new System.Windows.Forms.Panel();
            this.pn5 = new System.Windows.Forms.Panel();
            this.pn6 = new System.Windows.Forms.Panel();
            this.pnSTT = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.pnSTT.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.Gray;
            this.pn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn1.Location = new System.Drawing.Point(0, 0);
            this.pn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(100, 80);
            this.pn1.TabIndex = 0;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.Gray;
            this.pn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn2.Location = new System.Drawing.Point(125, 0);
            this.pn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(100, 80);
            this.pn2.TabIndex = 1;
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.Gray;
            this.pn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn3.Location = new System.Drawing.Point(250, 0);
            this.pn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(100, 80);
            this.pn3.TabIndex = 2;
            // 
            // pn4
            // 
            this.pn4.BackColor = System.Drawing.Color.Gray;
            this.pn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn4.Location = new System.Drawing.Point(450, 0);
            this.pn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(100, 80);
            this.pn4.TabIndex = 3;
            // 
            // pn5
            // 
            this.pn5.BackColor = System.Drawing.Color.Gray;
            this.pn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn5.Location = new System.Drawing.Point(575, 0);
            this.pn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn5.Name = "pn5";
            this.pn5.Size = new System.Drawing.Size(100, 80);
            this.pn5.TabIndex = 1;
            // 
            // pn6
            // 
            this.pn6.BackColor = System.Drawing.Color.Gray;
            this.pn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn6.Location = new System.Drawing.Point(700, 0);
            this.pn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn6.Name = "pn6";
            this.pn6.Size = new System.Drawing.Size(100, 80);
            this.pn6.TabIndex = 1;
            // 
            // pnSTT
            // 
            this.pnSTT.Controls.Add(this.lbText);
            this.pnSTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnSTT.Location = new System.Drawing.Point(350, 0);
            this.pnSTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnSTT.Name = "pnSTT";
            this.pnSTT.Size = new System.Drawing.Size(100, 80);
            this.pnSTT.TabIndex = 4;
            this.pnSTT.Click += new System.EventHandler(this.lbText_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbText.ForeColor = System.Drawing.Color.Black;
            this.lbText.Location = new System.Drawing.Point(38, 31);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(23, 22);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "A";
            this.lbText.Click += new System.EventHandler(this.lbText_Click);
            // 
            // PlaneSeatItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnSTT);
            this.Controls.Add(this.pn6);
            this.Controls.Add(this.pn5);
            this.Controls.Add(this.pn4);
            this.Controls.Add(this.pn3);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Name = "PlaneSeatItemUC";
            this.Size = new System.Drawing.Size(820, 80);
            this.Load += new System.EventHandler(this.PlaneSeatItemUC_Load);
            this.pnSTT.ResumeLayout(false);
            this.pnSTT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn1;
        private Panel pn2;
        private Panel pn3;
        private Panel pn4;
        private Panel pn5;
        private Panel pn6;
        private Panel pnSTT;
        private Label lbText;
    }
}
