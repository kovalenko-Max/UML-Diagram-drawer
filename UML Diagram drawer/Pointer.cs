using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public class Pointer : Control
    {
        private PictureBox _pictureBox;
        private Bitmap _bitmap;
        private Graphics _graphics;
        private Pen _pen;
        //private Pen _eraser;
        private const int _sizeOfArrow = 10;

        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Pointer(PictureBox pictureBox, Bitmap bitMap, Graphics graphics, Pen pen)
        {
            _pictureBox = pictureBox;
            _bitmap = bitMap;
            _graphics = graphics;
            _pen = pen;
            //_eraser = new Pen(Color.White, 10f);
        }

        public void DrawSuccession(Point startP, Point endP, bool isHorizontal)
        {
            StartPoint = startP;
            EndPoint = endP;

            DrawStraightBrokenLine(startP, endP, isHorizontal);
            DrawEndPointerSuccession(endP, isHorizontal);
        }

        public void DrawRealisation(Point startP, Point endP)
        {
            //DrawStraightBrokenLine(startP, endP);

        }

        public void DrawAssociation(Point startP, Point endP)
        {
            //DrawStraightBrokenLine(startP, endP);

        }

        public void DrawComposition(Point startP, Point endP)
        {
            //DrawStraightBrokenLine(startP, endP);

        }

        public void DrawAggregation(Point startP, Point endP)
        {
            //DrawStraightBrokenLine(startP, endP);

        }

        private void DrawStraightBrokenLine(Point startP, Point endP, bool isHorizontal)
        {
            if (isHorizontal)
            {
                Point[] points = new Point[]
                {
                    new Point(startP.X,startP.Y),
                    new Point((endP.X + startP.X) / 2,startP.Y),
                    new Point((endP.X + startP.X) / 2,endP.Y),
                    new Point(endP.X,endP.Y)
                };

                _graphics.DrawLines(_pen, points);
            }
            else
            {
                Point[] points = new Point[]
                {
                    new Point(startP.X,startP.Y),
                    new Point(endP.X, startP.Y),
                    new Point(endP.X,endP.Y)
                };

                _graphics.DrawLines(_pen, points);
            }
        }

        private void DrawEndPointerSuccession(Point endP, bool isHorizontal)
        {
            if (isHorizontal)
            {
                int coefX = StartPoint.X < endP.X ? endP.X - _sizeOfArrow : endP.X + _sizeOfArrow;
                Point[] points = new Point[]
                {
                    new Point(coefX, endP.Y+_sizeOfArrow/2),
                    new Point(coefX, endP.Y-_sizeOfArrow/2),
                    new Point(endP.X, endP.Y)
                };

                Eraser(endP, _sizeOfArrow, isHorizontal);
                _graphics.DrawPolygon(_pen, points);

            }
            else
            {
                int coefY = StartPoint.Y < endP.Y ? endP.Y - _sizeOfArrow : endP.Y + _sizeOfArrow;
                Point[] points = new Point[]
                {
                    new Point(endP.X+_sizeOfArrow/2, coefY),
                    new Point(endP.X-_sizeOfArrow/2, coefY),
                    new Point(endP.X, endP.Y)
                };

                Eraser(endP, _sizeOfArrow, isHorizontal);
                _graphics.DrawPolygon(_pen, points);
            }
        }

        //private void DrawEndPointerSuccession(Point startP, Point endP)
        //{
        //    int offsetX = 10;
        //    int offsetY = offsetX / 2;

        //    _graphics.DrawLine(_pen, startP.X, startP.Y, endP.X - offsetX, endP.Y);
        //    _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y, endP.X - offsetX, endP.Y - offsetY);
        //    _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y - offsetY, endP.X, endP.Y);
        //    _graphics.DrawLine(_pen, endP.X, endP.Y, endP.X - offsetX, endP.Y + offsetY);
        //    _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y + offsetY, endP.X - offsetX, endP.Y);
        //}

        private void DrawEndPointerRhombus(Point startP, Point endP)
        {
            int offsetX = 10;
            int offsetY = offsetX - 2;

            _graphics.DrawLine(_pen, startP.X, startP.Y, endP.X - offsetX * 2, endP.Y);
            _graphics.DrawLine(_pen, endP.X - offsetX * 2, endP.Y, endP.X - offsetX, endP.Y - offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y - offsetY, endP.X, endP.Y);
            _graphics.DrawLine(_pen, endP.X, endP.Y, endP.X - offsetX, endP.Y + offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y + offsetY, endP.X - offsetX * 2, endP.Y);
        }

        private void Eraser(Point point, int length, bool isHorizontal)
        {
            int coefX = isHorizontal ? length * (-1) : (int)_pen.Width * (-1);
            int coefY = isHorizontal ? (int)_pen.Width * (-1) : length * (-1);
            int coefI = StartPoint.X < point.X ? 1 : -1;
            int coefJ = StartPoint.Y < point.Y ? 1 : -1;

            for (int i = coefX; i < (int)_pen.Width; i++)
            {
                for (int j = coefY; j < (int)_pen.Width; j++)
                {
                    _bitmap.SetPixel((i * coefI) + point.X, (j * coefJ) + point.Y, _pictureBox.BackColor);
                }
            }
        }
    }
}
