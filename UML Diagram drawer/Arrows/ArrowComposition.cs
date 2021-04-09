using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    class ArrowComposition : AbstactArrow
    {
        public ArrowComposition(Pen pen, Graphics graphics, Point startPoint, Point endPoint) : base(pen, graphics, startPoint, endPoint)
        {
        }

        public ArrowComposition(Pen pen, Graphics graphics) : base(pen, graphics)
        {
        }

        public override void Draw()
        {
            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                DrawStraightBrokenLine();
                DrawFillRhombusComposition();
                DrawArrowheadComposition();
            }
        }

        private void DrawFillRhombusComposition()
        {
            int coefX = StartPoint.Location.X < EndPoint.Location.X ? StartPoint.Location.X + _sizeArrowhead : StartPoint.Location.X - _sizeArrowhead;
            int coefX2 = StartPoint.Location.X < EndPoint.Location.X ? StartPoint.Location.X + _sizeArrowhead / 2 : StartPoint.Location.X - _sizeArrowhead / 2;

            Point[] points = new Point[]
            {
                    new Point(StartPoint.Location.X, StartPoint.Location.Y),
                    new Point(coefX2, StartPoint.Location.Y+_sizeArrowhead/2),
                    new Point(coefX, StartPoint.Location.Y),
                    new Point(coefX2, StartPoint.Location.Y-_sizeArrowhead/2)
            };

            Graphics.DrawPolygon(Pen, points);
            Graphics.FillPolygon(new SolidBrush(Pen.Color), points, System.Drawing.Drawing2D.FillMode.Alternate);
        }

        private void DrawArrowheadComposition()
        {
            Point[] points;

            if (IsHorizontal)
            {
                int coefX = StartPoint.Location.X < EndPoint.Location.X ? EndPoint.Location.X - _sizeArrowhead : EndPoint.Location.X + _sizeArrowhead;
                points = new Point[]
                {
                    new Point(coefX, EndPoint.Location.Y+_sizeArrowhead/2),
                    new Point(EndPoint.Location.X, EndPoint.Location.Y),
                    new Point(coefX, EndPoint.Location.Y-_sizeArrowhead/2)
                };

                Graphics.DrawLines(Pen, points);
            }
            else
            {
                int coefY = StartPoint.Location.Y < EndPoint.Location.Y ? EndPoint.Location.Y - _sizeArrowhead : EndPoint.Location.Y + _sizeArrowhead;
                points = new Point[]
                {
                    new Point(EndPoint.Location.X+_sizeArrowhead/2, coefY),
                    new Point(EndPoint.Location.X, EndPoint.Location.Y),
                    new Point(EndPoint.Location.X-_sizeArrowhead/2, coefY)
                };

                Graphics.DrawLines(Pen, points);
            }
        }
    }
}
