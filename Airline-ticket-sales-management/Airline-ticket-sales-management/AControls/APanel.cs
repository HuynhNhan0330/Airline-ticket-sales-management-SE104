using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.AControls
{
    public class APanel: Panel
    {
        #region property

        #region border size
        private int _BorderSize = 0;

        [Category("Extention")]
        public int BorderSize
        {
            get { return _BorderSize; }
            set
            {
                _BorderSize = value;
                this.Invalidate();
            }
        }
        #endregion

        #region border radius
        private int _BorderRadius = 0;

        [Category("Extention")]
        public int BorderRadius
        {
            get { return _BorderRadius; }
            set
            {
                _BorderRadius = value;
                this.Invalidate();
            }
        }
        #endregion

        #region border color
        private Color _BorderColor = Color.PaleVioletRed;

        [Category("Extention")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set
            {
                _BorderColor = value;
                this.Invalidate();
            }
        }
        #endregion

        #region background color
        [Category("Extention")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        #endregion

        #region text color
        [Category("Extention")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }
        #endregion

        #region round type
        public enum RoundStyles
        {
            Full,
            Top,
            Right,
        }

        private RoundStyles _RoundType = RoundStyles.Full;

        [Category("Extention")]
        public RoundStyles RoundType
        {
            get { return _RoundType; }
            set
            {
                _RoundType = value;
                this.Invalidate();
            }
        }
        #endregion

        #endregion

        //Constructor
        public APanel()
        {
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Panel_Resize);
        }

        //Methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -_BorderSize, -_BorderSize);
            int smoothSize = 2;
            if (_BorderSize > 0)
                smoothSize = _BorderSize;

            if (_BorderRadius > 2) //Rounded button
            {
                switch (_RoundType)
                {
                    case RoundStyles.Full:
                        using (GraphicsPath pathSurface = RoundedRectangle.Create(rectSurface, _BorderRadius))
                        using (GraphicsPath pathBorder = RoundedRectangle.Create(rectBorder, _BorderRadius - _BorderSize))
                            drawRound(smoothSize, pathSurface, pathBorder, pevent);
                        break;
                    case RoundStyles.Top:
                        using (GraphicsPath pathSurface = RoundedRectangle.CreateTop(rectSurface, _BorderRadius))
                        using (GraphicsPath pathBorder = RoundedRectangle.CreateTop(rectBorder, _BorderRadius - _BorderSize))
                            drawRound(smoothSize, pathSurface, pathBorder, pevent);
                        break;
                    case RoundStyles.Right:
                        using (GraphicsPath pathSurface = RoundedRectangle.CreateRight(rectSurface, _BorderRadius))
                        using (GraphicsPath pathBorder = RoundedRectangle.CreateRight(rectBorder, _BorderRadius - _BorderSize))
                            drawRound(smoothSize, pathSurface, pathBorder, pevent);
                        break;
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (_BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(_BorderColor, _BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        private void drawRound(int smoothSize, GraphicsPath pathSurface, GraphicsPath pathBorder, PaintEventArgs pevent)
        {
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(_BorderColor, _BorderSize))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                //Button surface
                this.Region = new Region(pathSurface);
                //Draw surface border for HD result
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                //Button border                    
                if (_BorderSize >= 1)
                    //Draw control border
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            if (_BorderRadius > this.Height)
                _BorderRadius = this.Height;
        }
    }
}
