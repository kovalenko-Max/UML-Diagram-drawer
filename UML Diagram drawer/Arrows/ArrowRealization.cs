using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    class ArrowRealization : AbstactArrow
    {
        public ArrowRealization(Point from, Point to, Pen pen, Graphics graphics)
        {
            SizeArrowhead = 20;
            From = from;
            To = to;
            Pen = pen;
            Graphics = graphics;
            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
        }

        public void Draw()
        {
            Graphics.DrawLine(Pen, From, To);
            DrawArrowheadSuccession();
        }

        private void DrawArrowheadSuccession()
        {
            Point[] points;

            if (IsHorizontal)
            {
                int coefX = From.X < To.X ? To.X - SizeArrowhead : To.X + SizeArrowhead;
                points = new Point[]
                {
                    new Point(coefX, To.Y+SizeArrowhead/2),
                    new Point(coefX, To.Y-SizeArrowhead/2),
                    new Point(To.X, To.Y)
                };
            }
            else
            {
                int coefY = From.Y < To.Y ? To.Y - SizeArrowhead : To.Y + SizeArrowhead;
                points = new Point[]
                {
                    new Point(To.X+SizeArrowhead/2, coefY),
                    new Point(To.X-SizeArrowhead/2, coefY),
                    new Point(To.X, To.Y)
                };
            }
            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Graphics.DrawPolygon(Pen, points);
        }
        public override void Draw(Point fromP, Point ToP)
        {
            throw new NotImplementedException();
        }
    }
}
