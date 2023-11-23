using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management
{
    partial class PlaneUC
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
            this.pnMenuPlane = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.abtnDetailPlane = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnCreatePlane = new Airline_ticket_sales_management.AControls.AButton();
            this.abtnPlaneList = new Airline_ticket_sales_management.AControls.AButton();
            this.pnBodyPlane = new System.Windows.Forms.Panel();
            this.planeListUC1 = new Airline_ticket_sales_management.PlaneListUC();
            this.pnMenuPlane.SuspendLayout();
            this.pnBodyPlane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenuPlane
            // 
            this.pnMenuPlane.BackColor = System.Drawing.Color.Transparent;
            this.pnMenuPlane.Controls.Add(this.pnLine);
            this.pnMenuPlane.Controls.Add(this.abtnDetailPlane);
            this.pnMenuPlane.Controls.Add(this.abtnCreatePlane);
            this.pnMenuPlane.Controls.Add(this.abtnPlaneList);
            this.pnMenuPlane.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuPlane.Location = new System.Drawing.Point(0, 0);
            this.pnMenuPlane.Name = "pnMenuPlane";
            this.pnMenuPlane.Size = new System.Drawing.Size(1500, 85);
            this.pnMenuPlane.TabIndex = 3;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnLine.Location = new System.Drawing.Point(50, 82);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1398, 2);
            this.pnLine.TabIndex = 3;
            // 
            // abtnDetailPlane
            // 
            this.abtnDetailPlane.BackColor = System.Drawing.Color.Transparent;
            this.abtnDetailPlane.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnDetailPlane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnDetailPlane.BorderRadius = 30;
            this.abtnDetailPlane.BorderSize = 2;
            this.abtnDetailPlane.FlatAppearance.BorderSize = 0;
            this.abtnDetailPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnDetailPlane.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnDetailPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnDetailPlane.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnDetailPlane.Location = new System.Drawing.Point(1300, 24);
            this.abtnDetailPlane.Name = "abtnDetailPlane";
            this.abtnDetailPlane.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnDetailPlane.Size = new System.Drawing.Size(150, 60);
            this.abtnDetailPlane.TabIndex = 2;
            this.abtnDetailPlane.Text = "Chi tiết\r\nmáy bay";
            this.abtnDetailPlane.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnDetailPlane.ThinknessLine = 0;
            this.abtnDetailPlane.UseVisualStyleBackColor = false;
            // 
            // abtnCreatePlane
            // 
            this.abtnCreatePlane.BackColor = System.Drawing.Color.Transparent;
            this.abtnCreatePlane.BackgroundColor = System.Drawing.Color.Transparent;
            this.abtnCreatePlane.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreatePlane.BorderRadius = 30;
            this.abtnCreatePlane.BorderSize = 2;
            this.abtnCreatePlane.FlatAppearance.BorderSize = 0;
            this.abtnCreatePlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnCreatePlane.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnCreatePlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreatePlane.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnCreatePlane.Location = new System.Drawing.Point(250, 24);
            this.abtnCreatePlane.Name = "abtnCreatePlane";
            this.abtnCreatePlane.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnCreatePlane.Size = new System.Drawing.Size(150, 60);
            this.abtnCreatePlane.TabIndex = 1;
            this.abtnCreatePlane.Text = "Tạo máy\r\nbay mới";
            this.abtnCreatePlane.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnCreatePlane.ThinknessLine = 0;
            this.abtnCreatePlane.UseVisualStyleBackColor = false;
            this.abtnCreatePlane.Click += new System.EventHandler(this.abtnCreatePlane_Click);
            // 
            // abtnPlaneList
            // 
            this.abtnPlaneList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnPlaneList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnPlaneList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.abtnPlaneList.BorderRadius = 30;
            this.abtnPlaneList.BorderSize = 2;
            this.abtnPlaneList.FlatAppearance.BorderSize = 0;
            this.abtnPlaneList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtnPlaneList.Font = new System.Drawing.Font("Arial", 12F);
            this.abtnPlaneList.ForeColor = System.Drawing.Color.White;
            this.abtnPlaneList.LineType = Airline_ticket_sales_management.AControls.AButton.LineStyles.None;
            this.abtnPlaneList.Location = new System.Drawing.Point(50, 24);
            this.abtnPlaneList.Name = "abtnPlaneList";
            this.abtnPlaneList.RoundType = Airline_ticket_sales_management.AControls.AButton.RoundStyles.Top;
            this.abtnPlaneList.Size = new System.Drawing.Size(150, 60);
            this.abtnPlaneList.TabIndex = 0;
            this.abtnPlaneList.Text = "Danh sách máy bay";
            this.abtnPlaneList.TextColor = System.Drawing.Color.White;
            this.abtnPlaneList.ThinknessLine = 0;
            this.abtnPlaneList.UseVisualStyleBackColor = false;
            this.abtnPlaneList.Click += new System.EventHandler(this.abtnPlaneList_Click);
            // 
            // pnBodyPlane
            // 
            this.pnBodyPlane.BackColor = System.Drawing.Color.Transparent;
            this.pnBodyPlane.Controls.Add(this.planeListUC1);
            this.pnBodyPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBodyPlane.Location = new System.Drawing.Point(0, 85);
            this.pnBodyPlane.Name = "pnBodyPlane";
            this.pnBodyPlane.Size = new System.Drawing.Size(1500, 665);
            this.pnBodyPlane.TabIndex = 4;
            // 
            // planeListUC1
            // 
            this.planeListUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.planeListUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planeListUC1.Location = new System.Drawing.Point(0, 0);
            this.planeListUC1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.planeListUC1.Name = "planeListUC1";
            this.planeListUC1.Size = new System.Drawing.Size(1500, 665);
            this.planeListUC1.TabIndex = 0;
            // 
            // PlaneUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnBodyPlane);
            this.Controls.Add(this.pnMenuPlane);
            this.Name = "PlaneUC";
            this.Size = new System.Drawing.Size(1500, 750);
            this.pnMenuPlane.ResumeLayout(false);
            this.pnBodyPlane.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnMenuPlane;
        private Panel pnLine;
        private AControls.AButton abtnDetailPlane;
        private AControls.AButton abtnCreatePlane;
        private AControls.AButton abtnPlaneList;
        private Panel pnBodyPlane;
        private PlaneListUC planeListUC1;
    }
}
