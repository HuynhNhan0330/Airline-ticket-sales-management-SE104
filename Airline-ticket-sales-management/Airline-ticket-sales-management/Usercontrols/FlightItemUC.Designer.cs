using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class FlightItemUC
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
            this.lbDepartureAirport = new System.Windows.Forms.Label();
            this.pnFlightID = new System.Windows.Forms.Panel();
            this.lbFlightID = new System.Windows.Forms.Label();
            this.lbFlightTime = new System.Windows.Forms.Label();
            this.lbEmptySeat = new System.Windows.Forms.Label();
            this.lbReservedSeat = new System.Windows.Forms.Label();
            this.pnDepartureAirport = new System.Windows.Forms.Panel();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.pnDeparture = new System.Windows.Forms.Panel();
            this.lbArrivalAirport = new System.Windows.Forms.Label();
            this.pnArrivalAirport = new System.Windows.Forms.Panel();
            this.lbArrival = new System.Windows.Forms.Label();
            this.pnArrival = new System.Windows.Forms.Panel();
            this.pnFlightTime = new System.Windows.Forms.Panel();
            this.pnEmptySeat = new System.Windows.Forms.Panel();
            this.lbFlightDetail = new System.Windows.Forms.Label();
            this.pibDelete = new System.Windows.Forms.PictureBox();
            this.pibEdit = new System.Windows.Forms.PictureBox();
            this.pnReservedSeat = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.abtnBookTicket = new Airline_ticket_sales_management.AControls.AButton();
            this.pnFlightID.SuspendLayout();
            this.pnDepartureAirport.SuspendLayout();
            this.pnDeparture.SuspendLayout();
            this.pnArrivalAirport.SuspendLayout();
            this.pnArrival.SuspendLayout();
            this.pnFlightTime.SuspendLayout();
            this.pnEmptySeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).BeginInit();
            this.pnReservedSeat.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDepartureAirport
            // 
            this.lbDepartureAirport.AutoSize = true;
            this.lbDepartureAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbDepartureAirport.Location = new System.Drawing.Point(14, 19);
            this.lbDepartureAirport.MaximumSize = new System.Drawing.Size(130, 0);
            this.lbDepartureAirport.Name = "lbDepartureAirport";
            this.lbDepartureAirport.Size = new System.Drawing.Size(126, 24);
            this.lbDepartureAirport.TabIndex = 10;
            this.lbDepartureAirport.Text = "Tân Sơn Nhất";
            this.lbDepartureAirport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnFlightID
            // 
            this.pnFlightID.Controls.Add(this.lbFlightID);
            this.pnFlightID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFlightID.Location = new System.Drawing.Point(0, 0);
            this.pnFlightID.Name = "pnFlightID";
            this.pnFlightID.Size = new System.Drawing.Size(150, 80);
            this.pnFlightID.TabIndex = 5;
            // 
            // lbFlightID
            // 
            this.lbFlightID.AutoSize = true;
            this.lbFlightID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbFlightID.Location = new System.Drawing.Point(44, 15);
            this.lbFlightID.Name = "lbFlightID";
            this.lbFlightID.Size = new System.Drawing.Size(62, 24);
            this.lbFlightID.TabIndex = 0;
            this.lbFlightID.Text = "F0001";
            // 
            // lbFlightTime
            // 
            this.lbFlightTime.AutoSize = true;
            this.lbFlightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lbFlightTime.Location = new System.Drawing.Point(10, 19);
            this.lbFlightTime.Name = "lbFlightTime";
            this.lbFlightTime.Size = new System.Drawing.Size(116, 22);
            this.lbFlightTime.TabIndex = 7;
            this.lbFlightTime.Text = "05:00 - 17:00";
            // 
            // lbEmptySeat
            // 
            this.lbEmptySeat.AutoSize = true;
            this.lbEmptySeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbEmptySeat.Location = new System.Drawing.Point(10, 19);
            this.lbEmptySeat.MaximumSize = new System.Drawing.Size(80, 0);
            this.lbEmptySeat.Name = "lbEmptySeat";
            this.lbEmptySeat.Size = new System.Drawing.Size(50, 24);
            this.lbEmptySeat.TabIndex = 8;
            this.lbEmptySeat.Text = "1000";
            // 
            // lbReservedSeat
            // 
            this.lbReservedSeat.AutoSize = true;
            this.lbReservedSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbReservedSeat.Location = new System.Drawing.Point(10, 19);
            this.lbReservedSeat.MaximumSize = new System.Drawing.Size(80, 0);
            this.lbReservedSeat.Name = "lbReservedSeat";
            this.lbReservedSeat.Size = new System.Drawing.Size(50, 24);
            this.lbReservedSeat.TabIndex = 9;
            this.lbReservedSeat.Text = "1000";
            // 
            // pnDepartureAirport
            // 
            this.pnDepartureAirport.Controls.Add(this.lbDepartureAirport);
            this.pnDepartureAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDepartureAirport.Location = new System.Drawing.Point(150, 0);
            this.pnDepartureAirport.Name = "pnDepartureAirport";
            this.pnDepartureAirport.Size = new System.Drawing.Size(150, 80);
            this.pnDepartureAirport.TabIndex = 10;
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbDeparture.Location = new System.Drawing.Point(17, 19);
            this.lbDeparture.MaximumSize = new System.Drawing.Size(130, 0);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(115, 24);
            this.lbDeparture.TabIndex = 10;
            this.lbDeparture.Text = "Hồ Chí Minh";
            this.lbDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnDeparture
            // 
            this.pnDeparture.Controls.Add(this.lbDeparture);
            this.pnDeparture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnDeparture.Location = new System.Drawing.Point(300, 0);
            this.pnDeparture.Name = "pnDeparture";
            this.pnDeparture.Size = new System.Drawing.Size(150, 80);
            this.pnDeparture.TabIndex = 11;
            // 
            // lbArrivalAirport
            // 
            this.lbArrivalAirport.AutoSize = true;
            this.lbArrivalAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbArrivalAirport.Location = new System.Drawing.Point(14, 19);
            this.lbArrivalAirport.MaximumSize = new System.Drawing.Size(130, 0);
            this.lbArrivalAirport.Name = "lbArrivalAirport";
            this.lbArrivalAirport.Size = new System.Drawing.Size(126, 24);
            this.lbArrivalAirport.TabIndex = 10;
            this.lbArrivalAirport.Text = "Tân Sơn Nhất";
            this.lbArrivalAirport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnArrivalAirport
            // 
            this.pnArrivalAirport.Controls.Add(this.lbArrivalAirport);
            this.pnArrivalAirport.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnArrivalAirport.Location = new System.Drawing.Point(450, 0);
            this.pnArrivalAirport.Name = "pnArrivalAirport";
            this.pnArrivalAirport.Size = new System.Drawing.Size(150, 80);
            this.pnArrivalAirport.TabIndex = 12;
            // 
            // lbArrival
            // 
            this.lbArrival.AutoSize = true;
            this.lbArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbArrival.Location = new System.Drawing.Point(33, 19);
            this.lbArrival.MaximumSize = new System.Drawing.Size(130, 0);
            this.lbArrival.Name = "lbArrival";
            this.lbArrival.Size = new System.Drawing.Size(84, 24);
            this.lbArrival.TabIndex = 10;
            this.lbArrival.Text = "Đà Nẵng";
            this.lbArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnArrival
            // 
            this.pnArrival.Controls.Add(this.lbArrival);
            this.pnArrival.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnArrival.Location = new System.Drawing.Point(600, 0);
            this.pnArrival.Name = "pnArrival";
            this.pnArrival.Size = new System.Drawing.Size(150, 80);
            this.pnArrival.TabIndex = 13;
            // 
            // pnFlightTime
            // 
            this.pnFlightTime.Controls.Add(this.lbFlightTime);
            this.pnFlightTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnFlightTime.Location = new System.Drawing.Point(750, 0);
            this.pnFlightTime.Name = "pnFlightTime";
            this.pnFlightTime.Size = new System.Drawing.Size(140, 80);
            this.pnFlightTime.TabIndex = 14;
            // 
            // pnEmptySeat
            // 
            this.pnEmptySeat.Controls.Add(this.lbEmptySeat);
            this.pnEmptySeat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnEmptySeat.Location = new System.Drawing.Point(890, 0);
            this.pnEmptySeat.Name = "pnEmptySeat";
            this.pnEmptySeat.Size = new System.Drawing.Size(100, 80);
            this.pnEmptySeat.TabIndex = 15;
            // 
            // lbFlightDetail
            // 
            this.lbFlightDetail.AutoSize = true;
            this.lbFlightDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFlightDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.lbFlightDetail.Location = new System.Drawing.Point(26, 53);
            this.lbFlightDetail.Name = "lbFlightDetail";
            this.lbFlightDetail.Size = new System.Drawing.Size(118, 16);
            this.lbFlightDetail.TabIndex = 17;
            this.lbFlightDetail.Text = "Chi tiết chuyến bay";
            this.lbFlightDetail.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // pibDelete
            // 
            this.pibDelete.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.DeleteIcon;
            this.pibDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDelete.Location = new System.Drawing.Point(220, 10);
            this.pibDelete.Name = "pibDelete";
            this.pibDelete.Size = new System.Drawing.Size(40, 40);
            this.pibDelete.TabIndex = 19;
            this.pibDelete.TabStop = false;
            this.pibDelete.Click += new System.EventHandler(this.pibDelete_Click);
            // 
            // pibEdit
            // 
            this.pibEdit.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.EditIcon;
            this.pibEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibEdit.Location = new System.Drawing.Point(170, 10);
            this.pibEdit.Name = "pibEdit";
            this.pibEdit.Size = new System.Drawing.Size(40, 40);
            this.pibEdit.TabIndex = 18;
            this.pibEdit.TabStop = false;
            this.pibEdit.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // pnReservedSeat
            // 
            this.pnReservedSeat.Controls.Add(this.lbReservedSeat);
            this.pnReservedSeat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnReservedSeat.Location = new System.Drawing.Point(990, 0);
            this.pnReservedSeat.Name = "pnReservedSeat";
            this.pnReservedSeat.Size = new System.Drawing.Size(120, 80);
            this.pnReservedSeat.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.abtnBookTicket);
            this.panel8.Controls.Add(this.pibEdit);
            this.panel8.Controls.Add(this.pibDelete);
            this.panel8.Controls.Add(this.lbFlightDetail);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1110, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 80);
            this.panel8.TabIndex = 22;
            // 
            // abtnBookTicket
            // 
            this.abtnBookTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnBookTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnBookTicket.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnBookTicket.BorderRadius = 5;
            this.abtnBookTicket.BorderSize = 0;
            this.abtnBookTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnBookTicket.FlatAppearance.BorderSize = 0;
            this.abtnBookTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnBookTicket.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnBookTicket.ForeColor = System.Drawing.Color.White;
            this.abtnBookTicket.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnBookTicket.Location = new System.Drawing.Point(25, 8);
            this.abtnBookTicket.Name = "abtnBookTicket";
            this.abtnBookTicket.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnBookTicket.Size = new System.Drawing.Size(130, 40);
            this.abtnBookTicket.TabIndex = 16;
            this.abtnBookTicket.Text = "Đặt vé";
            this.abtnBookTicket.TextColor = System.Drawing.Color.White;
            this.abtnBookTicket.ThinknessLine = 0;
            this.abtnBookTicket.UseVisualStyleBackColor = false;
            this.abtnBookTicket.Click += new System.EventHandler(this.abtnBookTicket_Click);
            // 
            // FlightItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnReservedSeat);
            this.Controls.Add(this.pnEmptySeat);
            this.Controls.Add(this.pnFlightTime);
            this.Controls.Add(this.pnArrival);
            this.Controls.Add(this.pnArrivalAirport);
            this.Controls.Add(this.pnDeparture);
            this.Controls.Add(this.pnDepartureAirport);
            this.Controls.Add(this.pnFlightID);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FlightItemUC";
            this.Size = new System.Drawing.Size(1400, 80);
            this.pnFlightID.ResumeLayout(false);
            this.pnFlightID.PerformLayout();
            this.pnDepartureAirport.ResumeLayout(false);
            this.pnDepartureAirport.PerformLayout();
            this.pnDeparture.ResumeLayout(false);
            this.pnDeparture.PerformLayout();
            this.pnArrivalAirport.ResumeLayout(false);
            this.pnArrivalAirport.PerformLayout();
            this.pnArrival.ResumeLayout(false);
            this.pnArrival.PerformLayout();
            this.pnFlightTime.ResumeLayout(false);
            this.pnFlightTime.PerformLayout();
            this.pnEmptySeat.ResumeLayout(false);
            this.pnEmptySeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).EndInit();
            this.pnReservedSeat.ResumeLayout(false);
            this.pnReservedSeat.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbDepartureAirport;
        private Panel pnFlightID;
        private Label lbFlightTime;
        private Label lbEmptySeat;
        private Label lbReservedSeat;
        private Panel pnDepartureAirport;
        private Label lbDeparture;
        private Panel pnDeparture;
        private Label lbArrivalAirport;
        private Panel pnArrivalAirport;
        private Label lbArrival;
        private Panel pnArrival;
        private Panel pnFlightTime;
        private Panel pnEmptySeat;
        private AControls.AButton abtnBookTicket;
        private Label lbFlightDetail;
        private PictureBox pibEdit;
        private PictureBox pibDelete;
        private Label lbFlightID;
        private Panel pnReservedSeat;
        private Panel panel8;
    }
}
