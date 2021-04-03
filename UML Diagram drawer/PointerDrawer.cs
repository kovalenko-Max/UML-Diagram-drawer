using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public static class PointerDrawer
    {
        //private static Point _startPoint = Point.Empty;
        //private static Point _endPoint = Point.Empty;
        private static Bitmap _bitmap;
        private static Graphics _graphics;
        private static Pen _pen;
        private static Pen _eraser;
        //private static PictureBox _pictureBox;

        public static void Initialize(PictureBox pictureBox, Bitmap bitMap,Graphics graphics,Pen pen)
        {
            //_pictureBox = pictureBox;
            _bitmap = bitMap;
            _graphics = graphics;
            _pen = pen;
            _eraser = new Pen(Color.White, 10f);
        }

        public static void Eraser(Point point)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _bitmap.SetPixel(i + point.X, j + point.Y, Color.White);
                }
            }
        }

        public static void DrawSuccession(Point startP, Point endP)
        {
            Point tempStartPoint =DrawStraightBrokenLine(startP, endP);
            DrawEndPointerSuccession(tempStartPoint, endP);
        }

        public static void DrawRealisation(Point startP, Point endP)
        {
            Point tempStartPoint = DrawStraightBrokenLine(startP, endP);
            
        }

        public static void DrawAssociation(Point startP, Point endP) 
        {
            Point tempStartPoint = DrawStraightBrokenLine(startP, endP);

        }

        public static void DrawComposition(Point startP, Point endP)
        {
            Point tempStartPoint = DrawStraightBrokenLine(startP, endP);

        }

        public static void DrawAggregation(Point startP, Point endP)
        {
            Point tempStartPoint = DrawStraightBrokenLine(startP, endP);

        }

        private static Point DrawStraightBrokenLine(Point startP, Point endP)
        {
            Point tempPointStart = Point.Empty;
            Point tempPointEnd = Point.Empty;

            tempPointStart.X = (endP.X + startP.X) / 2;
            tempPointStart.Y = startP.Y;

            _graphics.DrawLine(_pen, startP, tempPointStart);

            tempPointEnd.X = (endP.X + startP.X) / 2;
            tempPointEnd.Y = endP.Y;

            _graphics.DrawLine(_pen, tempPointStart, tempPointEnd);

            return tempPointEnd;
        }

        private static void DrawEndPointerSuccession(Point startP, Point endP)
        {
            int offsetX = 10;
            int offsetY = offsetX / 2;

            _graphics.DrawLine(_pen, startP.X, startP.Y, endP.X - offsetX, endP.Y);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y, endP.X - offsetX, endP.Y - offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y - offsetY, endP.X, endP.Y);
            _graphics.DrawLine(_pen, endP.X, endP.Y, endP.X - offsetX, endP.Y + offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y + offsetY, endP.X - offsetX, endP.Y);
        }

        private static void DrawEndPointerRhombus(Point startP, Point endP)
        {
            int offsetX = 10;
            int offsetY = offsetX - 2;

            _graphics.DrawLine(_pen, startP.X, startP.Y, endP.X - offsetX * 2, endP.Y);
            _graphics.DrawLine(_pen, endP.X - offsetX * 2, endP.Y, endP.X - offsetX, endP.Y - offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y - offsetY, endP.X, endP.Y);
            _graphics.DrawLine(_pen, endP.X, endP.Y, endP.X - offsetX, endP.Y + offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y + offsetY, endP.X - offsetX * 2, endP.Y);
        }
    }
}
