using System;
using System.Drawing;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    public abstract class AbstactArrow : ISelectable
    {
        protected const int indentFromBorder = 50;
        protected Rectangle[] _rectangles;
        protected Point[] _points;
        protected int _sizeArrowhead;
        protected bool _isHorizontal;
        protected Pen _pen;

        public Color Color
        {
            get
            {
                if (_pen != null)
                {
                    return _pen.Color;
                }

                throw new ArgumentNullException("Pen is null");
            }
            set
            {
                if (_pen != null)
                {
                    _pen.Color = value;
                }
                else
                {
                    throw new ArgumentNullException("Pen is null");
                }
            }
        }
        public float WidthLine
        {
            get
            {
                if (_pen != null)
                {
                    return _pen.Width;
                }

                throw new ArgumentNullException("Pen is null");
            }
            set
            {
                if (_pen != null)
                {
                    _pen.Width = value;
                }
                else
                {
                    throw new ArgumentNullException("Pen is null");
                }
            }
        }
        public ContactPoint StartPoint { get; set; }
        public ContactPoint EndPoint { get; set; }
        public bool IsSelected { get; set; }

        public AbstactArrow()
        {
            _pen = (Pen)Default.Draw.Pen.Clone();
            _sizeArrowhead = (int)_pen.Width * 3;

            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public abstract void Draw();

        protected void DrawStraightBrokenLine()
        {
            _points = ArrowsLineDrawingLogic.GetPoints(StartPoint, EndPoint);
            CreateSelectionBorders();
            MainGraphics.Graphics.DrawLines(_pen, _points);
        }

        public void Move(int deltaX, int deltaY)
        {
        }

        public bool Select(Point point)
        {
            bool result = false;
            foreach (Rectangle rectangle in _rectangles)
            {
                if (rectangle.Contains(point))
                {
                    _pen = (Pen)Default.Draw.PenSelect.Clone();
                    result = true;
                    IsSelected = true;
                }
            }

            return result;
        }

        public void Select()
        {
            if (IsSelected)
            {
                _pen = Default.Draw.PenSelect;
            }
        }

        public void RemoveSelect()
        {
            if (IsSelected)
            {
                IsSelected = false;
                _pen = (Pen)Default.Draw.Pen.Clone();
            }
        }

        private void CreateSelectionBorders()
        {
            if (_points.Length > 0)
            {
                _rectangles = new Rectangle[_points.Length - 1];
                for (int i = 0; i < _rectangles.Length; i++)
                {
                    if (_points[i].X < _points[i + 1].X)
                    {
                        int width = _points[i + 1].X - _points[i].X;
                        int height = _sizeArrowhead;
                        _rectangles[i] = new Rectangle(_points[i].X, _points[i].Y - _sizeArrowhead / 2, width, height);
                    }
                    else if (_points[i].X > _points[i + 1].X)
                    {
                        int width = (_points[i + 1].X - _points[i].X) * (-1);
                        int height = _sizeArrowhead;
                        _rectangles[i] = new Rectangle(_points[i + 1].X, _points[i].Y - _sizeArrowhead / 2, width, height);
                    }
                    else if (_points[i].Y < _points[i + 1].Y)
                    {
                        int width = _sizeArrowhead;
                        int height = (_points[i + 1].Y - _points[i].Y);
                        _rectangles[i] = new Rectangle(_points[i].X - _sizeArrowhead / 2, _points[i].Y, width, height);
                    }
                    else if (_points[i].Y > _points[i + 1].Y)
                    {
                        int width = _sizeArrowhead;
                        int height = (_points[i + 1].Y - _points[i].Y) * (-1);
                        _rectangles[i] = new Rectangle(_points[i].X - _sizeArrowhead / 2, _points[i + 1].Y, width, height);
                    }
                }
            }
        }
    }
}
