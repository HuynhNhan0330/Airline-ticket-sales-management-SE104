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
            pnMenuFlight = new Panel();
            pnLine = new Panel();
            abtnSearch = new AControls.AButton();
            abtnCreateFlightTicket = new AControls.AButton();
            pnBodyFlightTicket = new Panel();
            pnMenuFlight.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenuFlight
            // 
            pnMenuFlight.BackColor = Color.Transparent;
            pnMenuFlight.Controls.Add(pnLine);
            pnMenuFlight.Controls.Add(abtnSearch);
            pnMenuFlight.Controls.Add(abtnCreateFlightTicket);
            pnMenuFlight.Dock = DockStyle.Top;
            pnMenuFlight.Location = new Point(0, 0);
            pnMenuFlight.Margin = new Padding(3, 4, 3, 4);
            pnMenuFlight.Name = "pnMenuFlight";
            pnMenuFlight.Size = new Size(1500, 105);
            pnMenuFlight.TabIndex = 4;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.FromArgb(3, 4, 94);
            pnLine.Location = new Point(50, 103);
            pnLine.Margin = new Padding(3, 4, 3, 4);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(1398, 2);
            pnLine.TabIndex = 3;
            // 
            // abtnSearch
            // 
            abtnSearch.BackColor = Color.Transparent;
            abtnSearch.BackgroundColor = Color.Transparent;
            abtnSearch.BorderColor = Color.FromArgb(3, 4, 94);
            abtnSearch.BorderRadius = 30;
            abtnSearch.BorderSize = 2;
            abtnSearch.FlatAppearance.BorderSize = 0;
            abtnSearch.FlatStyle = FlatStyle.Flat;
            abtnSearch.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnSearch.ForeColor = Color.FromArgb(3, 4, 94);
            abtnSearch.LineType = AControls.AButton.LineStyles.None;
            abtnSearch.Location = new Point(225, 30);
            abtnSearch.Margin = new Padding(3, 4, 3, 4);
            abtnSearch.Name = "abtnSearch";
            abtnSearch.RoundType = AControls.AButton.RoundStyles.Top;
            abtnSearch.Size = new Size(139, 75);
            abtnSearch.TabIndex = 1;
            abtnSearch.Text = "Tra cứu";
            abtnSearch.TextColor = Color.FromArgb(3, 4, 94);
            abtnSearch.ThinknessLine = 0;
            abtnSearch.UseVisualStyleBackColor = false;
            abtnSearch.Click += abtnSearch_Click;
            // 
            // abtnCreateFlightTicket
            // 
            abtnCreateFlightTicket.BackColor = Color.FromArgb(3, 4, 94);
            abtnCreateFlightTicket.BackgroundColor = Color.FromArgb(3, 4, 94);
            abtnCreateFlightTicket.BorderColor = Color.FromArgb(3, 4, 94);
            abtnCreateFlightTicket.BorderRadius = 30;
            abtnCreateFlightTicket.BorderSize = 2;
            abtnCreateFlightTicket.FlatAppearance.BorderSize = 0;
            abtnCreateFlightTicket.FlatStyle = FlatStyle.Flat;
            abtnCreateFlightTicket.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnCreateFlightTicket.ForeColor = Color.White;
            abtnCreateFlightTicket.LineType = AControls.AButton.LineStyles.None;
            abtnCreateFlightTicket.Location = new Point(50, 30);
            abtnCreateFlightTicket.Margin = new Padding(3, 4, 3, 4);
            abtnCreateFlightTicket.Name = "abtnCreateFlightTicket";
            abtnCreateFlightTicket.RoundType = AControls.AButton.RoundStyles.Top;
            abtnCreateFlightTicket.Size = new Size(139, 75);
            abtnCreateFlightTicket.TabIndex = 0;
            abtnCreateFlightTicket.Text = "Tạo vé\r\nmáy bay";
            abtnCreateFlightTicket.TextColor = Color.White;
            abtnCreateFlightTicket.ThinknessLine = 0;
            abtnCreateFlightTicket.UseVisualStyleBackColor = false;
            abtnCreateFlightTicket.Click += abtnCreateFlightTicket_Click;
            // 
            // pnBodyFlightTicket
            // 
            pnBodyFlightTicket.Dock = DockStyle.Fill;
            pnBodyFlightTicket.Location = new Point(0, 105);
            pnBodyFlightTicket.Name = "pnBodyFlightTicket";
            pnBodyFlightTicket.Size = new Size(1500, 720);
            pnBodyFlightTicket.TabIndex = 5;
            // 
            // FlightTicketUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pnBodyFlightTicket);
            Controls.Add(pnMenuFlight);
            Name = "FlightTicketUC";
            Size = new Size(1500, 825);
            pnMenuFlight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenuFlight;
        private Panel pnLine;
        private AControls.AButton abtnSearch;
        private AControls.AButton abtnCreateFlightTicket;
        private Panel pnBodyFlightTicket;
    }
}
