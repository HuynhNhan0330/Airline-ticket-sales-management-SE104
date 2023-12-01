using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class ForgotPassword3
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
            aTextboxuc3 = new AControls.ATextboxUC();
            pictureBox1 = new PictureBox();
            aTextboxuc4 = new AControls.ATextboxUC();
            atxbPassword2 = new AControls.ATextboxUC();
            pibHideViewPassword = new PictureBox();
            abtnSubmit = new AControls.AButton();
            atxbPassword1 = new AControls.ATextboxUC();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pibHideViewPassword).BeginInit();
            SuspendLayout();
            // 
            // aTextboxuc3
            // 
            aTextboxuc3.BackColor = Color.FromArgb(217, 221, 252);
            aTextboxuc3.BorderColor = Color.Transparent;
            aTextboxuc3.BorderFocusColor = Color.FromArgb(217, 221, 252);
            aTextboxuc3.BorderRadius = 0;
            aTextboxuc3.BorderSize = 2;
            aTextboxuc3.Cursor = Cursors.IBeam;
            aTextboxuc3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            aTextboxuc3.ForeColor = Color.Black;
            aTextboxuc3.Location = new Point(110, 343);
            aTextboxuc3.Margin = new Padding(4);
            aTextboxuc3.Multiline = false;
            aTextboxuc3.Name = "aTextboxuc3";
            aTextboxuc3.Padding = new Padding(7);
            aTextboxuc3.PasswordChar = true;
            aTextboxuc3.PlaceholderColor = Color.DarkGray;
            aTextboxuc3.PlaceholderText = "Nhập lại mật khẩu";
            aTextboxuc3.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            aTextboxuc3.Size = new Size(250, 35);
            aTextboxuc3.TabIndex = 28;
            aTextboxuc3.Texts = "";
            aTextboxuc3.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(217, 221, 252);
            pictureBox1.BackgroundImage = Properties.Resources.hide;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(361, 346);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // aTextboxuc4
            // 
            aTextboxuc4.BackColor = Color.FromArgb(217, 221, 252);
            aTextboxuc4.BorderColor = Color.FromArgb(217, 221, 252);
            aTextboxuc4.BorderFocusColor = Color.FromArgb(217, 221, 252);
            aTextboxuc4.BorderRadius = 10;
            aTextboxuc4.BorderSize = 2;
            aTextboxuc4.Cursor = Cursors.IBeam;
            aTextboxuc4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            aTextboxuc4.ForeColor = Color.Black;
            aTextboxuc4.Location = new Point(100, 342);
            aTextboxuc4.Margin = new Padding(4);
            aTextboxuc4.Multiline = false;
            aTextboxuc4.Name = "aTextboxuc4";
            aTextboxuc4.Padding = new Padding(7);
            aTextboxuc4.PasswordChar = true;
            aTextboxuc4.PlaceholderColor = Color.DarkGray;
            aTextboxuc4.PlaceholderText = "";
            aTextboxuc4.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            aTextboxuc4.Size = new Size(300, 37);
            aTextboxuc4.TabIndex = 26;
            aTextboxuc4.Texts = "";
            aTextboxuc4.UnderlinedStyle = false;
            // 
            // atxbPassword2
            // 
            atxbPassword2.BackColor = Color.FromArgb(217, 221, 252);
            atxbPassword2.BorderColor = Color.Transparent;
            atxbPassword2.BorderFocusColor = Color.FromArgb(217, 221, 252);
            atxbPassword2.BorderRadius = 0;
            atxbPassword2.BorderSize = 2;
            atxbPassword2.Cursor = Cursors.IBeam;
            atxbPassword2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            atxbPassword2.ForeColor = Color.Black;
            atxbPassword2.Location = new Point(110, 293);
            atxbPassword2.Margin = new Padding(4);
            atxbPassword2.Multiline = false;
            atxbPassword2.Name = "atxbPassword2";
            atxbPassword2.Padding = new Padding(7);
            atxbPassword2.PasswordChar = true;
            atxbPassword2.PlaceholderColor = Color.DarkGray;
            atxbPassword2.PlaceholderText = "Mật khẩu";
            atxbPassword2.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            atxbPassword2.Size = new Size(250, 35);
            atxbPassword2.TabIndex = 25;
            atxbPassword2.Texts = "";
            atxbPassword2.UnderlinedStyle = false;
            // 
            // pibHideViewPassword
            // 
            pibHideViewPassword.BackColor = Color.FromArgb(217, 221, 252);
            pibHideViewPassword.BackgroundImage = Properties.Resources.hide;
            pibHideViewPassword.BackgroundImageLayout = ImageLayout.Stretch;
            pibHideViewPassword.Cursor = Cursors.Hand;
            pibHideViewPassword.Location = new Point(361, 296);
            pibHideViewPassword.Name = "pibHideViewPassword";
            pibHideViewPassword.Size = new Size(32, 32);
            pibHideViewPassword.TabIndex = 23;
            pibHideViewPassword.TabStop = false;
            // 
            // abtnSubmit
            // 
            abtnSubmit.BackColor = Color.FromArgb(128, 152, 249);
            abtnSubmit.BackgroundColor = Color.FromArgb(128, 152, 249);
            abtnSubmit.BorderColor = Color.PaleVioletRed;
            abtnSubmit.BorderRadius = 20;
            abtnSubmit.BorderSize = 0;
            abtnSubmit.Cursor = Cursors.Hand;
            abtnSubmit.FlatAppearance.BorderSize = 0;
            abtnSubmit.FlatStyle = FlatStyle.Flat;
            abtnSubmit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            abtnSubmit.ForeColor = Color.White;
            abtnSubmit.LineType = AControls.AButton.LineStyles.None;
            abtnSubmit.Location = new Point(100, 392);
            abtnSubmit.Name = "abtnSubmit";
            abtnSubmit.RoundType = AControls.AButton.RoundStyles.Full;
            abtnSubmit.Size = new Size(300, 37);
            abtnSubmit.TabIndex = 24;
            abtnSubmit.Text = "Gửi";
            abtnSubmit.TextColor = Color.White;
            abtnSubmit.ThinknessLine = 0;
            abtnSubmit.UseVisualStyleBackColor = false;
            abtnSubmit.Click += abtnSubmit_Click;
            // 
            // atxbPassword1
            // 
            atxbPassword1.BackColor = Color.FromArgb(217, 221, 252);
            atxbPassword1.BorderColor = Color.FromArgb(217, 221, 252);
            atxbPassword1.BorderFocusColor = Color.FromArgb(217, 221, 252);
            atxbPassword1.BorderRadius = 10;
            atxbPassword1.BorderSize = 2;
            atxbPassword1.Cursor = Cursors.IBeam;
            atxbPassword1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            atxbPassword1.ForeColor = Color.Black;
            atxbPassword1.Location = new Point(100, 292);
            atxbPassword1.Margin = new Padding(4);
            atxbPassword1.Multiline = false;
            atxbPassword1.Name = "atxbPassword1";
            atxbPassword1.Padding = new Padding(7);
            atxbPassword1.PasswordChar = true;
            atxbPassword1.PlaceholderColor = Color.DarkGray;
            atxbPassword1.PlaceholderText = "";
            atxbPassword1.RoundType = AControls.ATextboxUC.RoundStyles.Full;
            atxbPassword1.Size = new Size(300, 37);
            atxbPassword1.TabIndex = 22;
            atxbPassword1.Texts = "";
            atxbPassword1.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(113, 113, 122);
            label1.Location = new Point(104, 262);
            label1.Name = "label1";
            label1.Size = new Size(303, 18);
            label1.TabIndex = 30;
            label1.Text = "Hoàn thành việc khôi phục mật khẩu của bạn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(100, 224);
            label4.MaximumSize = new Size(330, 0);
            label4.Name = "label4";
            label4.Size = new Size(292, 35);
            label4.TabIndex = 29;
            label4.Text = "Nhập mật khẩu mới";
            // 
            // ForgotPassword3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(aTextboxuc3);
            Controls.Add(pictureBox1);
            Controls.Add(aTextboxuc4);
            Controls.Add(atxbPassword2);
            Controls.Add(pibHideViewPassword);
            Controls.Add(abtnSubmit);
            Controls.Add(atxbPassword1);
            Name = "ForgotPassword3";
            Size = new Size(500, 668);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pibHideViewPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AControls.ATextboxUC aTextboxuc3;
        private PictureBox pictureBox1;
        private AControls.ATextboxUC aTextboxuc4;
        private AControls.ATextboxUC atxbPassword2;
        private PictureBox pibHideViewPassword;
        private AControls.AButton abtnSubmit;
        private AControls.ATextboxUC atxbPassword1;
        private Label label1;
        private Label label4;
    }
}
