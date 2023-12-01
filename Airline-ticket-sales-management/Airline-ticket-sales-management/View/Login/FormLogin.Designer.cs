namespace Airline_ticket_sales_management
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pibClose = new System.Windows.Forms.PictureBox();
            this.apnMain = new Airline_ticket_sales_management.AControls.APanel();
            this.loginUC1 = new Airline_ticket_sales_management.LoginUC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).BeginInit();
            this.apnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.flight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 600);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pibClose
            // 
            this.pibClose.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.CloseIcon2;
            this.pibClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibClose.Location = new System.Drawing.Point(960, 15);
            this.pibClose.Margin = new System.Windows.Forms.Padding(2);
            this.pibClose.Name = "pibClose";
            this.pibClose.Size = new System.Drawing.Size(24, 24);
            this.pibClose.TabIndex = 4;
            this.pibClose.TabStop = false;
            this.pibClose.Click += new System.EventHandler(this.pibClose_Click);
            // 
            // apnMain
            // 
            this.apnMain.BackColor = System.Drawing.Color.White;
            this.apnMain.BackgroundColor = System.Drawing.Color.White;
            this.apnMain.BorderColor = System.Drawing.Color.White;
            this.apnMain.BorderRadius = 40;
            this.apnMain.BorderSize = 0;
            this.apnMain.Controls.Add(this.loginUC1);
            this.apnMain.ForeColor = System.Drawing.Color.White;
            this.apnMain.Location = new System.Drawing.Point(550, 50);
            this.apnMain.Name = "apnMain";
            this.apnMain.RoundType = Airline_ticket_sales_management.AControls.APanel.RoundStyles.Full;
            this.apnMain.Size = new System.Drawing.Size(400, 500);
            this.apnMain.TabIndex = 0;
            this.apnMain.TextColor = System.Drawing.Color.White;
            // 
            // loginUC1
            // 
            this.loginUC1.BackColor = System.Drawing.Color.White;
            this.loginUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginUC1.Location = new System.Drawing.Point(0, 0);
            this.loginUC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(400, 500);
            this.loginUC1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(123)))), ((int)(((byte)(197)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pibClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.apnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibClose)).EndInit();
            this.apnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AControls.APanel apnMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LoginUC loginUC1;
        private System.Windows.Forms.PictureBox pibClose;
    }
}