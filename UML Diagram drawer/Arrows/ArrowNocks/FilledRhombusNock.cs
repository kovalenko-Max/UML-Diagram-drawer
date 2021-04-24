using System.Drawing;

namespace UML_Diagram_drawer.Arrows.ArrowNocks
{
    class FilledRhombusNock : IArrowNock
    {
        public void Draw(Pen pen, Point StartPoint, Point nextPoint)
        {
            int sizeArrowhead = (int)pen.Width * 3;
            int coefX = StartPoint.X < nextPoint.X ? StartPoint.X + sizeArrowhead : StartPoint.X - sizeArrowhead;
            int coefX2 = StartPoint.X < nextPoint.X ? StartPoint.X + sizeArrowhead / 2 : StartPoint.X - sizeArrowhead / 2;

            Point[] points = new Point[]
            {
                    new Point(StartPoint.X, StartPoint.Y),
                    new Point(coefX2, StartPoint.Y+sizeArrowhead/2),
                    new Point(coefX, StartPoint.Y),
                    new Point(coefX2, StartPoint.Y-sizeArrowhead/2)
            };

            MainGraphics.Graphics.DrawPolygon(pen, points);
            MainGraphics.Graphics.FillPolygon(new SolidBrush(pen.Color), points, System.Drawing.Drawing2D.FillMode.Alternate);
        }
    }
}
