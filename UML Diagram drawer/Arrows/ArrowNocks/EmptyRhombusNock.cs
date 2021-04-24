using System.Drawing;

namespace UML_Diagram_drawer.Arrows.ArrowNocks
{
    public class EmptyRhombusNock : IArrowNock
    {
        public void Draw(Pen pen, Point startPoint, Point nextPoint)
        {
            Point[] arrowNockPoints = new Point[4];

            if (!nextPoint.IsEmpty && !startPoint.IsEmpty)
            {
                int _sizeArrowNock = (int)pen.Width * 2;
                int RhombusLeng = 4 * _sizeArrowNock;

                if (nextPoint.Y == startPoint.Y)
                {
                    if (nextPoint.X < startPoint.X)
                    {
                        int x = startPoint.X - _sizeArrowNock * 2;
                        arrowNockPoints[0] = startPoint;
                        arrowNockPoints[1] = new Point(x, startPoint.Y - _sizeArrowNock);
                        arrowNockPoints[2] = new Point(startPoint.X - RhombusLeng, startPoint.Y);
                        arrowNockPoints[3] = new Point(x, startPoint.Y + _sizeArrowNock);
                    }
                    else
                    {
                        int x = startPoint.X + _sizeArrowNock * 2;
                        arrowNockPoints[0] = startPoint;
                        arrowNockPoints[1] = new Point(x, startPoint.Y - _sizeArrowNock);
                        arrowNockPoints[2] = new Point(startPoint.X + RhombusLeng, startPoint.Y);
                        arrowNockPoints[3] = new Point(x, startPoint.Y + _sizeArrowNock);
                    }
                }
                else
                {
                    if (nextPoint.Y < startPoint.Y)
                    {
                        int y = startPoint.Y - _sizeArrowNock * 2;
                        arrowNockPoints[0] = startPoint;
                        arrowNockPoints[1] = new Point(startPoint.X - _sizeArrowNock, y);
                        arrowNockPoints[2] = new Point(startPoint.X, startPoint.Y - RhombusLeng);
                        arrowNockPoints[3] = new Point(startPoint.X + _sizeArrowNock, y);
                    }
                    else
                    {
                        int y = startPoint.Y + _sizeArrowNock * 2;
                        arrowNockPoints[0] = startPoint;
                        arrowNockPoints[1] = new Point(startPoint.X - _sizeArrowNock, y);
                        arrowNockPoints[2] = new Point(startPoint.X, startPoint.Y + RhombusLeng);
                        arrowNockPoints[3] = new Point(startPoint.X + _sizeArrowNock, y);
                    }
                }

                Point eraseStartPoint = arrowNockPoints[2];
                Pen erasePen = new Pen(MainData.GetMainData().PictureBoxMain.BackColor, _sizeArrowNock);
                MainGraphics.Graphics.DrawLine(erasePen, startPoint, eraseStartPoint);
                MainGraphics.Graphics.DrawPolygon(pen, arrowNockPoints);
            }
        }
    }
}