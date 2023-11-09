using System.Drawing;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.Usercontrols
{
    partial class TicketClassItemUC
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
            panel20 = new Panel();
            label13 = new Label();
            panel19 = new Panel();
            label12 = new Label();
            panel15 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel20.SuspendLayout();
            panel19.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel20
            // 
            panel20.Controls.Add(label13);
            panel20.Dock = DockStyle.Left;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(150, 50);
            panel20.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(29, 14);
            label13.Name = "label13";
            label13.Size = new Size(92, 22);
            label13.TabIndex = 0;
            label13.Text = "Phổ thông";
            // 
            // panel19
            // 
            panel19.Controls.Add(label12);
            panel19.Dock = DockStyle.Left;
            panel19.Location = new Point(150, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(100, 50);
            panel19.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(22, 14);
            label12.Name = "label12";
            label12.Size = new Size(56, 22);
            label12.TabIndex = 0;
            label12.Text = "105%";
            // 
            // panel15
            // 
            panel15.Controls.Add(pictureBox2);
            panel15.Controls.Add(pictureBox1);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(250, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(100, 50);
            panel15.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.DeleteIcon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(48, 9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.EditIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // TicketClassItemUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel15);
            Controls.Add(panel19);
            Controls.Add(panel20);
            Name = "TicketClassItemUC";
            Size = new Size(350, 50);
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel20;
        private Label label13;
        private Panel panel19;
        private Label label12;
        private Panel panel15;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
