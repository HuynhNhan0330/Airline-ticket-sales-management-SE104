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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pibReturn = new System.Windows.Forms.PictureBox();
            this.aPanel5 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbRePassword = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pibHideViewRePassword = new System.Windows.Forms.PictureBox();
            this.aPanel4 = new Airline_ticket_sales_management.AControls.APanel();
            this.atxbPassword = new Airline_ticket_sales_management.AControls.ATextboxUC();
            this.pibHideViewPassword = new System.Windows.Forms.PictureBox();
            this.abtnSubmit = new Airline_ticket_sales_management.AControls.AButton();
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).BeginInit();
            this.aPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewRePassword)).BeginInit();
            this.aPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(122)))));
            this.label1.Location = new System.Drawing.Point(39, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hoàn thành việc khôi phục mật khẩu của bạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 50);
            this.label4.MaximumSize = new System.Drawing.Size(330, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // pibReturn
            // 
            this.pibReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibReturn.Image = global::Airline_ticket_sales_management.Properties.Resources._return;
            this.pibReturn.Location = new System.Drawing.Point(20, 20);
            this.pibReturn.Name = "pibReturn";
            this.pibReturn.Size = new System.Drawing.Size(32, 32);
            this.pibReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibReturn.TabIndex = 39;
            this.pibReturn.TabStop = false;
            this.pibReturn.Click += new System.EventHandler(this.pibReturn_Click);
            // 
            // aPanel5
            // 
            this.aPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel5.BorderRadius = 10;
            this.aPanel5.BorderSize = 0;
            this.aPanel5.Controls.Add(this.atxbRePassword);
            this.aPanel5.Controls.Add(this.pibHideViewRePassword);
            this.aPanel5.ForeColor = System.Drawing.Color.White;
            this.aPanel5.Location = new System.Drawing.Point(50, 203);
            this.aPanel5.Name = "aPanel5";
            this.aPanel5.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel5.Size = new System.Drawing.Size(300, 37);
            this.aPanel5.TabIndex = 38;
            this.aPanel5.TextColor = System.Drawing.Color.White;
            // 
            // atxbRePassword
            // 
            this.atxbRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbRePassword.BorderColor = System.Drawing.Color.Transparent;
            this.atxbRePassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.atxbRePassword.BorderRadius = 0;
            this.atxbRePassword.BorderSize = 2;
            this.atxbRePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.atxbRePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atxbRePassword.ForeColor = System.Drawing.Color.Black;
            this.atxbRePassword.isFocused = false;
            this.atxbRePassword.isPlaceholder = true;
            this.atxbRePassword.Location = new System.Drawing.Point(19, 2);
            this.atxbRePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atxbRePassword.Multiline = false;
            this.atxbRePassword.Name = "atxbRePassword";
            this.atxbRePassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.atxbRePassword.PasswordChar = true;
            this.atxbRePassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.atxbRePassword.PlaceholderText = "Nhập lại mật khẩu";
            this.atxbRePassword.RoundType = Airline_ticket_sales_management.AControls.ATextboxUC.RoundStyles.Full;
            this.atxbRePassword.Size = new System.Drawing.Size(245, 33);
            this.atxbRePassword.TabIndex = 29;
            this.atxbRePassword.textAlign = Airline_ticket_sales_management.AControls.ATextboxUC.TextAlign.Left;
            this.atxbRePassword.Texts = "";
            this.atxbRePassword.UnderlinedStyle = false;
            // 
            // pibHideViewRePassword
            // 
            this.pibHideViewRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.pibHideViewRePassword.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.view;
            this.pibHideViewRePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibHideViewRePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibHideViewRePassword.Location = new System.Drawing.Point(271, 7);
            this.pibHideViewRePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pibHideViewRePassword.Name = "pibHideViewRePassword";
            this.pibHideViewRePassword.Size = new System.Drawing.Size(22, 22);
            this.pibHideViewRePassword.TabIndex = 25;
            this.pibHideViewRePassword.TabStop = false;
            this.pibHideViewRePassword.Click += new System.EventHandler(this.pibHideViewRePassword_Click);
            // 
            // aPanel4
            // 
            this.aPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.aPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aPanel4.BorderRadius = 10;
            this.aPanel4.BorderSize = 0;
            this.aPanel4.Controls.Add(this.atxbPassword);
            this.aPanel4.Controls.Add(this.pibHideViewPassword);
            this.aPanel4.ForeColor = System.Drawing.Color.White;
            this.aPanel4.Location = new System.Drawing.Point(50, 153);
            this.aPanel4.Name = "aPanel4";
            this.aPanel4.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.aPanel4.Size = new System.Drawing.Size(300, 37);
            this.aPanel4.TabIndex = 37;
            this.aPanel4.TextColor = System.Drawing.Color.White;
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
            // abtnSubmit
            // 
            this.abtnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnSubmit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(152)))), ((int)(((byte)(249)))));
            this.abtnSubmit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnSubmit.BorderRadius = 20;
            this.abtnSubmit.BorderSize = 0;
            this.abtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnSubmit.FlatAppearance.BorderSize = 0;
            this.abtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnSubmit.Font = new System.Drawing.Font("Arial", 10.8F);
            this.abtnSubmit.ForeColor = System.Drawing.Color.White;
            this.abtnSubmit.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnSubmit.Location = new System.Drawing.Point(52, 267);
            this.abtnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abtnSubmit.Name = "abtnSubmit";
            this.abtnSubmit.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnSubmit.Size = new System.Drawing.Size(300, 40);
            this.abtnSubmit.TabIndex = 24;
            this.abtnSubmit.Text = "Xác nhận";
            this.abtnSubmit.TextColor = System.Drawing.Color.White;
            this.abtnSubmit.ThinknessLine = 0;
            this.abtnSubmit.UseVisualStyleBackColor = false;
            this.abtnSubmit.Click += new System.EventHandler(this.abtnSubmit_Click_1);
            // 
            // ForgotPassword3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pibReturn);
            this.Controls.Add(this.aPanel5);
            this.Controls.Add(this.aPanel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.abtnSubmit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForgotPassword3";
            this.Size = new System.Drawing.Size(400, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pibReturn)).EndInit();
            this.aPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewRePassword)).EndInit();
            this.aPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibHideViewPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AControls.AButton abtnSubmit;
        private Label label1;
        private Label label4;
        private AControls.APanel aPanel5;
        private AControls.ATextboxUC atxbRePassword;
        private PictureBox pibHideViewRePassword;
        private AControls.APanel aPanel4;
        private AControls.ATextboxUC atxbPassword;
        private PictureBox pibHideViewPassword;
        private PictureBox pibReturn;
    }
}
