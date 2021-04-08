using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    class ArrowSuccession : AbstactArrow
    {
        public ArrowSuccession(Graphics graphics, Color color, int width = 5)
        {
            Pen = new Pen(Color, Width);
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
            if (!From.IsEmpty && !To.IsEmpty)
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

                    Graphics.DrawPolygon(Pen, points);
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

                    Graphics.DrawPolygon(Pen, points);
                }
            }
        }
    }
}
