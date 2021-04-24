using System.Drawing;
using System.Drawing.Drawing2D;

namespace UML_Diagram_drawer.Arrows.ArrowHeads
{
    public class ThreePointArrowHead : IArrowHead
    {
        public void Draw(Pen pen, Point endPoint, Point preEndPoint)
        {
            DashStyle currentDashStyle = pen.DashStyle;
            pen.DashStyle = DashStyle.Solid;
            Point[] arrowHeadPoints = new Point[3];

            if (!preEndPoint.IsEmpty && !endPoint.IsEmpty)
            {
                int sizeArrowhead = (int)pen.Width * 3;

                if (preEndPoint.Y == endPoint.Y)
                {
                    if (preEndPoint.X < endPoint.X)
                    {
                        arrowHeadPoints[0] = new Point(endPoint.X - sizeArrowhead, endPoint.Y + sizeArrowhead);
                        arrowHeadPoints[1] = endPoint;
                        arrowHeadPoints[2] = new Point(endPoint.X - sizeArrowhead, endPoint.Y - sizeArrowhead);
                    }
                    else
                    {
                        arrowHeadPoints[0] = new Point(endPoint.X + sizeArrowhead, endPoint.Y + sizeArrowhead);
                        arrowHeadPoints[1] = endPoint;
                        arrowHeadPoints[2] = new Point(endPoint.X + sizeArrowhead, endPoint.Y - sizeArrowhead);
                    }
                }
                else
                {
                    if (preEndPoint.Y < endPoint.Y)
                    {
                        arrowHeadPoints[0] = new Point(endPoint.X + sizeArrowhead, endPoint.Y - sizeArrowhead);
                        arrowHeadPoints[1] = endPoint;
                        arrowHeadPoints[2] = new Point(endPoint.X - sizeArrowhead, endPoint.Y - sizeArrowhead);
                    }
                    else
                    {
                        arrowHeadPoints[0] = new Point(endPoint.X + sizeArrowhead, endPoint.Y + sizeArrowhead);
                        arrowHeadPoints[1] = endPoint;
                        arrowHeadPoints[2] = new Point(endPoint.X - sizeArrowhead, endPoint.Y + sizeArrowhead);
                    }
                }
            }

            MainGraphics.Graphics.DrawLines(pen, arrowHeadPoints);
            pen.DashStyle = currentDashStyle;
        }
    }
}