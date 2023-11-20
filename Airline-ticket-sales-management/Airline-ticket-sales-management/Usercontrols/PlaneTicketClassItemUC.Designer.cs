using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class PlaneTicketClassItemUC
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
            this.lbText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbText.ForeColor = System.Drawing.Color.Black;
            this.lbText.Location = new System.Drawing.Point(4, 31);
            this.lbText.MaximumSize = new System.Drawing.Size(100, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(92, 22);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Phổ thông";
            // 
            // PlaneTicketClassItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PlaneTicketClassItemUC";
            this.Size = new System.Drawing.Size(230, 80);
            this.Load += new System.EventHandler(this.PlaneTicketClassItemUC_Load);
            this.Click += new System.EventHandler(this.PlaneTicketClassItemUC_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbText;
    }
}
