using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_drawer.Arrows
{
    class ArrowRealization : AbstactArrow
    {
        public ArrowRealization()
        {

        }
        public ArrowRealization(Pen pen) : base(pen)
        {
            
        }

        public ArrowRealization(Pen pen, Point startPoint, Point endPoint) : base(pen, startPoint, endPoint)
        {
        }

        public override void Draw()
        {
            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                DashStyle currentDashStyle = Pen.DashStyle;
                Pen.DashStyle = DashStyle.Dash;
                DrawStraightBrokenLine();
                Pen.DashStyle = currentDashStyle;
                DrawArrowhead();
            }
        }

        private void DrawArrowhead()
        {
            Point[] arrowHeadPoints = new Point[3];

            if (!StartPoint.Location.IsEmpty && !EndPoint.Location.IsEmpty)
            {
                Point eraseEndPoint;
                if (Points[Points.Length - 2].Y == EndPoint.Location.Y)
                {
                    if (Points[Points.Length - 2].X < EndPoint.Location.X)
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
                    if (Points[Points.Length - 2].Y < EndPoint.Location.Y)
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
                MainGraphics.Graphics.DrawPolygon(Pen, arrowHeadPoints);
            }
        }
    }
}
