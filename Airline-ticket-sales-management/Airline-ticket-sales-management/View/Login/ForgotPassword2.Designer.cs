using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class ForgotPassword2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.abtnAccept = new Airline_ticket_sales_management.AControls.AButton();
            this.lbGetOTP = new System.Windows.Forms.Label();
            this.aPanel1 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbOTP = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(134, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đã gửi mã OTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(95, 50);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 35);
            this.label4.TabIndex = 24;
            this.label4.Text = "Nhập mã OTP";
            // 
            // abtnAccept
            // 
            this.abtnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnAccept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnAccept.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnAccept.BorderRadius = 20;
            this.abtnAccept.BorderSize = 0;
            this.abtnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnAccept.FlatAppearance.BorderSize = 0;
            this.abtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnAccept.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnAccept.ForeColor = System.Drawing.Color.White;
            this.abtnAccept.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnAccept.Location = new System.Drawing.Point(50, 220);
            this.abtnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnAccept.Name = "abtnAccept";
            this.abtnAccept.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnAccept.Size = new System.Drawing.Size(300, 40);
            this.abtnAccept.TabIndex = 23;
            this.abtnAccept.Text = "Xác nhận";
            this.abtnAccept.TextColor = System.Drawing.Color.White;
            this.abtnAccept.ThinknessLine = 0;
            this.abtnAccept.UseVisualStyleBackColor = false;
            this.abtnAccept.Click += new System.EventHandler(this.abtnAccept_Click);
            // 
            // lbGetOTP
            // 
            this.lbGetOTP.AutoSize = true;
            this.lbGetOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGetOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbGetOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.lbGetOTP.Location = new System.Drawing.Point(266, 180);
            this.lbGetOTP.Name = "lbGetOTP";
            this.lbGetOTP.Size = new System.Drawing.Size(95, 18);
            this.lbGetOTP.TabIndex = 29;
            this.lbGetOTP.Text = "Gửi lại OTP";
            this.lbGetOTP.Click += new System.EventHandler(this.lbGetOTP_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 10;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.atxbOTP);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 136);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(300, 37);
            this.aPanel1.TabIndex = 32;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // atxbOTP
            // 
            this.atxbOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbOTP.BorderRadius = 0;
            this.atxbOTP.BorderSize = 2;
            this.atxbOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbOTP.ForeColor = System.Drawing.Color.Black;
            this.atxbOTP.isFocused = false;
            this.atxbOTP.isPlaceholder = true;
            this.atxbOTP.Location = new System.Drawing.Point(19, 2);
            this.atxbOTP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbOTP.Multiline = false;
            this.atxbOTP.Name = "atxbOTP";
            this.atxbOTP.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbOTP.PasswordChar = false;
            this.atxbOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbOTP.PlaceholderText = "Mã OTP";
            this.atxbOTP.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbOTP.Size = new System.Drawing.Size(267, 33);
            this.atxbOTP.TabIndex = 22;
            this.atxbOTP.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbOTP.Texts = "";
            this.atxbOTP.UnderlinedStyle = false;
            // 
            // pibReturn
            // 
            this.pibReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Image = global::Airline_ticket_sales_management.Properties.Resources._return;
            this.pibReturn.Location = new System.Drawing.Point(25, 25);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(32, 32);
            this.pibReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibReturn.TabIndex = 34;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // ForgotPassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pibReturn);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.lbGetOTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnAccept);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassword2";
            this.Size = new System.Drawing.Size(400, 500);
            this.aPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label4;
        private AControls.AButton abtnAccept;
        private Label lbGetOTP;
        private AControls.APanel aPanel1;
        private AControls.ATextboxUC atxbOTP;
        private PictureBox pibReturn;
    }
}
