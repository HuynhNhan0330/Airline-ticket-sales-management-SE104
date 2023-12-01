using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class RegisterUC
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
            this.atxbPassword2 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pibHideViewPassword = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.abtnRegsiter = new Airline_ticket_sales_management.AControls.AButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atxbPassword1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbUsername = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc2 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.aTextboxuc3 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aTextboxuc4 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // atxbPassword2
            // 
            this.atxbPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword2.BorderColor = System.Drawing.Color.Transparent;
            this.atxbPassword2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword2.BorderRadius = 0;
            this.atxbPassword2.BorderSize = 2;
            this.atxbPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbPassword2.ForeColor = System.Drawing.Color.Black;
            this.atxbPassword2.isPlaceholder = true;
            this.atxbPassword2.Location = new System.Drawing.Point(36, 212);
            this.atxbPassword2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPassword2.Multiline = false;
            this.atxbPassword2.Name = "atxbPassword2";
            this.atxbPassword2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPassword2.PasswordChar = true;
            this.atxbPassword2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPassword2.PlaceholderText = "Mật khẩu";
            this.atxbPassword2.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword2.Size = new System.Drawing.Size(250, 33);
            this.atxbPassword2.TabIndex = 16;
            this.atxbPassword2.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPassword2.Texts = "";
            this.atxbPassword2.UnderlinedStyle = false;
            // 
            // pibHideViewPassword
            // 
            this.pibHideViewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.pibHideViewPassword.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.hide;
            this.pibHideViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHideViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHideViewPassword.Location = new System.Drawing.Point(287, 214);
            this.pibHideViewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibHideViewPassword.Name = "pibHideViewPassword";
            this.pibHideViewPassword.Size = new System.Drawing.Size(32, 26);
            this.pibHideViewPassword.TabIndex = 12;
            this.pibHideViewPassword.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(72, 47);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tạo tài khoản";
            // 
            // abtnRegsiter
            // 
            this.abtnRegsiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnRegsiter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnRegsiter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnRegsiter.BorderRadius = 20;
            this.abtnRegsiter.BorderSize = 0;
            this.abtnRegsiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnRegsiter.FlatAppearance.BorderSize = 0;
            this.abtnRegsiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnRegsiter.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnRegsiter.ForeColor = System.Drawing.Color.White;
            this.abtnRegsiter.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnRegsiter.Location = new System.Drawing.Point(26, 291);
            this.abtnRegsiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnRegsiter.Name = "abtnRegsiter";
            this.abtnRegsiter.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnRegsiter.Size = new System.Drawing.Size(300, 30);
            this.abtnRegsiter.TabIndex = 14;
            this.abtnRegsiter.Text = "Đăng ký";
            this.abtnRegsiter.TextColor = System.Drawing.Color.White;
            this.abtnRegsiter.ThinknessLine = 0;
            this.abtnRegsiter.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(198, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(72, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đã có tài khoản?";
            // 
            // atxbPassword1
            // 
            this.atxbPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword1.BorderRadius = 10;
            this.atxbPassword1.BorderSize = 2;
            this.atxbPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbPassword1.ForeColor = System.Drawing.Color.Black;
            this.atxbPassword1.isPlaceholder = false;
            this.atxbPassword1.Location = new System.Drawing.Point(26, 211);
            this.atxbPassword1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPassword1.Multiline = false;
            this.atxbPassword1.Name = "atxbPassword1";
            this.atxbPassword1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPassword1.PasswordChar = true;
            this.atxbPassword1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPassword1.PlaceholderText = "";
            this.atxbPassword1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword1.Size = new System.Drawing.Size(300, 35);
            this.atxbPassword1.TabIndex = 9;
            this.atxbPassword1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPassword1.Texts = "";
            this.atxbPassword1.UnderlinedStyle = false;
            // 
            // atxbUsername
            // 
            this.atxbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderRadius = 10;
            this.atxbUsername.BorderSize = 2;
            this.atxbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbUsername.ForeColor = System.Drawing.Color.Black;
            this.atxbUsername.isPlaceholder = true;
            this.atxbUsername.Location = new System.Drawing.Point(26, 91);
            this.atxbUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbUsername.Multiline = false;
            this.atxbUsername.Name = "atxbUsername";
            this.atxbUsername.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbUsername.PasswordChar = false;
            this.atxbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbUsername.PlaceholderText = "Họ và tên";
            this.atxbUsername.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbUsername.Size = new System.Drawing.Size(300, 35);
            this.atxbUsername.TabIndex = 8;
            this.atxbUsername.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbUsername.Texts = "";
            this.atxbUsername.UnderlinedStyle = false;
            // 
            // aTextboxuc2
            // 
            this.aTextboxuc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc2.BorderRadius = 10;
            this.aTextboxuc2.BorderSize = 2;
            this.aTextboxuc2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aTextboxuc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc2.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc2.isPlaceholder = true;
            this.aTextboxuc2.Location = new System.Drawing.Point(26, 131);
            this.aTextboxuc2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc2.Multiline = false;
            this.aTextboxuc2.Name = "aTextboxuc2";
            this.aTextboxuc2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc2.PasswordChar = false;
            this.aTextboxuc2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc2.PlaceholderText = "Email";
            this.aTextboxuc2.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc2.Size = new System.Drawing.Size(300, 35);
            this.aTextboxuc2.TabIndex = 17;
            this.aTextboxuc2.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc2.Texts = "";
            this.aTextboxuc2.UnderlinedStyle = false;
            // 
            // aTextboxuc1
            // 
            this.aTextboxuc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc1.BorderRadius = 10;
            this.aTextboxuc1.BorderSize = 2;
            this.aTextboxuc1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aTextboxuc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc1.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc1.isPlaceholder = true;
            this.aTextboxuc1.Location = new System.Drawing.Point(26, 171);
            this.aTextboxuc1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc1.Multiline = false;
            this.aTextboxuc1.Name = "aTextboxuc1";
            this.aTextboxuc1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc1.PasswordChar = false;
            this.aTextboxuc1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc1.PlaceholderText = "Số điện thoại";
            this.aTextboxuc1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc1.Size = new System.Drawing.Size(300, 35);
            this.aTextboxuc1.TabIndex = 18;
            this.aTextboxuc1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc1.Texts = "";
            this.aTextboxuc1.UnderlinedStyle = false;
            // 
            // aTextboxuc3
            // 
            this.aTextboxuc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc3.BorderColor = System.Drawing.Color.Transparent;
            this.aTextboxuc3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc3.BorderRadius = 0;
            this.aTextboxuc3.BorderSize = 2;
            this.aTextboxuc3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aTextboxuc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aTextboxuc3.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc3.isPlaceholder = true;
            this.aTextboxuc3.Location = new System.Drawing.Point(36, 252);
            this.aTextboxuc3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc3.Multiline = false;
            this.aTextboxuc3.Name = "aTextboxuc3";
            this.aTextboxuc3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc3.PasswordChar = true;
            this.aTextboxuc3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc3.PlaceholderText = "Nhập lại mật khẩu";
            this.aTextboxuc3.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc3.Size = new System.Drawing.Size(250, 33);
            this.aTextboxuc3.TabIndex = 21;
            this.aTextboxuc3.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc3.Texts = "";
            this.aTextboxuc3.UnderlinedStyle = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.pictureBox1.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.hide;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(287, 254);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 26);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // aTextboxuc4
            // 
            this.aTextboxuc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aTextboxuc4.BorderRadius = 10;
            this.aTextboxuc4.BorderSize = 2;
            this.aTextboxuc4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aTextboxuc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.aTextboxuc4.ForeColor = System.Drawing.Color.Black;
            this.aTextboxuc4.isPlaceholder = false;
            this.aTextboxuc4.Location = new System.Drawing.Point(26, 251);
            this.aTextboxuc4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc4.Multiline = false;
            this.aTextboxuc4.Name = "aTextboxuc4";
            this.aTextboxuc4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc4.PasswordChar = true;
            this.aTextboxuc4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc4.PlaceholderText = "";
            this.aTextboxuc4.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc4.Size = new System.Drawing.Size(300, 35);
            this.aTextboxuc4.TabIndex = 19;
            this.aTextboxuc4.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc4.Texts = "";
            this.aTextboxuc4.UnderlinedStyle = false;
            // 
            // RegisterUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aTextboxuc3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aTextboxuc4);
            this.Controls.Add(this.aTextboxuc1);
            this.Controls.Add(this.aTextboxuc2);
            this.Controls.Add(this.atxbPassword2);
            this.Controls.Add(this.pibHideViewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnRegsiter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atxbPassword1);
            this.Controls.Add(this.atxbUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterUC";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC atxbPassword2;
        private PictureBox pibHideViewPassword;
        private Label label4;
        private AControls.AButton abtnRegsiter;
        private Label label3;
        private Label label2;
        private AControls.ATextboxUC atxbPassword1;
        private AControls.ATextboxUC atxbUsername;
        private AControls.ATextboxUC aTextboxuc2;
        private AControls.ATextboxUC aTextboxuc1;
        private AControls.ATextboxUC aTextboxuc3;
        private PictureBox pictureBox1;
        private AControls.ATextboxUC aTextboxuc4;
    }
}
