using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket_sales_management
{
    public class RoundedRectangle
    {
        public static GraphicsPath Create(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            
            return path;
        }

        public static GraphicsPath Create(int width, int height, int radius)
        {
            RectangleF rect = new RectangleF(0, 0, width, height);
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static GraphicsPath CreateTop(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y);
            
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom);
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y + radius);
            
            path.CloseFigure();

            return path;
        }

        /// <summary>
        /// Bo tròn hình ở dưới
        /// </summary>
        /// <param name="rect"> Hình chữu nhật để bo tròn</param>
        /// <param name="radius"> Bán kính bo tròn</param>
        /// <returns></returns>
        public static GraphicsPath CreateBottom(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // Vẽ góc bo tròn ở phía dưới bên trái
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);

            // Trái dưới -> Phải dưới
            path.AddLine(rect.X + radius, rect.Bottom, rect.Right - radius, rect.Bottom);

            // Vẽ góc bo tròn ở phía dưới bên phải
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);

            // Phải dưới -> phải trên
            path.AddLine(rect.Right, rect.Bottom - radius, rect.Right, rect.Y);

            // Phải trên -> Trái trên
            path.AddLine(rect.Right, rect.Y, rect.X, rect.Y);

            // Trái trên -> Trái dưới
            path.AddLine(rect.X, rect.Y, rect.X, rect.Bottom - radius);

            // Đóng đường dẫn
            path.CloseFigure();

            return path;
        }

        public static GraphicsPath CreateRight(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            // Vẽ đường thẳng từ góc trái trên đến góc phải trên (không vẽ góc bo tròn)
            path.AddLine(rect.X, rect.Y, rect.Right - radius, rect.Y);
            // Vẽ góc bo tròn trên góc phải trên
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            // Vẽ đường thẳng từ góc phải trên đến góc phải dưới (không vẽ góc bo tròn)
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom);
            // Vẽ góc bo tròn trên góc phải dưới
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            // Vẽ đường thẳng từ góc phải dưới đến góc trái dưới (không vẽ góc bo tròn)
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);
            // Vẽ đường thẳng từ góc trái dưới đến góc trái trên (không vẽ góc bo tròn)
            path.AddLine(rect.X, rect.Bottom, rect.X, rect.Y + radius);
            // Đóng đường dẫn
            path.CloseFigure();

            return path;
        }

        public static GraphicsPath CreateLeft(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.AddLine(rect.X, rect.Y + radius, rect.Right, rect.Y + radius);
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom);
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom);

            // Đóng đường dẫn
            path.CloseFigure();

            return path;
        }
    }
}
