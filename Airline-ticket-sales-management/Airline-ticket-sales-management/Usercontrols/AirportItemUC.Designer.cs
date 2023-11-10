using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class AirportItemUC
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
            this.pnAirportName = new System.Windows.Forms.Panel();
            this.lbAirportName = new System.Windows.Forms.Label();
            this.pnCityName = new System.Windows.Forms.Panel();
            this.lbCityName = new System.Windows.Forms.Label();
            this.pnCountryName = new System.Windows.Forms.Panel();
            this.lbCountryName = new System.Windows.Forms.Label();
            this.pnOperation = new System.Windows.Forms.Panel();
            this.pibDelete = new System.Windows.Forms.PictureBox();
            this.pibEdit = new System.Windows.Forms.PictureBox();
            this.pnAirportName.SuspendLayout();
            this.pnCityName.SuspendLayout();
            this.pnCountryName.SuspendLayout();
            this.pnOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnAirportName
            // 
            this.pnAirportName.Controls.Add(this.lbAirportName);
            this.pnAirportName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAirportName.Location = new System.Drawing.Point(0, 0);
            this.pnAirportName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnAirportName.Name = "pnAirportName";
            this.pnAirportName.Size = new System.Drawing.Size(250, 40);
            this.pnAirportName.TabIndex = 1;
            // 
            // lbAirportName
            // 
            this.lbAirportName.AutoSize = true;
            this.lbAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbAirportName.Location = new System.Drawing.Point(64, 9);
            this.lbAirportName.MaximumSize = new System.Drawing.Size(210, 0);
            this.lbAirportName.Name = "lbAirportName";
            this.lbAirportName.Size = new System.Drawing.Size(122, 22);
            this.lbAirportName.TabIndex = 0;
            this.lbAirportName.Text = "Tân Sơn Nhất";
            this.lbAirportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCityName
            // 
            this.pnCityName.Controls.Add(this.lbCityName);
            this.pnCityName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCityName.Location = new System.Drawing.Point(250, 0);
            this.pnCityName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCityName.Name = "pnCityName";
            this.pnCityName.Size = new System.Drawing.Size(250, 40);
            this.pnCityName.TabIndex = 2;
            // 
            // lbCityName
            // 
            this.lbCityName.AutoSize = true;
            this.lbCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbCityName.Location = new System.Drawing.Point(71, 9);
            this.lbCityName.MaximumSize = new System.Drawing.Size(210, 0);
            this.lbCityName.Name = "lbCityName";
            this.lbCityName.Size = new System.Drawing.Size(108, 22);
            this.lbCityName.TabIndex = 0;
            this.lbCityName.Text = "Hồ Chí Minh";
            this.lbCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCountryName
            // 
            this.pnCountryName.Controls.Add(this.lbCountryName);
            this.pnCountryName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCountryName.Location = new System.Drawing.Point(500, 0);
            this.pnCountryName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCountryName.Name = "pnCountryName";
            this.pnCountryName.Size = new System.Drawing.Size(250, 40);
            this.pnCountryName.TabIndex = 3;
            // 
            // lbCountryName
            // 
            this.lbCountryName.AutoSize = true;
            this.lbCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbCountryName.Location = new System.Drawing.Point(83, 9);
            this.lbCountryName.MaximumSize = new System.Drawing.Size(210, 0);
            this.lbCountryName.Name = "lbCountryName";
            this.lbCountryName.Size = new System.Drawing.Size(83, 22);
            this.lbCountryName.TabIndex = 0;
            this.lbCountryName.Text = "Việt Nam";
            this.lbCountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnOperation
            // 
            this.pnOperation.Controls.Add(this.pibDelete);
            this.pnOperation.Controls.Add(this.pibEdit);
            this.pnOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnOperation.Location = new System.Drawing.Point(750, 0);
            this.pnOperation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnOperation.Name = "pnOperation";
            this.pnOperation.Size = new System.Drawing.Size(150, 40);
            this.pnOperation.TabIndex = 4;
            // 
            // pibDelete
            // 
            this.pibDelete.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.DeleteIcon;
            this.pibDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDelete.Location = new System.Drawing.Point(83, 7);
            this.pibDelete.Name = "pibDelete";
            this.pibDelete.Size = new System.Drawing.Size(32, 26);
            this.pibDelete.TabIndex = 20;
            this.pibDelete.TabStop = false;
            this.pibDelete.Click += new System.EventHandler(this.pibDelete_Click);
            // 
            // pibEdit
            // 
            this.pibEdit.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.EditIcon;
            this.pibEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibEdit.Location = new System.Drawing.Point(35, 7);
            this.pibEdit.Name = "pibEdit";
            this.pibEdit.Size = new System.Drawing.Size(32, 26);
            this.pibEdit.TabIndex = 19;
            this.pibEdit.TabStop = false;
            this.pibEdit.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // AirportItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnOperation);
            this.Controls.Add(this.pnCountryName);
            this.Controls.Add(this.pnCityName);
            this.Controls.Add(this.pnAirportName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AirportItemUC";
            this.Size = new System.Drawing.Size(900, 40);
            this.pnAirportName.ResumeLayout(false);
            this.pnAirportName.PerformLayout();
            this.pnCityName.ResumeLayout(false);
            this.pnCityName.PerformLayout();
            this.pnCountryName.ResumeLayout(false);
            this.pnCountryName.PerformLayout();
            this.pnOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnAirportName;
        private Label lbAirportName;
        private Panel pnCityName;
        private Label lbCityName;
        private Panel pnCountryName;
        private Label lbCountryName;
        private Panel pnOperation;
        private PictureBox pibEdit;
        private PictureBox pibDelete;
    }
}
