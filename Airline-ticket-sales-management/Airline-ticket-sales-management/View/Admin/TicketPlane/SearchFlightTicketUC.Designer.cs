using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class SearchFlightTicketUC
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
            this.aTextboxuc1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aButton1 = new Airline_ticket_sales_management.AControls.AButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // aTextboxuc1
            // 
            this.aTextboxuc1.BackColor = System.Drawing.SystemColors.Window;
            this.aTextboxuc1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aTextboxuc1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(184)))));
            this.aTextboxuc1.BorderRadius = 8;
            this.aTextboxuc1.BorderSize = 2;
            this.aTextboxuc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc1.ForeColor = System.Drawing.Color.DimGray;
            this.aTextboxuc1.isPlaceholder = false;
            this.aTextboxuc1.Location = new System.Drawing.Point(325, 18);
            this.aTextboxuc1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc1.Multiline = false;
            this.aTextboxuc1.Name = "aTextboxuc1";
            this.aTextboxuc1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc1.PasswordChar = false;
            this.aTextboxuc1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc1.PlaceholderText = "";
            this.aTextboxuc1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc1.Size = new System.Drawing.Size(300, 35);
            this.aTextboxuc1.TabIndex = 1;
            this.aTextboxuc1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc1.Texts = "";
            this.aTextboxuc1.UnderlinedStyle = false;
            // 
            // aButton1
            // 
            this.aButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.aButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aButton1.BorderRadius = 20;
            this.aButton1.BorderSize = 0;
            this.aButton1.FlatAppearance.BorderSize = 0;
            this.aButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aButton1.Font = new System.Drawing.Font("Arial", 12F);
            this.aButton1.ForeColor = System.Drawing.Color.White;
            this.aButton1.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.aButton1.Location = new System.Drawing.Point(650, 24);
            this.aButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aButton1.Name = "aButton1";
            this.aButton1.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.aButton1.Size = new System.Drawing.Size(200, 30);
            this.aButton1.TabIndex = 2;
            this.aButton1.Text = "Tìm kiếm";
            this.aButton1.TextColor = System.Drawing.Color.White;
            this.aButton1.ThinknessLine = 0;
            this.aButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.aButton1);
            this.panel1.Controls.Add(this.aTextboxuc1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 54);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(50, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 57);
            this.panel2.TabIndex = 4;
            // 
            // SearchFlightTicketUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchFlightTicketUC";
            this.Size = new System.Drawing.Size(1500, 665);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.ATextboxUC aTextboxuc1;
        private AControls.AButton aButton1;
        private Panel panel1;
        private Panel panel2;
    }
}
