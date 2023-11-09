using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class TicketClassItemUC
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
            this.pnTicketClassName = new System.Windows.Forms.Panel();
            this.lbTicketClassName = new System.Windows.Forms.Label();
            this.pnPricePercentage = new System.Windows.Forms.Panel();
            this.lbPricePercentage = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.pibDelete = new System.Windows.Forms.PictureBox();
            this.pibEdit = new System.Windows.Forms.PictureBox();
            this.pnTicketClassName.SuspendLayout();
            this.pnPricePercentage.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTicketClassName
            // 
            this.pnTicketClassName.Controls.Add(this.lbTicketClassName);
            this.pnTicketClassName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTicketClassName.Location = new System.Drawing.Point(0, 0);
            this.pnTicketClassName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTicketClassName.Name = "pnTicketClassName";
            this.pnTicketClassName.Size = new System.Drawing.Size(250, 40);
            this.pnTicketClassName.TabIndex = 1;
            // 
            // lbTicketClassName
            // 
            this.lbTicketClassName.AutoSize = true;
            this.lbTicketClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbTicketClassName.Location = new System.Drawing.Point(15, 9);
            this.lbTicketClassName.MaximumSize = new System.Drawing.Size(210, 0);
            this.lbTicketClassName.Name = "lbTicketClassName";
            this.lbTicketClassName.Size = new System.Drawing.Size(92, 22);
            this.lbTicketClassName.TabIndex = 0;
            this.lbTicketClassName.Text = "Phổ thông";
            // 
            // pnPricePercentage
            // 
            this.pnPricePercentage.Controls.Add(this.lbPricePercentage);
            this.pnPricePercentage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPricePercentage.Location = new System.Drawing.Point(250, 0);
            this.pnPricePercentage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPricePercentage.Name = "pnPricePercentage";
            this.pnPricePercentage.Size = new System.Drawing.Size(150, 40);
            this.pnPricePercentage.TabIndex = 2;
            // 
            // lbPricePercentage
            // 
            this.lbPricePercentage.AutoSize = true;
            this.lbPricePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbPricePercentage.Location = new System.Drawing.Point(15, 11);
            this.lbPricePercentage.MaximumSize = new System.Drawing.Size(110, 0);
            this.lbPricePercentage.Name = "lbPricePercentage";
            this.lbPricePercentage.Size = new System.Drawing.Size(56, 22);
            this.lbPricePercentage.TabIndex = 0;
            this.lbPricePercentage.Text = "105%";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.pibDelete);
            this.panel15.Controls.Add(this.pibEdit);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(400, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(100, 40);
            this.panel15.TabIndex = 3;
            // 
            // pibDelete
            // 
            this.pibDelete.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.DeleteIcon;
            this.pibDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDelete.Location = new System.Drawing.Point(48, 7);
            this.pibDelete.Name = "pibDelete";
            this.pibDelete.Size = new System.Drawing.Size(32, 26);
            this.pibDelete.TabIndex = 22;
            this.pibDelete.TabStop = false;
            this.pibDelete.Click += new System.EventHandler(this.pibDelete_Click);
            // 
            // pibEdit
            // 
            this.pibEdit.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.EditIcon;
            this.pibEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibEdit.Location = new System.Drawing.Point(12, 7);
            this.pibEdit.Name = "pibEdit";
            this.pibEdit.Size = new System.Drawing.Size(32, 26);
            this.pibEdit.TabIndex = 21;
            this.pibEdit.TabStop = false;
            this.pibEdit.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // TicketClassItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.pnPricePercentage);
            this.Controls.Add(this.pnTicketClassName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TicketClassItemUC";
            this.Size = new System.Drawing.Size(500, 40);
            this.pnTicketClassName.ResumeLayout(false);
            this.pnTicketClassName.PerformLayout();
            this.pnPricePercentage.ResumeLayout(false);
            this.pnPricePercentage.PerformLayout();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnTicketClassName;
        private Label lbTicketClassName;
        private Panel pnPricePercentage;
        private Label lbPricePercentage;
        private Panel panel15;
        private PictureBox pibDelete;
        private PictureBox pibEdit;
    }
}
