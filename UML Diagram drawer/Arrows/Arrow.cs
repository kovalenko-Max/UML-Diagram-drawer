using System;
using System.Drawing;
using UML_Diagram_drawer.Arrows.ArrowLines;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Arrows
{
    public class Arrow : ISelectable
    {
        private const int indentFromBorder = 50;
        private Rectangle[] _colliders;
        private Point[] _ArrowLinePoints;

        public IArrowHead ArrowHead;
        public IArrowLine ArrowLine;
        public IArrowNock ArrowNock;

        private int _sizeArrowhead;
        private Pen _pen;

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

        public Arrow(IArrowLine arrowLine, IArrowHead arrowHead = null, IArrowNock arrowNock = null, Pen pen = null)
        {
            if (pen is null)
            {
                _pen = (Pen)Default.Draw.Pen.Clone();
            }
            else
            {
                _pen = pen;
            }
            _sizeArrowhead = (int)_pen.Width * 3;
            ArrowHead = arrowHead;
            ArrowLine = arrowLine;
            ArrowNock = arrowNock;
            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public Arrow()
        {
            _pen = (Pen)Default.Draw.Pen.Clone();
            _sizeArrowhead = (int)_pen.Width * 3;

            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public void Draw()
        {
            _ArrowLinePoints = ArrowsLineDrawingLogic.GetPoints(StartPoint, EndPoint);
            if (ArrowLine != null)
            {
                ArrowLine.Draw(_pen, _ArrowLinePoints);
                CreateSelectionBorders();
            }
            if (ArrowNock != null)
            {
                ArrowNock.Draw(_pen, StartPoint.Location, _ArrowLinePoints[1]);
            }
            if (ArrowHead != null)
            {
                ArrowHead.Draw(_pen, EndPoint.Location, _ArrowLinePoints[_ArrowLinePoints.Length - 2]);
            }
        }

        public void Move(int deltaX, int deltaY)
        {
        }

        public bool IsSelect(Point point)
        {
            bool result = false;
            foreach (Rectangle rectangle in _colliders)
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
            if (_ArrowLinePoints.Length > 0)
            {
                _colliders = new Rectangle[_ArrowLinePoints.Length - 1];
                for (int i = 0; i < _colliders.Length; i++)
                {
                    if (_ArrowLinePoints[i].X < _ArrowLinePoints[i + 1].X)
                    {
                        int width = _ArrowLinePoints[i + 1].X - _ArrowLinePoints[i].X;
                        int height = _sizeArrowhead;
                        _colliders[i] = new Rectangle(_ArrowLinePoints[i].X, _ArrowLinePoints[i].Y - _sizeArrowhead / 2, width, height);
                    }
                    else if (_ArrowLinePoints[i].X > _ArrowLinePoints[i + 1].X)
                    {
                        int width = (_ArrowLinePoints[i + 1].X - _ArrowLinePoints[i].X) * (-1);
                        int height = _sizeArrowhead;
                        _colliders[i] = new Rectangle(_ArrowLinePoints[i + 1].X, _ArrowLinePoints[i].Y - _sizeArrowhead / 2, width, height);
                    }
                    else if (_ArrowLinePoints[i].Y < _ArrowLinePoints[i + 1].Y)
                    {
                        int width = _sizeArrowhead;
                        int height = (_ArrowLinePoints[i + 1].Y - _ArrowLinePoints[i].Y);
                        _colliders[i] = new Rectangle(_ArrowLinePoints[i].X - _sizeArrowhead / 2, _ArrowLinePoints[i].Y, width, height);
                    }
                    else if (_ArrowLinePoints[i].Y > _ArrowLinePoints[i + 1].Y)
                    {
                        int width = _sizeArrowhead;
                        int height = (_ArrowLinePoints[i + 1].Y - _ArrowLinePoints[i].Y) * (-1);
                        _colliders[i] = new Rectangle(_ArrowLinePoints[i].X - _sizeArrowhead / 2, _ArrowLinePoints[i + 1].Y, width, height);
                    }
                }
            }
        }
    }
}
