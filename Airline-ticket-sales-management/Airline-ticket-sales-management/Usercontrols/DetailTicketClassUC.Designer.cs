namespace Airline_ticket_sales_management.Usercontrols
{
    partial class DetailTicketClassUC
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
            this.pnName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnNumber = new System.Windows.Forms.Panel();
            this.lbNumber = new System.Windows.Forms.Label();
            this.pnName.SuspendLayout();
            this.pnNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnName.Location = new System.Drawing.Point(0, 0);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(140, 100);
            this.pnName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbName.Location = new System.Drawing.Point(10, 42);
            this.lbName.MaximumSize = new System.Drawing.Size(110, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(97, 24);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Phổ thông";
            // 
            // pnNumber
            // 
            this.pnNumber.Controls.Add(this.lbNumber);
            this.pnNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNumber.Location = new System.Drawing.Point(140, 0);
            this.pnNumber.Name = "pnNumber";
            this.pnNumber.Size = new System.Drawing.Size(60, 100);
            this.pnNumber.TabIndex = 1;
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbNumber.Location = new System.Drawing.Point(0, 42);
            this.lbNumber.MaximumSize = new System.Drawing.Size(40, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(40, 24);
            this.lbNumber.TabIndex = 0;
            this.lbNumber.Text = "100";
            // 
            // DetailTicketClassUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNumber);
            this.Controls.Add(this.pnName);
            this.Name = "DetailTicketClassUC";
            this.Size = new System.Drawing.Size(200, 100);
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.pnNumber.ResumeLayout(false);
            this.pnNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnNumber;
        private System.Windows.Forms.Label lbNumber;
    }
}
