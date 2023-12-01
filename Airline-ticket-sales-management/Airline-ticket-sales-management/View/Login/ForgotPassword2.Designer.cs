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
            lbReturn = new Label();
            label1 = new Label();
            aTextboxuc2 = new AControls.ATextboxUC();
            label4 = new Label();
            abtnGetOTP = new AControls.AButton();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbReturn
            // 
            lbReturn.AutoSize = true;
            lbReturn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbReturn.ForeColor = Color.FromArgb(113, 113, 122);
            lbReturn.Location = new Point(100, 434);
            lbReturn.Name = "lbReturn";
            lbReturn.Size = new Size(61, 18);
            lbReturn.TabIndex = 27;
            lbReturn.Text = "Quay lại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(113, 113, 122);
            label1.Location = new Point(100, 279);
            label1.Name = "label1";
            label1.Size = new Size(138, 18);
            label1.TabIndex = 26;
            label1.Text = "Đã gửi mã OTP vào";
            // 
            // aTextboxuc2
            // 
            aTextboxuc2.BackColor = Color.FromArgb(217, 221, 252);
            aTextboxuc2.BorderColor = Color.FromArgb(217, 221, 252);
            aTextboxuc2.BorderFocusColor = Color.FromArgb(217, 221, 252);
            aTextboxuc2.BorderRadius = 10;
            aTextboxuc2.BorderSize = 2;
            aTextboxuc2.Cursor = Cursors.IBeam;
            aTextboxuc2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aTextboxuc2.ForeColor = Color.Black;
            aTextboxuc2.Location = new Point(100, 310);
            aTextboxuc2.Margin = new Padding(4);
            aTextboxuc2.Multiline = false;
            aTextboxuc2.Name = "aTextboxuc2";
            aTextboxuc2.Padding = new Padding(7);
            aTextboxuc2.PasswordChar = false;
            aTextboxuc2.PlaceholderColor = Color.DarkGray;
            aTextboxuc2.PlaceholderText = "Mã OTP";
            aTextboxuc2.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            aTextboxuc2.Size = new Size(300, 37);
            aTextboxuc2.TabIndex = 25;
            aTextboxuc2.Texts = "";
            aTextboxuc2.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(96, 241);
            label4.MaximumSize = new Size(330, 0);
            label4.Name = "label4";
            label4.Size = new Size(210, 35);
            label4.TabIndex = 24;
            label4.Text = "Nhập mã OTP";
            // 
            // abtnGetOTP
            // 
            abtnGetOTP.BackColor = Color.FromArgb(128, 152, 249);
            abtnGetOTP.BackgroundColor = Color.FromArgb(128, 152, 249);
            abtnGetOTP.BorderColor = Color.PaleVioletRed;
            abtnGetOTP.BorderRadius = 20;
            abtnGetOTP.BorderSize = 0;
            abtnGetOTP.Cursor = Cursors.Hand;
            abtnGetOTP.FlatAppearance.BorderSize = 0;
            abtnGetOTP.FlatStyle = FlatStyle.Flat;
            abtnGetOTP.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            abtnGetOTP.ForeColor = Color.White;
            abtnGetOTP.LineType = AControls.AButton.LineStyles.None;
            abtnGetOTP.Location = new Point(100, 360);
            abtnGetOTP.Name = "abtnGetOTP";
            abtnGetOTP.RoundType = AControls.AButton.RoundStyles.Full;
            abtnGetOTP.Size = new Size(300, 37);
            abtnGetOTP.TabIndex = 23;
            abtnGetOTP.Text = "Gửi";
            abtnGetOTP.TextColor = Color.White;
            abtnGetOTP.ThinknessLine = 0;
            abtnGetOTP.UseVisualStyleBackColor = false;
            abtnGetOTP.Click += abtnGetOTP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 152, 249);
            label2.Location = new Point(234, 279);
            label2.Name = "label2";
            label2.Size = new Size(138, 18);
            label2.TabIndex = 28;
            label2.Text = "nhan@gmail.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 152, 249);
            label3.Location = new Point(211, 409);
            label3.Name = "label3";
            label3.Size = new Size(84, 18);
            label3.TabIndex = 29;
            label3.Text = "Gửi lại mã";
            // 
            // ForgotPassword2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbReturn);
            Controls.Add(label1);
            Controls.Add(aTextboxuc2);
            Controls.Add(label4);
            Controls.Add(abtnGetOTP);
            Name = "ForgotPassword2";
            Size = new Size(500, 668);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbReturn;
        private Label label1;
        private AControls.ATextboxUC aTextboxuc2;
        private Label label4;
        private AControls.AButton abtnGetOTP;
        private Label label2;
        private Label label3;
    }
}
