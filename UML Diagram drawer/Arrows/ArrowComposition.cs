using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    class ArrowComposition : AbstactArrow
    {
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

            MainGraphics.Graphics.DrawPolygon(_pen, points);
            MainGraphics.Graphics.FillPolygon(new SolidBrush(_pen.Color), points, System.Drawing.Drawing2D.FillMode.Alternate);
        }

        private void DrawArrowheadComposition()
        {
            Point[] arrowHeadPoints = new Point[3];

            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                if (_ArrowLinePoints[_ArrowLinePoints.Length - 2].Y == EndPoint.Location.Y)
                {
                    if (_ArrowLinePoints[_ArrowLinePoints.Length - 2].X < EndPoint.Location.X)
                    {
                        arrowHeadPoints[0] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[1] = EndPoint.Location;
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                    }
                    else
                    {
                        arrowHeadPoints[0] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[1] = EndPoint.Location;
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                    }
                }
                else
                {
                    if (_ArrowLinePoints[_ArrowLinePoints.Length - 2].Y < EndPoint.Location.Y)
                    {
                        arrowHeadPoints[0] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                        arrowHeadPoints[1] = EndPoint.Location;
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                    }
                    else
                    {
                        arrowHeadPoints[0] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[1] = EndPoint.Location;
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                    }
                }
            }

            MainGraphics.Graphics.DrawLines(_pen, arrowHeadPoints);
        }
    }
}
