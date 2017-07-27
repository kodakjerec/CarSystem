using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Workflow.ComponentModel.Design;

namespace Car_Fun
{
    enum buttonStyle
    {
        /// <summary>
        /// 正常爲選中按鈕
        /// </summary>
        ButtonNormal,
        /// <summary>
        /// 獲得焦點的按鈕
        /// </summary>
        ButtonFocuse,
        /// <summary>
        /// 鼠標經過樣式
        /// </summary>
        ButtonMouseOver,
        /// <summary>
        /// 獲得焦點並鼠標經過
        /// </summary>
        ButtonFocuseAndMouseOver,
        /// <summary>
        /// Button.Enable=false
        /// </summary>
        ButtonEnableFalse
    }
    /// <summary>
    /// 自定義GDI工具，繪製按鈕
    /// </summary>
    class Util_GDI
    {
        /// <summary>
        /// 繪製圓形按鈕（用法同矩形按鈕）
        /// </summary>
        /// <param name="text"></param>
        /// <param name="g"></param>
        /// <param name="Location"></param>
        /// <param name="r"></param>
        /// <param name="btnStyle"></param>
        public static void DrawCircleButton(string text, Graphics g, Point Location, int r, buttonStyle btnStyle)
        {
            Graphics Gcircle = g;
            Rectangle rect = new Rectangle(Location.X, Location.Y, r, r);
            Pen p = new Pen(new SolidBrush(Color.Black));
            Gcircle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Gcircle.DrawEllipse(p, rect);
            if (btnStyle == buttonStyle.ButtonFocuse)
            {
                Gcircle.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#338FCC")), rect);
            }
            else if (btnStyle == buttonStyle.ButtonMouseOver)
            {
                Gcircle.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#EAC100")), rect);
            }
            else if (btnStyle == buttonStyle.ButtonFocuseAndMouseOver)
            {
                Gcircle.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#EAC100")), rect);
            }

            p.DashStyle = DashStyle.Dash;
            if (btnStyle != buttonStyle.ButtonNormal)
            {

                Gcircle.DrawEllipse(p, new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4));//虛綫框
            }
            Gcircle.FillEllipse(new SolidBrush(Color.WhiteSmoke), new Rectangle(rect.X + 3, rect.Y + 3, rect.Width - 6, rect.Height - 6));

            #region 字型
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            Gcircle.DrawString(text, new Font("宋體", 10), new SolidBrush(Color.Black), rect, sf);
            #endregion

            p.Dispose();
        }
        /// <summary> 
        /// 繪製圓角按鈕
        /// </summary> 
        /// <param name="Text">要繪製的文字</param>
        /// <param name="g">Graphics 對象</param> 
        /// <param name="rect">要填充的矩形</param> 
        /// <param name="btnStyle"></param>
        public static void DrawRoundButton(Font font, string Text, Graphics g, Rectangle rect, buttonStyle btnStyle)
        {
            int 角度 = 10;
            g.SmoothingMode = SmoothingMode.AntiAlias;//消除鋸齒
            Brush b = b = new SolidBrush(Color.White);
            if (btnStyle == buttonStyle.ButtonFocuse)
            {
                b = new SolidBrush(ColorTranslator.FromHtml("#FFCC99"));
            }
            else if (btnStyle == buttonStyle.ButtonMouseOver)
            {
                b = new SolidBrush(ColorTranslator.FromHtml("#C6A300"));
            }
            else if (btnStyle == buttonStyle.ButtonFocuseAndMouseOver)
            {
                b = new SolidBrush(ColorTranslator.FromHtml("#C6A300"));
            }
            Pen p = new Pen(Color.Black, 0.5f);
            Pen p2 = new Pen(b);

            //繪製矩形
            g.DrawPath(p, GetRoundRectangle(rect, 角度));
            //填滿矩形
            g.FillPath(b, GetRoundRectangle(rect, 角度));

            rect = new Rectangle(rect.X, rect.Y + Convert.ToInt32(font.Size / 8), rect.Width, rect.Height);


            #region 字形顏色
            Brush FontColor = new SolidBrush(Color.Black);
            if (btnStyle == buttonStyle.ButtonEnableFalse)
            {
                FontColor = new SolidBrush(Color.Gray);
            }
            #endregion
            #region 字型
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString(Text, font, FontColor, rect, sf);
            #endregion

            p.Dispose();
            b.Dispose();
            g.SmoothingMode = SmoothingMode.Default;
        }

        /// <summary> 
        /// 根據普通矩形得到圓角矩形的路徑 
        /// </summary> 
        /// <param name="rectangle">原始矩形</param> 
        /// <param name="r">半徑</param> 
        /// <returns>圖形路徑</returns> 
        private static GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = 2 * r;
            // 把圓角矩形分成八段直綫、弧的組合，依次加到路徑中 
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);

            return gp;
        }
    }
}