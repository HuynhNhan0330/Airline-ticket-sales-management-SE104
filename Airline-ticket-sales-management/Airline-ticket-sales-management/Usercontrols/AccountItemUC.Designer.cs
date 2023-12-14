namespace Airline_ticket_sales_management.Usercontrols
{
    partial class AccountItemUC
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
            this.pnName = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.pnCreated = new System.Windows.Forms.Panel();
            this.lbCreated = new System.Windows.Forms.Label();
            this.pnPermission = new System.Windows.Forms.Panel();
            this.lbPermission = new System.Windows.Forms.Label();
            this.pnName.SuspendLayout();
            this.pnCreated.SuspendLayout();
            this.pnPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnName
            // 
            this.pnName.Controls.Add(this.lbName);
            this.pnName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnName.Location = new System.Drawing.Point(0, 0);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(220, 50);
            this.pnName.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbName.Location = new System.Drawing.Point(20, 15);
            this.lbName.MaximumSize = new System.Drawing.Size(190, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(168, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Huỳnh Mai Cao Nhân";
            // 
            // pnCreated
            // 
            this.pnCreated.Controls.Add(this.lbCreated);
            this.pnCreated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnCreated.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCreated.Location = new System.Drawing.Point(220, 0);
            this.pnCreated.Name = "pnCreated";
            this.pnCreated.Size = new System.Drawing.Size(150, 50);
            this.pnCreated.TabIndex = 1;
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCreated.Location = new System.Drawing.Point(35, 15);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(91, 20);
            this.lbCreated.TabIndex = 0;
            this.lbCreated.Text = "20/10/2003";
            // 
            // pnPermission
            // 
            this.pnPermission.Controls.Add(this.lbPermission);
            this.pnPermission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPermission.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPermission.Location = new System.Drawing.Point(370, 0);
            this.pnPermission.Name = "pnPermission";
            this.pnPermission.Size = new System.Drawing.Size(200, 50);
            this.pnPermission.TabIndex = 2;
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPermission.Location = new System.Drawing.Point(30, 15);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(138, 20);
            this.lbPermission.TabIndex = 0;
            this.lbPermission.Text = "Siêu quản trị viên";
            // 
            // AccountItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnPermission);
            this.Controls.Add(this.pnCreated);
            this.Controls.Add(this.pnName);
            this.Name = "AccountItemUC";
            this.Size = new System.Drawing.Size(570, 50);
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            this.pnCreated.ResumeLayout(false);
            this.pnCreated.PerformLayout();
            this.pnPermission.ResumeLayout(false);
            this.pnPermission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnCreated;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Panel pnPermission;
        private System.Windows.Forms.Label lbPermission;
    }
}
