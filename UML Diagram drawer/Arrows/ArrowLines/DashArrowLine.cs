using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_drawer.Arrows.ArrowLines
{
    class DashArrowLine : IArrowLine
    {
        public void Draw(Pen pen, Point[] arrowLinePoints)
        {
            pen = (Pen)pen.Clone();
            pen.DashStyle = DashStyle.Dash;
            MainGraphics.Graphics.DrawLines(pen, arrowLinePoints);
        }
    }
}