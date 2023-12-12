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
            this.label4 = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.aPanel2 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbPassword = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pibHideViewPassword = new System.Windows.Forms.PictureBox();
            this.aPanel1 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbUsername = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.abtnLogin = new Airline_ticket_sales_management.AControls.AButton();
            this.aPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).BeginInit();
            this.aPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(115, 50);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 35);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đăng nhập";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.lbRegister.Location = new System.Drawing.Point(227, 363);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(69, 18);
            this.lbRegister.TabIndex = 26;
            this.lbRegister.Text = "Đăng ký";
            this.lbRegister.Visible = false;
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label2.Location = new System.Drawing.Point(88, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Chưa có tài khoản?";
            this.label2.Visible = false;
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.lbForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.lbForgotPassword.Location = new System.Drawing.Point(217, 250);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(132, 22);
            this.lbForgotPassword.TabIndex = 30;
            this.lbForgotPassword.Text = "Quên mật khẩu";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // aPanel2
            // 
            this.aPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel2.BorderRadius = 10;
            this.aPanel2.BorderSize = 0;
            this.aPanel2.Controls.Add(this.atxbPassword);
            this.aPanel2.Controls.Add(this.pibHideViewPassword);
            this.aPanel2.ForeColor = System.Drawing.Color.White;
            this.aPanel2.Location = new System.Drawing.Point(50, 200);
            this.aPanel2.Name = "aPanel2";
            this.aPanel2.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel2.Size = new System.Drawing.Size(300, 37);
            this.aPanel2.TabIndex = 32;
            this.aPanel2.TextColor = System.Drawing.Color.White;
            // 
            // atxbPassword
            // 
            this.atxbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword.BorderColor = System.Drawing.Color.Transparent;
            this.atxbPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbPassword.BorderRadius = 0;
            this.atxbPassword.BorderSize = 2;
            this.atxbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbPassword.ForeColor = System.Drawing.Color.Black;
            this.atxbPassword.isFocused = false;
            this.atxbPassword.isPlaceholder = true;
            this.atxbPassword.Location = new System.Drawing.Point(19, 2);
            this.atxbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbPassword.Multiline = false;
            this.atxbPassword.Name = "atxbPassword";
            this.atxbPassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbPassword.PasswordChar = true;
            this.atxbPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbPassword.PlaceholderText = "Mật khẩu";
            this.atxbPassword.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbPassword.Size = new System.Drawing.Size(245, 33);
            this.atxbPassword.TabIndex = 29;
            this.atxbPassword.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbPassword.Texts = "";
            this.atxbPassword.UnderlinedStyle = false;
            // 
            // pibHideViewPassword
            // 
            this.pibHideViewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.pibHideViewPassword.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.view;
            this.pibHideViewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHideViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHideViewPassword.Location = new System.Drawing.Point(271, 7);
            this.pibHideViewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibHideViewPassword.Name = "pibHideViewPassword";
            this.pibHideViewPassword.Size = new System.Drawing.Size(22, 22);
            this.pibHideViewPassword.TabIndex = 25;
            this.pibHideViewPassword.TabStop = false;
            this.pibHideViewPassword.Click += new System.EventHandler(this.pibHideViewPassword_Click);
            // 
            // aPanel1
            // 
            this.aPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel1.BorderRadius = 10;
            this.aPanel1.BorderSize = 0;
            this.aPanel1.Controls.Add(this.atxbUsername);
            this.aPanel1.ForeColor = System.Drawing.Color.White;
            this.aPanel1.Location = new System.Drawing.Point(50, 136);
            this.aPanel1.Name = "aPanel1";
            this.aPanel1.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel1.Size = new System.Drawing.Size(300, 37);
            this.aPanel1.TabIndex = 31;
            this.aPanel1.TextColor = System.Drawing.Color.White;
            // 
            // atxbUsername
            // 
            this.atxbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbUsername.BorderRadius = 0;
            this.atxbUsername.BorderSize = 2;
            this.atxbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbUsername.ForeColor = System.Drawing.Color.Black;
            this.atxbUsername.isFocused = false;
            this.atxbUsername.isPlaceholder = true;
            this.atxbUsername.Location = new System.Drawing.Point(19, 2);
            this.atxbUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbUsername.Multiline = false;
            this.atxbUsername.Name = "atxbUsername";
            this.atxbUsername.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbUsername.PasswordChar = false;
            this.atxbUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbUsername.PlaceholderText = "Email hoặc số điện thoại";
            this.atxbUsername.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbUsername.Size = new System.Drawing.Size(267, 33);
            this.atxbUsername.TabIndex = 22;
            this.atxbUsername.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbUsername.Texts = "";
            this.atxbUsername.UnderlinedStyle = false;
            // 
            // abtnLogin
            // 
            this.abtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnLogin.BorderRadius = 15;
            this.abtnLogin.BorderSize = 0;
            this.abtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnLogin.FlatAppearance.BorderSize = 0;
            this.abtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnLogin.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnLogin.ForeColor = System.Drawing.Color.White;
            this.abtnLogin.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnLogin.Location = new System.Drawing.Point(50, 302);
            this.abtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnLogin.Name = "abtnLogin";
            this.abtnLogin.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnLogin.Size = new System.Drawing.Size(300, 40);
            this.abtnLogin.TabIndex = 27;
            this.abtnLogin.Text = "Đăng nhập";
            this.abtnLogin.TextColor = System.Drawing.Color.White;
            this.abtnLogin.ThinknessLine = 0;
            this.abtnLogin.UseVisualStyleBackColor = false;
            this.abtnLogin.Click += new System.EventHandler(this.abtnLogin_Click);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aPanel2);
            this.Controls.Add(this.aPanel1);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnLogin);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(400, 500);
            this.aPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).EndInit();
            this.aPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AControls.ATextboxUC atxbPassword;
        private PictureBox pibHideViewPassword;
        private Label label4;
        private AControls.AButton abtnLogin;
        private Label lbRegister;
        private Label label2;
        private AControls.ATextboxUC atxbUsername;
        private Label lbForgotPassword;
        private AControls.APanel aPanel1;
        private AControls.APanel aPanel2;
    }
}
