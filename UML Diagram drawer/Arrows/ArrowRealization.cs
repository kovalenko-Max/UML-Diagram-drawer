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
            if (!StartPoint.IsEmpty && !EndPoint.IsEmpty)
            {
                DrawStraightBrokenLine(wipeFromEndArrow: _sizeArrowhead);
                DrawArrowhead();
            }
        }

        private void DrawArrowhead()
        {
            Point[] points;

            if (!StartPoint.IsEmpty && !EndPoint.IsEmpty)
            {
                if (IsHorizontal)
                {
                    int coefX = StartPoint.X < EndPoint.X ? EndPoint.X - _sizeArrowhead : EndPoint.X + _sizeArrowhead;
                    points = new Point[]
                    {
                        new Point(coefX, EndPoint.Y+_sizeArrowhead/2),
                        new Point(coefX, EndPoint.Y-_sizeArrowhead/2),
                        new Point(EndPoint.X, EndPoint.Y)
                    };
                }
                else
                {
                    int coefY = StartPoint.Y < EndPoint.Y ? EndPoint.Y - _sizeArrowhead : EndPoint.Y + _sizeArrowhead;
                    points = new Point[]
                    {
                        new Point(EndPoint.X+_sizeArrowhead/2, coefY),
                        new Point(EndPoint.X-_sizeArrowhead/2, coefY),
                        new Point(EndPoint.X, EndPoint.Y)
                    };
                }

                Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                Graphics.DrawPolygon(Pen, points);
            }
        }

        public override void CreateSelectionBorders()
        {
            throw new NotImplementedException();
        }
    }
}
