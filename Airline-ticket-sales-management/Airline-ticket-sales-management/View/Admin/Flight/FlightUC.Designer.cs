using System.Drawing;
using System.Windows.Forms;

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
            this.pnMenuFlight = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.abtnDetailFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnCreateFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnListFlight = new Airline_ticket_sales_management.AControls.AButton();
            this.pnBodyFlight = new System.Windows.Forms.Panel();
            this.pnMenuFlight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuFlight
            // 
            this.pnMenuFlight.BackColor = System.Drawing.Color.Transparent;
            this.pnMenuFlight.Controls.Add(this.pnLine);
            this.pnMenuFlight.Controls.Add(this.abtnDetailFlight);
            this.pnMenuFlight.Controls.Add(this.abtnCreateFlight);
            this.pnMenuFlight.Controls.Add(this.abtnListFlight);
            this.pnMenuFlight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuFlight.Location = new System.Drawing.Point(0, 0);
            this.pnMenuFlight.Name = "pnMenuFlight";
            this.pnMenuFlight.Size = new System.Drawing.Size(1500, 85);
            this.pnMenuFlight.TabIndex = 2;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnLine.Location = new System.Drawing.Point(50, 82);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1398, 2);
            this.pnLine.TabIndex = 3;
            // 
            // abtnDetailFlight
            // 
            this.abtnDetailFlight.BackColor = System.Drawing.Color.Transparent;
            this.abtnDetailFlight.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnDetailFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnDetailFlight.BorderRadius = 30;
            this.abtnDetailFlight.BorderSize = 2;
            this.abtnDetailFlight.FlatAppearance.BorderSize = 0;
            this.abtnDetailFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnDetailFlight.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnDetailFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnDetailFlight.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnDetailFlight.Location = new System.Drawing.Point(1270, 25);
            this.abtnDetailFlight.Name = "abtnDetailFlight";
            this.abtnDetailFlight.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnDetailFlight.Size = new System.Drawing.Size(180, 60);
            this.abtnDetailFlight.TabIndex = 2;
            this.abtnDetailFlight.Text = "Chi tiết\r\nchuyến bay";
            this.abtnDetailFlight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnDetailFlight.ThinknessLine = 0;
            this.abtnDetailFlight.UseVisualStyleBackColor = false;
            // 
            // abtnCreateFlight
            // 
            this.abtnCreateFlight.BackColor = System.Drawing.Color.Transparent;
            this.abtnCreateFlight.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnCreateFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlight.BorderRadius = 30;
            this.abtnCreateFlight.BorderSize = 2;
            this.abtnCreateFlight.FlatAppearance.BorderSize = 0;
            this.abtnCreateFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCreateFlight.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCreateFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlight.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCreateFlight.Location = new System.Drawing.Point(280, 25);
            this.abtnCreateFlight.Name = "abtnCreateFlight";
            this.abtnCreateFlight.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnCreateFlight.Size = new System.Drawing.Size(180, 60);
            this.abtnCreateFlight.TabIndex = 1;
            this.abtnCreateFlight.Text = "Tạo chuyến\r\nbay mới";
            this.abtnCreateFlight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreateFlight.ThinknessLine = 0;
            this.abtnCreateFlight.UseVisualStyleBackColor = false;
            this.abtnCreateFlight.Click += new System.EventHandler(this.abtnCreateFlight_Click);
            // 
            // abtnListFlight
            // 
            this.abtnListFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnListFlight.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnListFlight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnListFlight.BorderRadius = 30;
            this.abtnListFlight.BorderSize = 2;
            this.abtnListFlight.FlatAppearance.BorderSize = 0;
            this.abtnListFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnListFlight.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnListFlight.ForeColor = System.Drawing.Color.White;
            this.abtnListFlight.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnListFlight.Location = new System.Drawing.Point(50, 25);
            this.abtnListFlight.Name = "abtnListFlight";
            this.abtnListFlight.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnListFlight.Size = new System.Drawing.Size(180, 60);
            this.abtnListFlight.TabIndex = 0;
            this.abtnListFlight.Text = "Danh sách\r\nchuyến bay";
            this.abtnListFlight.TextColor = System.Drawing.Color.White;
            this.abtnListFlight.ThinknessLine = 0;
            this.abtnListFlight.UseVisualStyleBackColor = false;
            this.abtnListFlight.Click += new System.EventHandler(this.abtnListFlight_Click);
            // 
            // pnBodyFlight
            // 
            this.pnBodyFlight.BackColor = System.Drawing.Color.Transparent;
            this.pnBodyFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBodyFlight.Location = new System.Drawing.Point(0, 85);
            this.pnBodyFlight.Name = "pnBodyFlight";
            this.pnBodyFlight.Size = new System.Drawing.Size(1500, 665);
            this.pnBodyFlight.TabIndex = 3;
            // 
            // FlightUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnBodyFlight);
            this.Controls.Add(this.pnMenuFlight);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(2)))), ((int)(((byte)(39)))));
            this.Name = "FlightUC";
            this.Size = new System.Drawing.Size(1500, 750);
            this.pnMenuFlight.ResumeLayout(false);
            this.ResumeLayout(false);

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
