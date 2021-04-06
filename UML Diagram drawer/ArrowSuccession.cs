using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    class ArrowSuccession : AbstactArrow
    {
        public ArrowSuccession(Point from, Point to, Graphics graphics, Color color, int width = 5)
        {
            From = from;
            To = to;
            Graphics = graphics;
            Color = color;
            Width = width;
            Pen = new Pen(Color, Width);
            Draw(From, To);
        }

        public override void Draw(Point fromPoint, Point toPoint)
        {
            From = fromPoint;
            To = toPoint;

            DrawStraightBrokenLine(wipeFromEndArrow: SizeArrowhead);
            DrawArrowheadSuccession();
        }

        private void DrawArrowheadSuccession()
        {
            if (IsHorizontal)
            {
                int coefX = From.X < To.X ? To.X - SizeArrowhead : To.X + SizeArrowhead;
                Point[] points = new Point[]
                {
                    new Point(coefX, To.Y+SizeArrowhead/2),
                    new Point(coefX, To.Y-SizeArrowhead/2),
                    new Point(To.X, To.Y)
                };

                Graphics.DrawPolygon(Pen, points);
            }
            else
            {
                int coefY = From.Y < To.Y ? To.Y - SizeArrowhead : To.Y + SizeArrowhead;
                Point[] points = new Point[]
                {
                    new Point(To.X+SizeArrowhead/2, coefY),
                    new Point(To.X-SizeArrowhead/2, coefY),
                    new Point(To.X, To.Y)
                };

                Graphics.DrawPolygon(Pen, points);
            }
        }
    }
}
