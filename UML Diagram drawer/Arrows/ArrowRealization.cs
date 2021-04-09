using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    class ArrowRealization : AbstactArrow
    {
        public ArrowRealization(Pen pen, Graphics graphics) : base(pen, graphics)
        {
        }

        public ArrowRealization(Pen pen, Graphics graphics, Point startPoint, Point endPoint) : base(pen, graphics, startPoint, endPoint)
        {
        }

        public override void Draw()
        {
            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                DrawStraightBrokenLine(wipeFromEndArrow: _sizeArrowhead);
                DrawArrowhead();
            }
        }

        private void DrawArrowhead()
        {
            Point[] points;

            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                if (IsHorizontal)
                {
                    int coefX = StartPoint.Location.X < EndPoint.Location.X ? EndPoint.Location.X - _sizeArrowhead : EndPoint.Location.X + _sizeArrowhead;
                    points = new Point[]
                    {
                        new Point(coefX, EndPoint.Location.Y+_sizeArrowhead/2),
                        new Point(coefX, EndPoint.Location.Y-_sizeArrowhead/2),
                        new Point(EndPoint.Location.X, EndPoint.Location.Y)
                    };
                }
                else
                {
                    int coefY = StartPoint.Location.Y < EndPoint.Location.Y ? EndPoint.Location.Y - _sizeArrowhead : EndPoint.Location.Y + _sizeArrowhead;
                    points = new Point[]
                    {
                        new Point(EndPoint.Location.X+_sizeArrowhead/2, coefY),
                        new Point(EndPoint.Location.X-_sizeArrowhead/2, coefY),
                        new Point(EndPoint.Location.X, EndPoint.Location.Y)
                    };
                }

                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Graphics.DrawPolygon(Pen, points);
            }
        }
    }
}
