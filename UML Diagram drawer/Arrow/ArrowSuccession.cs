using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrow
{
    class ArrowSuccession : AbstactArrow
    {
        public ArrowSuccession(Pen pen, Graphics graphics) : base(pen, graphics)
        {
        }

        public ArrowSuccession(Pen pen, Graphics graphics, Point startPoint, Point endPoint) : base(pen, graphics, startPoint, endPoint)
        {
        }

        public override void CreateSelectionBorders()
        {
            throw new NotImplementedException();
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
            if (!StartPoint.IsEmpty && !EndPoint.IsEmpty)
            {
                Point[] points;

                if (IsHorizontal)
                {
                    int coefX = StartPoint.X < EndPoint.X ? EndPoint.X - _sizeArrowhead : EndPoint.X + _sizeArrowhead;
                    points = new Point[]
                    {
                    new Point(coefX, EndPoint.Y+_sizeArrowhead/2),
                    new Point(coefX, EndPoint.Y-_sizeArrowhead/2),
                    new Point(EndPoint.X, EndPoint.Y)
                    };

                    Graphics.DrawPolygon(Pen, points);
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

                    Graphics.DrawPolygon(Pen, points);
                }
            }
        }
    }
}
