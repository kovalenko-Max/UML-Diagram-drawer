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
        public ArrowRealization(Graphics graphics, Color color, int width = 5)
        {
            Pen = new Pen(Color, Width);
            Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Graphics = graphics;
            Color = color;
            Width = width;
        }

        public override void Draw()
        {
            if (!From.IsEmpty && !To.IsEmpty)
            {
                DrawStraightBrokenLine(wipeFromEndArrow: SizeArrowhead);
                DrawArrowhead();
            }
        }

        private void DrawArrowhead()
        {
            Point[] points;

            if (!From.IsEmpty && !To.IsEmpty)
            {
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
        }
    }
}
