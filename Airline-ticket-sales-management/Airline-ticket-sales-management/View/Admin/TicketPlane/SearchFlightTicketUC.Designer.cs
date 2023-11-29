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
            aComboBox1 = new AControls.AComboBox();
            aTextboxuc1 = new AControls.ATextboxUC();
            aButton1 = new AControls.AButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // aComboBox1
            // 
            aComboBox1.BackColor = Color.White;
            aComboBox1.BorderColor = Color.FromArgb(3, 4, 94);
            aComboBox1.BorderSize = 1;
            aComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            aComboBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aComboBox1.ForeColor = Color.Black;
            aComboBox1.IconColor = Color.FromArgb(3, 4, 94);
            aComboBox1.Items.AddRange(new object[] { "Theo khách hàng", "Theo mã chuyến bay" });
            aComboBox1.ListBackColor = Color.FromArgb(3, 4, 94);
            aComboBox1.ListTextColor = Color.White;
            aComboBox1.Location = new Point(50, 30);
            aComboBox1.MinimumSize = new Size(200, 30);
            aComboBox1.Name = "aComboBox1";
            aComboBox1.Padding = new Padding(1);
            aComboBox1.Size = new Size(250, 38);
            aComboBox1.TabIndex = 0;
            aComboBox1.Texts = "";
            // 
            // aTextboxuc1
            // 
            aTextboxuc1.BackColor = SystemColors.Window;
            aTextboxuc1.BorderColor = Color.FromArgb(3, 4, 94);
            aTextboxuc1.BorderFocusColor = Color.FromArgb(0, 138, 184);
            aTextboxuc1.BorderRadius = 8;
            aTextboxuc1.BorderSize = 2;
            aTextboxuc1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aTextboxuc1.ForeColor = Color.DimGray;
            aTextboxuc1.Location = new Point(325, 30);
            aTextboxuc1.Margin = new Padding(4);
            aTextboxuc1.Multiline = false;
            aTextboxuc1.Name = "aTextboxuc1";
            aTextboxuc1.Padding = new Padding(7);
            aTextboxuc1.PasswordChar = false;
            aTextboxuc1.PlaceholderColor = Color.DarkGray;
            aTextboxuc1.PlaceholderText = "";
            aTextboxuc1.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            aTextboxuc1.Size = new Size(300, 37);
            aTextboxuc1.TabIndex = 1;
            aTextboxuc1.Texts = "";
            aTextboxuc1.UnderlinedStyle = false;
            // 
            // aButton1
            // 
            aButton1.BackColor = Color.FromArgb(3, 4, 94);
            aButton1.BackgroundColor = Color.FromArgb(3, 4, 94);
            aButton1.BorderColor = Color.PaleVioletRed;
            aButton1.BorderRadius = 20;
            aButton1.BorderSize = 0;
            aButton1.FlatAppearance.BorderSize = 0;
            aButton1.FlatStyle = FlatStyle.Flat;
            aButton1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            aButton1.ForeColor = Color.White;
            aButton1.LineType = AControls.AButton.LineStyles.None;
            aButton1.Location = new Point(650, 30);
            aButton1.Name = "aButton1";
            aButton1.RoundType = AControls.AButton.RoundStyles.Full;
            aButton1.Size = new Size(200, 38);
            aButton1.TabIndex = 2;
            aButton1.Text = "Tìm kiếm";
            aButton1.TextColor = Color.White;
            aButton1.ThinknessLine = 0;
            aButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(aComboBox1);
            panel1.Controls.Add(aButton1);
            panel1.Controls.Add(aTextboxuc1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 68);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(50, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1400, 71);
            panel2.TabIndex = 4;
            // 
            // SearchFlightTicketUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SearchFlightTicketUC";
            Size = new Size(1500, 720);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AControls.AComboBox aComboBox1;
        private AControls.ATextboxUC aTextboxuc1;
        private AControls.AButton aButton1;
        private Panel panel1;
        private Panel panel2;
    }
}
