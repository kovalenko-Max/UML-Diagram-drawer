using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    class ArrowAssociation : AbstactArrow
    {
        public ArrowAssociation(Graphics graphics, Color color, int width = 5)
        {
            Graphics = graphics;
            Color = color;
            Width = width;
            Pen = new Pen(Color, Width);
        }

        public override void Draw()
        {
            DrawStraightBrokenLine();
            DrawArrowheadAssociation();
        }

        private void DrawArrowheadAssociation()
        {
            Point[] points;

            if (IsHorizontal)
            {
                int coefX = From.X < To.X ? To.X - SizeArrowhead : To.X + SizeArrowhead;
                points = new Point[]
                {
                    new Point(coefX, To.Y+SizeArrowhead/2),
                    new Point(To.X, To.Y),
                    new Point(coefX, To.Y-SizeArrowhead/2)
                };

                Graphics.DrawLines(Pen, points);
            }
            else
            {
                int coefY = From.Y < To.Y ? To.Y - SizeArrowhead : To.Y + SizeArrowhead;
                points = new Point[]
                {
                    new Point(To.X+SizeArrowhead/2, coefY),
                    new Point(To.X, To.Y),
                    new Point(To.X-SizeArrowhead/2, coefY)
                };

                Graphics.DrawLines(Pen, points);
            }
        }
    }
}
