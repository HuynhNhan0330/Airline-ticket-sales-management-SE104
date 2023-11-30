using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class FlightTicketUC
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
            this.pnMenuFlight = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.abtnSearch = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnCreateFlightTicket = new Airline_ticket_sales_management.AControls.AButton();
            this.pnBodyFlightTicket = new System.Windows.Forms.Panel();
            this.pnMenuFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuFlight
            // 
            this.pnMenuFlight.BackColor = System.Drawing.Color.Transparent;
            this.pnMenuFlight.Controls.Add(this.pnLine);
            this.pnMenuFlight.Controls.Add(this.abtnSearch);
            this.pnMenuFlight.Controls.Add(this.abtnCreateFlightTicket);
            this.pnMenuFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuFlight.Location = new System.Drawing.Point(0, 0);
            this.pnMenuFlight.Name = "pnMenuFlight";
            this.pnMenuFlight.Size = new System.Drawing.Size(1500, 85);
            this.pnMenuFlight.TabIndex = 4;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnLine.Location = new System.Drawing.Point(50, 82);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1398, 2);
            this.pnLine.TabIndex = 3;
            // 
            // abtnSearch
            // 
            this.abtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.abtnSearch.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.BorderRadius = 30;
            this.abtnSearch.BorderSize = 2;
            this.abtnSearch.FlatAppearance.BorderSize = 0;
            this.abtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnSearch.Location = new System.Drawing.Point(255, 24);
            this.abtnSearch.Name = "abtnSearch";
            this.abtnSearch.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnSearch.Size = new System.Drawing.Size(150, 60);
            this.abtnSearch.TabIndex = 1;
            this.abtnSearch.Text = "Tra cứu";
            this.abtnSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnSearch.ThinknessLine = 0;
            this.abtnSearch.UseVisualStyleBackColor = false;
            this.abtnSearch.Click += new System.EventHandler(this.abtnSearch_Click);
            // 
            // abtnCreateFlightTicket
            // 
            this.abtnCreateFlightTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlightTicket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlightTicket.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlightTicket.BorderRadius = 30;
            this.abtnCreateFlightTicket.BorderSize = 2;
            this.abtnCreateFlightTicket.FlatAppearance.BorderSize = 0;
            this.abtnCreateFlightTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCreateFlightTicket.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCreateFlightTicket.ForeColor = System.Drawing.Color.White;
            this.abtnCreateFlightTicket.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCreateFlightTicket.Location = new System.Drawing.Point(50, 24);
            this.abtnCreateFlightTicket.Name = "abtnCreateFlightTicket";
            this.abtnCreateFlightTicket.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnCreateFlightTicket.Size = new System.Drawing.Size(180, 60);
            this.abtnCreateFlightTicket.TabIndex = 0;
            this.abtnCreateFlightTicket.Text = "Tạo vé\r\nmáy bay";
            this.abtnCreateFlightTicket.TextColor = System.Drawing.Color.White;
            this.abtnCreateFlightTicket.ThinknessLine = 0;
            this.abtnCreateFlightTicket.UseVisualStyleBackColor = false;
            this.abtnCreateFlightTicket.Click += new System.EventHandler(this.abtnCreateFlightTicket_Click);
            // 
            // pnBodyFlightTicket
            // 
            this.pnBodyFlightTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBodyFlightTicket.Location = new System.Drawing.Point(0, 85);
            this.pnBodyFlightTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBodyFlightTicket.Name = "pnBodyFlightTicket";
            this.pnBodyFlightTicket.Size = new System.Drawing.Size(1500, 665);
            this.pnBodyFlightTicket.TabIndex = 5;
            // 
            // FlightTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnBodyFlightTicket);
            this.Controls.Add(this.pnMenuFlight);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightTicketUC";
            this.Size = new System.Drawing.Size(1500, 750);
            this.pnMenuFlight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnMenuFlight;
        private Panel pnLine;
        private AControls.AButton abtnSearch;
        private AControls.AButton abtnCreateFlightTicket;
        private Panel pnBodyFlightTicket;
    }
}
