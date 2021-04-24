using System.Drawing;

namespace UML_Diagram_drawer.Arrows.ArrowLines
{
    public class SolidArrowLine : IArrowLine
    {
        private Pen _pen;

        public void Draw(Pen pen, Point[] arrowLinePoints)
        {
            MainGraphics.Graphics.DrawLines(pen, arrowLinePoints);
        }
    }
}