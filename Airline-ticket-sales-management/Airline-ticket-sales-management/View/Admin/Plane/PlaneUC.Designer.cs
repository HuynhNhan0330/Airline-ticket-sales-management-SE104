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
            pnMenuPlane = new Panel();
            pnLine = new Panel();
            abtnDetailPlane = new AControls.AButton();
            abtnCreatePlane = new AControls.AButton();
            abtnPlaneList = new AControls.AButton();
            pnBodyPlane = new Panel();
            planeListUC1 = new PlaneListUC();
            pnMenuPlane.SuspendLayout();
            pnBodyPlane.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenuPlane
            // 
            pnMenuPlane.BackColor = Color.Transparent;
            pnMenuPlane.Controls.Add(pnLine);
            pnMenuPlane.Controls.Add(abtnDetailPlane);
            pnMenuPlane.Controls.Add(abtnCreatePlane);
            pnMenuPlane.Controls.Add(abtnPlaneList);
            pnMenuPlane.Dock = DockStyle.Top;
            pnMenuPlane.Location = new Point(0, 0);
            pnMenuPlane.Margin = new Padding(3, 4, 3, 4);
            pnMenuPlane.Name = "pnMenuPlane";
            pnMenuPlane.Size = new Size(1500, 105);
            pnMenuPlane.TabIndex = 3;
            // 
            // pnLine
            // 
            pnLine.BackColor = Color.FromArgb(3, 4, 94);
            pnLine.Location = new Point(50, 103);
            pnLine.Margin = new Padding(3, 4, 3, 4);
            pnLine.Name = "pnLine";
            pnLine.Size = new Size(1398, 2);
            pnLine.TabIndex = 3;
            // 
            // abtnDetailPlane
            // 
            abtnDetailPlane.BackColor = Color.Transparent;
            abtnDetailPlane.BackgroundColor = Color.Transparent;
            abtnDetailPlane.BorderColor = Color.FromArgb(3, 4, 94);
            abtnDetailPlane.BorderRadius = 30;
            abtnDetailPlane.BorderSize = 2;
            abtnDetailPlane.FlatAppearance.BorderSize = 0;
            abtnDetailPlane.FlatStyle = FlatStyle.Flat;
            abtnDetailPlane.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnDetailPlane.ForeColor = Color.FromArgb(3, 4, 94);
            abtnDetailPlane.LineType = AControls.AButton.LineStyles.None;
            abtnDetailPlane.Location = new Point(1340, 30);
            abtnDetailPlane.Margin = new Padding(3, 4, 3, 4);
            abtnDetailPlane.Name = "abtnDetailPlane";
            abtnDetailPlane.RoundType = AControls.AButton.RoundStyles.Top;
            abtnDetailPlane.Size = new Size(110, 75);
            abtnDetailPlane.TabIndex = 2;
            abtnDetailPlane.Text = "Chi tiết máy bay";
            abtnDetailPlane.TextColor = Color.FromArgb(3, 4, 94);
            abtnDetailPlane.ThinknessLine = 0;
            abtnDetailPlane.UseVisualStyleBackColor = false;
            abtnDetailPlane.Click += abtnDetailPlane_Click;
            // 
            // abtnCreatePlane
            // 
            abtnCreatePlane.BackColor = Color.Transparent;
            abtnCreatePlane.BackgroundColor = Color.Transparent;
            abtnCreatePlane.BorderColor = Color.FromArgb(3, 4, 94);
            abtnCreatePlane.BorderRadius = 30;
            abtnCreatePlane.BorderSize = 2;
            abtnCreatePlane.FlatAppearance.BorderSize = 0;
            abtnCreatePlane.FlatStyle = FlatStyle.Flat;
            abtnCreatePlane.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnCreatePlane.ForeColor = Color.FromArgb(3, 4, 94);
            abtnCreatePlane.LineType = AControls.AButton.LineStyles.None;
            abtnCreatePlane.Location = new Point(235, 30);
            abtnCreatePlane.Margin = new Padding(3, 4, 3, 4);
            abtnCreatePlane.Name = "abtnCreatePlane";
            abtnCreatePlane.RoundType = AControls.AButton.RoundStyles.Top;
            abtnCreatePlane.Size = new Size(130, 75);
            abtnCreatePlane.TabIndex = 1;
            abtnCreatePlane.Text = "Tạo máy bay mới";
            abtnCreatePlane.TextColor = Color.FromArgb(3, 4, 94);
            abtnCreatePlane.ThinknessLine = 0;
            abtnCreatePlane.UseVisualStyleBackColor = false;
            abtnCreatePlane.Click += abtnCreatePlane_Click;
            // 
            // abtnPlaneList
            // 
            abtnPlaneList.BackColor = Color.FromArgb(3, 4, 94);
            abtnPlaneList.BackgroundColor = Color.FromArgb(3, 4, 94);
            abtnPlaneList.BorderColor = Color.FromArgb(3, 4, 94);
            abtnPlaneList.BorderRadius = 30;
            abtnPlaneList.BorderSize = 2;
            abtnPlaneList.FlatAppearance.BorderSize = 0;
            abtnPlaneList.FlatStyle = FlatStyle.Flat;
            abtnPlaneList.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            abtnPlaneList.ForeColor = Color.White;
            abtnPlaneList.LineType = AControls.AButton.LineStyles.None;
            abtnPlaneList.Location = new Point(50, 30);
            abtnPlaneList.Margin = new Padding(3, 4, 3, 4);
            abtnPlaneList.Name = "abtnPlaneList";
            abtnPlaneList.RoundType = AControls.AButton.RoundStyles.Top;
            abtnPlaneList.Size = new Size(150, 75);
            abtnPlaneList.TabIndex = 0;
            abtnPlaneList.Text = "Danh sách máy bay";
            abtnPlaneList.TextColor = Color.White;
            abtnPlaneList.ThinknessLine = 0;
            abtnPlaneList.UseVisualStyleBackColor = false;
            abtnPlaneList.Click += abtnPlaneList_Click;
            // 
            // pnBodyPlane
            // 
            pnBodyPlane.BackColor = Color.Transparent;
            pnBodyPlane.Controls.Add(planeListUC1);
            pnBodyPlane.Dock = DockStyle.Fill;
            pnBodyPlane.Location = new Point(0, 105);
            pnBodyPlane.Margin = new Padding(3, 4, 3, 4);
            pnBodyPlane.Name = "pnBodyPlane";
            pnBodyPlane.Size = new Size(1500, 720);
            pnBodyPlane.TabIndex = 4;
            // 
            // planeListUC1
            // 
            planeListUC1.BackColor = Color.FromArgb(245, 245, 248);
            planeListUC1.Dock = DockStyle.Fill;
            planeListUC1.Location = new Point(0, 0);
            planeListUC1.Margin = new Padding(3, 5, 3, 5);
            planeListUC1.Name = "planeListUC1";
            planeListUC1.Size = new Size(1500, 720);
            planeListUC1.TabIndex = 0;
            // 
            // PlaneUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            Controls.Add(pnBodyPlane);
            Controls.Add(pnMenuPlane);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlaneUC";
            Size = new Size(1500, 825);
            pnMenuPlane.ResumeLayout(false);
            pnBodyPlane.ResumeLayout(false);
            ResumeLayout(false);
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
