using System;
using System.Drawing;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    public abstract class AbstactArrow : ISelectable
    {
        const int indentFromBorder = 50;
        protected int _sizeArrowhead;

        public bool IsHorizontal { get; set; }

        protected Pen Pen { get; set; }
        public ContactPoint StartPoint { get; set; }
        public ContactPoint EndPoint { get; set; }
        public bool IsSelected { get; set; }
        public bool IsMove { get; set; }
        public Point StartMovePoint { get; set; }
        public Rectangle[] Rectangles { get; set; }
        public Point[] Points { get; set; }

        public AbstactArrow()
        {

        }
        public AbstactArrow(Pen pen, Point startPoint, Point endPoint)
        {
            Pen = pen;
            _sizeArrowhead = (int)Pen.Width * 3;

            StartPoint = new ContactPoint(startPoint);
            EndPoint = new ContactPoint(endPoint);
        }
        public AbstactArrow(Pen pen)
        {
            Pen = pen;
            _sizeArrowhead = (int)Pen.Width * 3;

            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public abstract void Draw();

        public void DrawStraightBrokenLine()
        {
            Points = ArrowsLineDrawingLogic.GetPoints(StartPoint, EndPoint);
            MainGraphics.Graphics.DrawLines(Pen, Points);
        }

        public void CreateSelectionBorders()
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public bool Select(Point point)
        {
            //throw new NotImplementedException();
            return false;
        }

        public void RemoveSelect()
        {
            throw new NotImplementedException();
        }
    }
}
