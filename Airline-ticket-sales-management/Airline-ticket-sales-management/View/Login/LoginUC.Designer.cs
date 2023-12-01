using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class LoginUC
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
            this.abtnLogin = new Airline_ticket_sales_management.AControls.AButton();
            this.lbRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.atxbPassword1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.atxbUsername = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.aTextboxuc1 = new Airline_ticket_sales_management.AControls.ATextboxUC();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // atxbPassword2
            // 
            this.atxbPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword2.BorderColor = System.Drawing.Color.Transparent;
            this.atxbPassword2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword2.BorderRadius = 10;
            this.atxbPassword2.BorderSize = 2;
            this.atxbPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbPassword2.ForeColor = System.Drawing.Color.Black;
            this.atxbPassword2.isPlaceholder = true;
            this.atxbPassword2.Location = new System.Drawing.Point(115, 261);
            this.atxbPassword2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPassword2.Multiline = false;
            this.atxbPassword2.Name = "atxbPassword2";
            this.atxbPassword2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPassword2.PasswordChar = true;
            this.atxbPassword2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPassword2.PlaceholderText = "Mật khẩu";
            this.atxbPassword2.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword2.Size = new System.Drawing.Size(245, 33);
            this.atxbPassword2.TabIndex = 29;
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
            this.pibHideViewPassword.Location = new System.Drawing.Point(367, 264);
            this.pibHideViewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibHideViewPassword.Name = "pibHideViewPassword";
            this.pibHideViewPassword.Size = new System.Drawing.Size(28, 22);
            this.pibHideViewPassword.TabIndex = 25;
            this.pibHideViewPassword.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(165, 172);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đăng nhập";
            // 
            // abtnLogin
            // 
            this.abtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnLogin.BorderRadius = 20;
            this.abtnLogin.BorderSize = 0;
            this.abtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnLogin.FlatAppearance.BorderSize = 0;
            this.abtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnLogin.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnLogin.ForeColor = System.Drawing.Color.White;
            this.abtnLogin.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnLogin.Location = new System.Drawing.Point(104, 319);
            this.abtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnLogin.Name = "abtnLogin";
            this.abtnLogin.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnLogin.Size = new System.Drawing.Size(300, 30);
            this.abtnLogin.TabIndex = 27;
            this.abtnLogin.Text = "Đăng nhập";
            this.abtnLogin.TextColor = System.Drawing.Color.White;
            this.abtnLogin.ThinknessLine = 0;
            this.abtnLogin.UseVisualStyleBackColor = false;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.lbRegister.Location = new System.Drawing.Point(288, 358);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(69, 18);
            this.lbRegister.TabIndex = 26;
            this.lbRegister.Text = "Đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(149, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chưa có tài khoản?";
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
            this.atxbPassword1.Location = new System.Drawing.Point(104, 259);
            this.atxbPassword1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPassword1.Multiline = false;
            this.atxbPassword1.Name = "atxbPassword1";
            this.atxbPassword1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPassword1.PasswordChar = true;
            this.atxbPassword1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPassword1.PlaceholderText = "";
            this.atxbPassword1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword1.Size = new System.Drawing.Size(300, 35);
            this.atxbPassword1.TabIndex = 23;
            this.atxbPassword1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPassword1.Texts = "";
            this.atxbPassword1.UnderlinedStyle = false;
            // 
            // atxbUsername
            // 
            this.atxbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderRadius = 0;
            this.atxbUsername.BorderSize = 2;
            this.atxbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.atxbUsername.ForeColor = System.Drawing.Color.Black;
            this.atxbUsername.isPlaceholder = true;
            this.atxbUsername.Location = new System.Drawing.Point(115, 223);
            this.atxbUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbUsername.Multiline = false;
            this.atxbUsername.Name = "atxbUsername";
            this.atxbUsername.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbUsername.PasswordChar = false;
            this.atxbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbUsername.PlaceholderText = "Email hoặc số điện thoại";
            this.atxbUsername.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbUsername.Size = new System.Drawing.Size(289, 35);
            this.atxbUsername.TabIndex = 22;
            this.atxbUsername.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbUsername.Texts = "";
            this.atxbUsername.UnderlinedStyle = false;
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lbForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.lbForgotPassword.Location = new System.Drawing.Point(272, 294);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(132, 22);
            this.lbForgotPassword.TabIndex = 30;
            this.lbForgotPassword.Text = "Quên mật khẩu";
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
            this.aTextboxuc1.isPlaceholder = false;
            this.aTextboxuc1.Location = new System.Drawing.Point(104, 223);
            this.aTextboxuc1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aTextboxuc1.Multiline = false;
            this.aTextboxuc1.Name = "aTextboxuc1";
            this.aTextboxuc1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.aTextboxuc1.PasswordChar = true;
            this.aTextboxuc1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.aTextboxuc1.PlaceholderText = "";
            this.aTextboxuc1.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.aTextboxuc1.Size = new System.Drawing.Size(300, 35);
            this.aTextboxuc1.TabIndex = 31;
            this.aTextboxuc1.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.aTextboxuc1.Texts = "";
            this.aTextboxuc1.UnderlinedStyle = false;
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.atxbPassword2);
            this.Controls.Add(this.pibHideViewPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnLogin);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.atxbPassword1);
            this.Controls.Add(this.atxbUsername);
            this.Controls.Add(this.aTextboxuc1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(500, 534);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC atxbPassword2;
        private PictureBox pibHideViewPassword;
        private Label label4;
        private AControls.AButton abtnLogin;
        private Label lbRegister;
        private Label label2;
        private AControls.ATextboxUC atxbPassword1;
        private AControls.ATextboxUC atxbUsername;
        private Label lbForgotPassword;
        private AControls.ATextboxUC aTextboxuc1;
    }
}
