namespace Airline_ticket_sales_management.Usercontrols
{
    partial class PlaneSeatItemUC
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
            pn1 = new Panel();
            pn2 = new Panel();
            pn3 = new Panel();
            pn4 = new Panel();
            pn5 = new Panel();
            pn6 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn1
            // 
            pn1.BackColor = Color.Gray;
            pn1.Location = new Point(0, 0);
            pn1.Name = "pn1";
            pn1.Size = new Size(100, 100);
            pn1.TabIndex = 0;
            // 
            // pn2
            // 
            pn2.BackColor = Color.Gray;
            pn2.Location = new Point(125, 0);
            pn2.Name = "pn2";
            pn2.Size = new Size(100, 100);
            pn2.TabIndex = 1;
            // 
            // pn3
            // 
            pn3.BackColor = Color.Gray;
            pn3.Location = new Point(250, 0);
            pn3.Name = "pn3";
            pn3.Size = new Size(100, 100);
            pn3.TabIndex = 2;
            // 
            // pn4
            // 
            pn4.BackColor = Color.Gray;
            pn4.Location = new Point(450, 0);
            pn4.Name = "pn4";
            pn4.Size = new Size(100, 100);
            pn4.TabIndex = 3;
            // 
            // pn5
            // 
            pn5.BackColor = Color.Gray;
            pn5.Location = new Point(575, 0);
            pn5.Name = "pn5";
            pn5.Size = new Size(100, 100);
            pn5.TabIndex = 1;
            // 
            // pn6
            // 
            pn6.BackColor = Color.Gray;
            pn6.Location = new Point(700, 0);
            pn6.Name = "pn6";
            pn6.Size = new Size(100, 100);
            pn6.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(350, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 100);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(38, 39);
            label1.Name = "label1";
            label1.Size = new Size(23, 22);
            label1.TabIndex = 0;
            label1.Text = "A";
            // 
            // PlaneSeatItemUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(pn6);
            Controls.Add(pn5);
            Controls.Add(pn4);
            Controls.Add(pn3);
            Controls.Add(pn2);
            Controls.Add(pn1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PlaneSeatItemUC";
            Size = new Size(820, 100);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn1;
        private Panel pn2;
        private Panel pn3;
        private Panel pn4;
        private Panel pn5;
        private Panel pn6;
        private Panel panel1;
        private Label label1;
    }
}
