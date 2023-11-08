using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.AControls
{
    public partial class AMessageBoxFrm : Form
    {
        //Fields
        private Color primaryColor = Color.CornflowerBlue;
        private int borderSize = 2;
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
                this.BackColor = primaryColor;//Form Border Color
                this.pnTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }

        public AMessageBoxFrm()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Constructors
        public AMessageBoxFrm(string text)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lbMessage.Text = text;
            this.lbCaption.Text = "";
            renderForm();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public AMessageBoxFrm(string text, string caption)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lbMessage.Text = text;
            this.lbCaption.Text = caption;
            renderForm();
            SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1);//Set Default Buttons
        }
        public AMessageBoxFrm(string text, string caption, MessageBoxButtons buttons)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lbMessage.Text = text;
            this.lbCaption.Text = caption;
            renderForm();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
        }
        public AMessageBoxFrm(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lbMessage.Text = text;
            this.lbCaption.Text = caption;
            renderForm();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
        public AMessageBoxFrm(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = primaryColor;
            this.lbMessage.Text = text;
            this.lbCaption.Text = caption;
            renderForm();
            SetButtons(buttons, defaultButton);
            SetIcon(icon);
        }

        ////-> Private Methods
        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize); //Set border size
            this.btnAccept.Visible = false;
            this.btnNo.Visible = false;
        }

        private void renderForm()
        {
            int widht = Math.Min(this.Width, this.lbMessage.Left + this.lbMessage.Width + 15);
            int height = this.pnTitleBar.Height + this.pnButton.Height + this.lbMessage.Top * 2 + this.lbMessage.Height;
            this.Size = new Size(widht, height);

            this.ptbClose.Left = this.Width - this.ptbClose.Width - 10;
        }

        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnButton.Width - btnAccept.Width) / 2;
            int yCenter = (this.pnButton.Height - btnAccept.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    btnAccept.Visible = true;
                    btnAccept.Location = new Point(xCenter, yCenter);
                    btnAccept.Text = "Đồng ý";
                    btnAccept.DialogResult = DialogResult.OK;//Set DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    btnAccept.Visible = true;
                    btnAccept.Location = new Point(xCenter - (btnAccept.Width / 2) - 5, yCenter);
                    btnAccept.Text = "Có";
                    btnAccept.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    btnNo.Visible = true;
                    btnNo.Location = new Point(xCenter + (btnNo.Width / 2) + 5, yCenter);
                    btnNo.Text = "Không";
                    btnNo.DialogResult = DialogResult.No;//Set DialogResult
                    btnNo.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                
            }
        }

        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1: //Focus button 1
                    btnAccept.Select();
                    btnAccept.ForeColor = Color.White;
                    btnAccept.Font = new Font(btnAccept.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2: //Focus button 2
                    btnNo.Select();
                    btnNo.ForeColor = Color.White;
                    btnNo.Font = new Font(btnNo.Font, FontStyle.Underline);
                    break;
            }
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.ptbIcon.BackgroundImage = Properties.Resources.ErrorIcon;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    break;
                case MessageBoxIcon.Information: //Information
                    this.ptbIcon.BackgroundImage = Properties.Resources.InformationIcon;
                    PrimaryColor = Color.FromArgb(33, 150, 243);
                    break;
                case MessageBoxIcon.Question://Question
                    this.ptbIcon.BackgroundImage = Properties.Resources.QuestionIcon;
                    PrimaryColor = Color.FromArgb(37, 183, 211);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.ptbIcon.BackgroundImage = Properties.Resources.ExclamationIcon;
                    PrimaryColor = Color.FromArgb(255, 180, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.ptbIcon.BackgroundImage = Properties.Resources.ChatIcon;
                    PrimaryColor = Color.CornflowerBlue;
                    break;
            }
        }
    }
}
