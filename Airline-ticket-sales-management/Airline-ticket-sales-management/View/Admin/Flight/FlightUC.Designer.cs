namespace Airline_ticket_sales_management
{
    partial class FlightUC
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
            abtnDetailFlight = new AControls.AButton();
            abtnCreateFlight = new AControls.AButton();
            abtnListFlight = new AControls.AButton();
            pnBodyFlight = new Panel();
            pnMenuFlight.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenuFlight
            // 
            pnMenuFlight.BackColor = Color.Transparent;
            pnMenuFlight.Controls.Add(pnLine);
            pnMenuFlight.Controls.Add(abtnDetailFlight);
            pnMenuFlight.Controls.Add(abtnCreateFlight);
            pnMenuFlight.Controls.Add(abtnListFlight);
            pnMenuFlight.Dock = DockStyle.Top;
            pnMenuFlight.Location = new Point(0, 0);
            pnMenuFlight.Margin = new Padding(3, 4, 3, 4);
            pnMenuFlight.Name = "pnMenuFlight";
            pnMenuFlight.Size = new Size(1500, 105);
            pnMenuFlight.TabIndex = 2;
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
            // abtnDetailFlight
            // 
            abtnDetailFlight.BackColor = Color.Transparent;
            abtnDetailFlight.BackgroundColor = Color.Transparent;
            abtnDetailFlight.BorderColor = Color.FromArgb(3, 4, 94);
            abtnDetailFlight.BorderRadius = 30;
            abtnDetailFlight.BorderSize = 2;
            abtnDetailFlight.FlatAppearance.BorderSize = 0;
            abtnDetailFlight.FlatStyle = FlatStyle.Flat;
            abtnDetailFlight.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnDetailFlight.ForeColor = Color.FromArgb(3, 4, 94);
            abtnDetailFlight.LineType = AControls.AButton.LineStyles.None;
            abtnDetailFlight.Location = new Point(1310, 30);
            abtnDetailFlight.Margin = new Padding(3, 4, 3, 4);
            abtnDetailFlight.Name = "abtnDetailFlight";
            abtnDetailFlight.RoundType = AControls.AButton.RoundStyles.Top;
            abtnDetailFlight.Size = new Size(140, 75);
            abtnDetailFlight.TabIndex = 2;
            abtnDetailFlight.Text = "Chi tiết chuyến bay";
            abtnDetailFlight.TextColor = Color.FromArgb(3, 4, 94);
            abtnDetailFlight.ThinknessLine = 0;
            abtnDetailFlight.UseVisualStyleBackColor = false;
            abtnDetailFlight.Click += abtnDetailFlight_Click;
            // 
            // abtnCreateFlight
            // 
            abtnCreateFlight.BackColor = Color.Transparent;
            abtnCreateFlight.BackgroundColor = Color.Transparent;
            abtnCreateFlight.BorderColor = Color.FromArgb(3, 4, 94);
            abtnCreateFlight.BorderRadius = 30;
            abtnCreateFlight.BorderSize = 2;
            abtnCreateFlight.FlatAppearance.BorderSize = 0;
            abtnCreateFlight.FlatStyle = FlatStyle.Flat;
            abtnCreateFlight.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnCreateFlight.ForeColor = Color.FromArgb(3, 4, 94);
            abtnCreateFlight.LineType = AControls.AButton.LineStyles.None;
            abtnCreateFlight.Location = new Point(235, 30);
            abtnCreateFlight.Margin = new Padding(3, 4, 3, 4);
            abtnCreateFlight.Name = "abtnCreateFlight";
            abtnCreateFlight.RoundType = AControls.AButton.RoundStyles.Top;
            abtnCreateFlight.Size = new Size(150, 75);
            abtnCreateFlight.TabIndex = 1;
            abtnCreateFlight.Text = "Tạo chuyến bay mới";
            abtnCreateFlight.TextColor = Color.FromArgb(3, 4, 94);
            abtnCreateFlight.ThinknessLine = 0;
            abtnCreateFlight.UseVisualStyleBackColor = false;
            abtnCreateFlight.Click += abtnCreateFlight_Click;
            // 
            // abtnListFlight
            // 
            abtnListFlight.BackColor = Color.FromArgb(3, 4, 94);
            abtnListFlight.BackgroundColor = Color.FromArgb(3, 4, 94);
            abtnListFlight.BorderColor = Color.FromArgb(3, 4, 94);
            abtnListFlight.BorderRadius = 30;
            abtnListFlight.BorderSize = 2;
            abtnListFlight.FlatAppearance.BorderSize = 0;
            abtnListFlight.FlatStyle = FlatStyle.Flat;
            abtnListFlight.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnListFlight.ForeColor = Color.White;
            abtnListFlight.LineType = AControls.AButton.LineStyles.None;
            abtnListFlight.Location = new Point(50, 30);
            abtnListFlight.Margin = new Padding(3, 4, 3, 4);
            abtnListFlight.Name = "abtnListFlight";
            abtnListFlight.RoundType = AControls.AButton.RoundStyles.Top;
            abtnListFlight.Size = new Size(160, 75);
            abtnListFlight.TabIndex = 0;
            abtnListFlight.Text = "Danh sách chuyến bay";
            abtnListFlight.TextColor = Color.White;
            abtnListFlight.ThinknessLine = 0;
            abtnListFlight.UseVisualStyleBackColor = false;
            abtnListFlight.Click += abtnListFlight_Click;
            // 
            // pnBodyFlight
            // 
            pnBodyFlight.BackColor = Color.Transparent;
            pnBodyFlight.Dock = DockStyle.Fill;
            pnBodyFlight.Location = new Point(0, 105);
            pnBodyFlight.Margin = new Padding(3, 4, 3, 4);
            pnBodyFlight.Name = "pnBodyFlight";
            pnBodyFlight.Size = new Size(1500, 720);
            pnBodyFlight.TabIndex = 3;
            // 
            // FlightUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pnBodyFlight);
            Controls.Add(pnMenuFlight);
            ForeColor = Color.FromArgb(1, 2, 39);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FlightUC";
            Size = new Size(1500, 825);
            pnMenuFlight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnMenuFlight;
        private AControls.AButton abtnListFlight;
        private AControls.AButton abtnCreateFlight;
        private AControls.AButton abtnDetailFlight;
        private Panel pnLine;
        private Panel pnBodyFlight;
    }
}
