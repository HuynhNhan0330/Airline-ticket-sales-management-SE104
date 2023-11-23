using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class PlaneItemUC
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
            this.pnSeatCount = new System.Windows.Forms.Panel();
            this.lbSeatCount = new System.Windows.Forms.Label();
            this.pnPlaneName = new System.Windows.Forms.Panel();
            this.lbPlaneName = new System.Windows.Forms.Label();
            this.pnPlaneID = new System.Windows.Forms.Panel();
            this.lbPlaneID = new System.Windows.Forms.Label();
            this.pnControl = new System.Windows.Forms.Panel();
            this.abtnViewDetail = new Airline_ticket_sales_management.AControls.AButton();
            this.pibEdit = new System.Windows.Forms.PictureBox();
            this.pibDelete = new System.Windows.Forms.PictureBox();
            this.pnSeatCount.SuspendLayout();
            this.pnPlaneName.SuspendLayout();
            this.pnPlaneID.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSeatCount
            // 
            this.pnSeatCount.Controls.Add(this.lbSeatCount);
            this.pnSeatCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSeatCount.Location = new System.Drawing.Point(700, 0);
            this.pnSeatCount.Name = "pnSeatCount";
            this.pnSeatCount.Size = new System.Drawing.Size(300, 56);
            this.pnSeatCount.TabIndex = 15;
            // 
            // lbSeatCount
            // 
            this.lbSeatCount.AutoSize = true;
            this.lbSeatCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbSeatCount.Location = new System.Drawing.Point(85, 19);
            this.lbSeatCount.MaximumSize = new System.Drawing.Size(270, 0);
            this.lbSeatCount.Name = "lbSeatCount";
            this.lbSeatCount.Size = new System.Drawing.Size(30, 24);
            this.lbSeatCount.TabIndex = 10;
            this.lbSeatCount.Text = "30";
            this.lbSeatCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPlaneName
            // 
            this.pnPlaneName.Controls.Add(this.lbPlaneName);
            this.pnPlaneName.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPlaneName.Location = new System.Drawing.Point(300, 0);
            this.pnPlaneName.Name = "pnPlaneName";
            this.pnPlaneName.Size = new System.Drawing.Size(400, 56);
            this.pnPlaneName.TabIndex = 14;
            // 
            // lbPlaneName
            // 
            this.lbPlaneName.AutoSize = true;
            this.lbPlaneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbPlaneName.Location = new System.Drawing.Point(110, 19);
            this.lbPlaneName.MaximumSize = new System.Drawing.Size(370, 0);
            this.lbPlaneName.Name = "lbPlaneName";
            this.lbPlaneName.Size = new System.Drawing.Size(78, 24);
            this.lbPlaneName.TabIndex = 10;
            this.lbPlaneName.Text = "Phi cơ 1";
            this.lbPlaneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPlaneID
            // 
            this.pnPlaneID.Controls.Add(this.lbPlaneID);
            this.pnPlaneID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnPlaneID.Location = new System.Drawing.Point(0, 0);
            this.pnPlaneID.Name = "pnPlaneID";
            this.pnPlaneID.Size = new System.Drawing.Size(300, 56);
            this.pnPlaneID.TabIndex = 13;
            // 
            // lbPlaneID
            // 
            this.lbPlaneID.AutoSize = true;
            this.lbPlaneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbPlaneID.Location = new System.Drawing.Point(55, 15);
            this.lbPlaneID.MaximumSize = new System.Drawing.Size(270, 0);
            this.lbPlaneID.Name = "lbPlaneID";
            this.lbPlaneID.Size = new System.Drawing.Size(84, 24);
            this.lbPlaneID.TabIndex = 0;
            this.lbPlaneID.Text = "Fne0001";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.abtnViewDetail);
            this.pnControl.Controls.Add(this.pibEdit);
            this.pnControl.Controls.Add(this.pibDelete);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(1000, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(400, 56);
            this.pnControl.TabIndex = 23;
            // 
            // abtnViewDetail
            // 
            this.abtnViewDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnViewDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnViewDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.abtnViewDetail.BorderRadius = 5;
            this.abtnViewDetail.BorderSize = 0;
            this.abtnViewDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abtnViewDetail.FlatAppearance.BorderSize = 0;
            this.abtnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnViewDetail.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnViewDetail.ForeColor = System.Drawing.Color.White;
            this.abtnViewDetail.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnViewDetail.Location = new System.Drawing.Point(20, 8);
            this.abtnViewDetail.Name = "abtnViewDetail";
            this.abtnViewDetail.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Full;
            this.abtnViewDetail.Size = new System.Drawing.Size(200, 40);
            this.abtnViewDetail.TabIndex = 16;
            this.abtnViewDetail.Text = "Xem chi tiết";
            this.abtnViewDetail.TextColor = System.Drawing.Color.White;
            this.abtnViewDetail.ThinknessLine = 0;
            this.abtnViewDetail.UseVisualStyleBackColor = false;
            this.abtnViewDetail.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // pibEdit
            // 
            this.pibEdit.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.EditIcon;
            this.pibEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibEdit.Location = new System.Drawing.Point(240, 8);
            this.pibEdit.Name = "pibEdit";
            this.pibEdit.Size = new System.Drawing.Size(50, 40);
            this.pibEdit.TabIndex = 18;
            this.pibEdit.TabStop = false;
            this.pibEdit.Click += new System.EventHandler(this.pibEdit_Click);
            // 
            // pibDelete
            // 
            this.pibDelete.BackgroundImage = global::Airline_ticket_sales_management.Properties.Resources.DeleteIcon;
            this.pibDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pibDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pibDelete.Location = new System.Drawing.Point(300, 8);
            this.pibDelete.Name = "pibDelete";
            this.pibDelete.Size = new System.Drawing.Size(50, 40);
            this.pibDelete.TabIndex = 19;
            this.pibDelete.TabStop = false;
            this.pibDelete.Click += new System.EventHandler(this.pibDelete_Click);
            // 
            // PlaneItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.pnSeatCount);
            this.Controls.Add(this.pnPlaneName);
            this.Controls.Add(this.pnPlaneID);
            this.Name = "PlaneItemUC";
            this.Size = new System.Drawing.Size(1400, 56);
            this.pnSeatCount.ResumeLayout(false);
            this.pnSeatCount.PerformLayout();
            this.pnPlaneName.ResumeLayout(false);
            this.pnPlaneName.PerformLayout();
            this.pnPlaneID.ResumeLayout(false);
            this.pnPlaneID.PerformLayout();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnSeatCount;
        private Label lbSeatCount;
        private Panel pnPlaneName;
        private Label lbPlaneName;
        private Panel pnPlaneID;
        private Label lbPlaneID;
        private Panel pnControl;
        private AControls.AButton abtnViewDetail;
        private PictureBox pibEdit;
        private PictureBox pibDelete;
    }
}
