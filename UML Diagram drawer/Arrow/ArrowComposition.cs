﻿using System;
using System.Drawing;

namespace UML_Diagram_drawer.Arrow
{
    class ArrowComposition : AbstactArrow
    {
        public ArrowComposition(Pen pen, Graphics graphics, Point startPoint, Point endPoint) : base(pen, graphics, startPoint, endPoint)
        {
        }

        public ArrowComposition(Pen pen, Graphics graphics) : base(pen, graphics)
        {
        }

        public override void Draw()
        {
            if (!StartPoint.IsEmpty && !EndPoint.IsEmpty)
            {
                DrawStraightBrokenLine();
                DrawFillRhombusComposition();
                DrawArrowheadComposition();
            }
        }

        private void DrawFillRhombusComposition()
        {
            int coefX = StartPoint.X < EndPoint.X ? StartPoint.X + _sizeArrowhead : StartPoint.X - _sizeArrowhead;
            int coefX2 = StartPoint.X < EndPoint.X ? StartPoint.X + _sizeArrowhead / 2 : StartPoint.X - _sizeArrowhead / 2;

            Point[] points = new Point[]
            {
                    new Point(StartPoint.X, StartPoint.Y),
                    new Point(coefX2, StartPoint.Y+_sizeArrowhead/2),
                    new Point(coefX, StartPoint.Y),
                    new Point(coefX2, StartPoint.Y-_sizeArrowhead/2)
            };

            Graphics.DrawPolygon(Pen, points);
            Graphics.FillPolygon(new SolidBrush(Pen.Color), points, System.Drawing.Drawing2D.FillMode.Alternate);
        }

        private void DrawArrowheadComposition()
        {
            Point[] points;

            if (IsHorizontal)
            {
                int coefX = StartPoint.X < EndPoint.X ? EndPoint.X - _sizeArrowhead : EndPoint.X + _sizeArrowhead;
                points = new Point[]
                {
                    new Point(coefX, EndPoint.Y+_sizeArrowhead/2),
                    new Point(EndPoint.X, EndPoint.Y),
                    new Point(coefX, EndPoint.Y-_sizeArrowhead/2)
                };

                Graphics.DrawLines(Pen, points);
            }
            else
            {
                int coefY = StartPoint.Y < EndPoint.Y ? EndPoint.Y - _sizeArrowhead : EndPoint.Y + _sizeArrowhead;
                points = new Point[]
                {
                    new Point(EndPoint.X+_sizeArrowhead/2, coefY),
                    new Point(EndPoint.X, EndPoint.Y),
                    new Point(EndPoint.X-_sizeArrowhead/2, coefY)
                };

                Graphics.DrawLines(Pen, points);
            }
        }

        public override void CreateSelectionBorders()
        {
            throw new NotImplementedException();
        }
    }
}
