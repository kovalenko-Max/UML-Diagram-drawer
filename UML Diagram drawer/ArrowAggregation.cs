using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    class ArrowAggregation : AbstactArrow
    {
        public ArrowAggregation(Graphics graphics, Color color, int width = 5)
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
                DrawStraightBrokenLine(wipeFromStartArrow: SizeArrowhead);
                DrawRhombusAggregation();
                DrawArrowheadAggregation();
            }
        }

        private void DrawRhombusAggregation()
        {
            int coefX = From.X < To.X ? From.X + SizeArrowhead : From.X - SizeArrowhead;
            int coefX2 = From.X < To.X ? From.X + SizeArrowhead / 2 : From.X - SizeArrowhead / 2;

            Point[] points = new Point[]
            {
                    new Point(From.X, From.Y),
                    new Point(coefX2, From.Y+SizeArrowhead/2),
                    new Point(coefX, From.Y),
                    new Point(coefX2, From.Y-SizeArrowhead/2)
            };
            
            Graphics.DrawPolygon(Pen, points);
        }

        private void DrawArrowheadAggregation()
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
