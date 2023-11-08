namespace Airline_ticket_sales_management.AControls
{
    partial class AMessageBoxFrm
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
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.lbCaption = new System.Windows.Forms.Label();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.pnTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.pnBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.Controls.Add(this.lbCaption);
            this.pnTitleBar.Controls.Add(this.ptbClose);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(3, 0);
            this.pnTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(644, 45);
            this.pnTitleBar.TabIndex = 0;
            // 
            // lbCaption
            // 
            this.lbCaption.AutoSize = true;
            this.lbCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCaption.ForeColor = System.Drawing.Color.White;
            this.lbCaption.Location = new System.Drawing.Point(25, 8);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(96, 29);
            this.lbCaption.TabIndex = 1;
            this.lbCaption.Text = "Caption";
            // 
            // ptbClose
            // 
            this.ptbClose.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.CloseIcon2;
            this.ptbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbClose.Location = new System.Drawing.Point(600, 12);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(20, 20);
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnBody.Controls.Add(this.lbMessage);
            this.pnBody.Controls.Add(this.ptbIcon);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(3, 45);
            this.pnBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(644, 152);
            this.pnBody.TabIndex = 1;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lbMessage.Location = new System.Drawing.Point(100, 24);
            this.lbMessage.MaximumSize = new System.Drawing.Size(520, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(125, 22);
            this.lbMessage.TabIndex = 1;
            this.lbMessage.Text = "label message";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbIcon
            // 
            this.ptbIcon.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.ErrorIcon;
            this.ptbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbIcon.Location = new System.Drawing.Point(25, 10);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(52, 52);
            this.ptbIcon.TabIndex = 0;
            this.ptbIcon.TabStop = false;
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnButton.Controls.Add(this.btnNo);
            this.pnButton.Controls.Add(this.btnAccept);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(3, 127);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(644, 70);
            this.pnButton.TabIndex = 0;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.IndianRed;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(350, 10);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(100, 50);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Không";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(200, 10);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 50);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Có";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // AMessageBoxFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(650, 200);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AMessageBoxFrm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMessageBox";
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.Label lbCaption;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnNo;
    }
}