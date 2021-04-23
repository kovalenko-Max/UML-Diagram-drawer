using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    class ArrowSuccession : AbstactArrow
    {
        public override void Draw()
        {
            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                DrawStraightBrokenLine();
                DrawArrowhead();
            }
        }

        private void DrawArrowhead()
        {
            Point[] arrowHeadPoints = new Point[3];

            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                Point eraseEndPoint;
                if (_points[_points.Length - 2].Y == EndPoint.Location.Y)
                {
                    if (_points[_points.Length - 2].X < EndPoint.Location.X)
                    {
                        eraseEndPoint = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y);
                        arrowHeadPoints[0] = EndPoint.Location;
                        arrowHeadPoints[1] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                    }
                    else
                    {
                        eraseEndPoint = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y);
                        arrowHeadPoints[0] = EndPoint.Location;
                        arrowHeadPoints[1] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                    }
                }
                else
                {
                    if (_points[_points.Length - 2].Y < EndPoint.Location.Y)
                    {
                        eraseEndPoint = new Point(EndPoint.Location.X, EndPoint.Location.Y - _sizeArrowhead);
                        arrowHeadPoints[0] = EndPoint.Location;
                        arrowHeadPoints[1] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y - _sizeArrowhead);
                    }
                    else
                    {
                        eraseEndPoint = new Point(EndPoint.Location.X, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[0] = EndPoint.Location;
                        arrowHeadPoints[1] = new Point(EndPoint.Location.X + _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                        arrowHeadPoints[2] = new Point(EndPoint.Location.X - _sizeArrowhead, EndPoint.Location.Y + _sizeArrowhead);
                    }
                }

                Pen erasePen = new Pen(MainData.GetMainData().PictureBoxMain.BackColor, _sizeArrowhead);
                MainGraphics.Graphics.DrawLine(erasePen, EndPoint.Location, eraseEndPoint);
                MainGraphics.Graphics.DrawPolygon(_pen, arrowHeadPoints);
            }
        }
    }
}
