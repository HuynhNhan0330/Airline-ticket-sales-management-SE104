using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class ForgotPassword1
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
            this.label4 = new System.Windows.Forms.Label();
            this.abtnGetOTP = new Airline_ticket_sales_management.AControls.AButton();
            this.aPanel1 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbEmail = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(85, 50);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 35);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quên mật khẩu";
            // 
            // abtnGetOTP
            // 
            this.abtnGetOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnGetOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnGetOTP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnGetOTP.BorderRadius = 20;
            this.abtnGetOTP.BorderSize = 0;
            this.abtnGetOTP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnGetOTP.FlatAppearance.BorderSize = 0;
            this.abtnGetOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnGetOTP.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnGetOTP.ForeColor = System.Drawing.Color.White;
            this.abtnGetOTP.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnGetOTP.Location = new System.Drawing.Point(50, 200);
            this.abtnGetOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnGetOTP.Name = "abtnGetOTP";
            this.abtnGetOTP.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnGetOTP.Size = new System.Drawing.Size(300, 40);
            this.abtnGetOTP.TabIndex = 18;
            this.abtnGetOTP.Text = "Lấy mã OTP";
            this.abtnGetOTP.TextColor = System.Drawing.Color.White;
            this.abtnGetOTP.ThinknessLine = 0;
            this.abtnGetOTP.UseVisualStyleBackColor = false;
            this.abtnGetOTP.Click += new System.EventHandler(this.abtnGetOTP_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 10;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.atxbEmail);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 136);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(300, 37);
            this.aPanel1.TabIndex = 32;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // atxbEmail
            // 
            this.atxbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbEmail.BorderRadius = 0;
            this.atxbEmail.BorderSize = 2;
            this.atxbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbEmail.ForeColor = System.Drawing.Color.Black;
            this.atxbEmail.isFocused = false;
            this.atxbEmail.isPlaceholder = true;
            this.atxbEmail.Location = new System.Drawing.Point(19, 2);
            this.atxbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbEmail.Multiline = false;
            this.atxbEmail.Name = "atxbEmail";
            this.atxbEmail.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbEmail.PasswordChar = false;
            this.atxbEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbEmail.PlaceholderText = "Email ";
            this.atxbEmail.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbEmail.Size = new System.Drawing.Size(267, 33);
            this.atxbEmail.TabIndex = 22;
            this.atxbEmail.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbEmail.Texts = "";
            this.atxbEmail.UnderlinedStyle = false;
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
            this.pibReturn.TabIndex = 33;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nhập email của bạn và nhận mã OTP để xác minh";
            // 
            // ForgotPassword1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pibReturn);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnGetOTP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassword1";
            this.Size = new System.Drawing.Size(400, 500);
            this.aPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private AControls.AButton abtnGetOTP;
        private AControls.APanel aPanel1;
        private AControls.ATextboxUC atxbEmail;
        private PictureBox pibReturn;
        private Label label1;
    }
}
