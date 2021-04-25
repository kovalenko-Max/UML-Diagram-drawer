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
        private int _sizeArrowhead;
        private Pen _pen;
        private Color _lastColor;

        public IArrowHead ArrowHead { get; set; }
        public IArrowLine ArrowLine { get; set; }
        public IArrowNock ArrowNock { get; set; }
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
                
        public Arrow()
        {
            _pen = (Pen)Default.Draw.Pen.Clone();
            _lastColor = _pen.Color;
            _sizeArrowhead = (int)_pen.Width * 3;

            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

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
            _lastColor = _pen.Color;
            _sizeArrowhead = (int)_pen.Width * 3;
            ArrowHead = arrowHead;
            ArrowLine = arrowLine;
            ArrowNock = arrowNock;
            StartPoint = new ContactPoint(Point.Empty);
            EndPoint = new ContactPoint(Point.Empty);
        }

        public Arrow(Arrow arrow, IArrowLine arrowLine, IArrowHead arrowHead = null, IArrowNock arrowNock = null)
        {
            _pen = new Pen(arrow.Color, arrow.WidthLine);
            StartPoint = arrow.StartPoint;
            EndPoint = arrow.EndPoint;
            Color = arrow.Color;
            WidthLine = arrow.WidthLine;
            IsSelected = arrow.IsSelected;
            _lastColor = arrow._lastColor;
            _sizeArrowhead = (int)_pen.Width * 3;
            ArrowHead = arrowHead;
            ArrowLine = arrowLine;
            ArrowNock = arrowNock;
        }

        public void Draw()
        {
            _ArrowLinePoints = ArrowsLineDrawingLogic.GetPoints(StartPoint, EndPoint);
            if (IsSelected)
            {
                _pen.Color = Default.Draw.PenSelect.Color;
            }
            else if (!IsSelected)
            {
                _pen.Color = _lastColor;
            }

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

        public bool Select(Point point)
        {
            bool result = false;
            foreach (Rectangle rectangle in _colliders)
            {
                if (rectangle.Contains(point))
                {
                    _lastColor = _pen.Color;
                    Color = Default.Draw.PenSelect.Color;
                    result = true;
                    IsSelected = true;
                    break;
                }
            }

            return result;
        }
        public void SetColor(Color color)
        {
            _lastColor = color;
            Color = color;
        }
        public bool Contains(Point point)
        {
            bool result = false;
            foreach (Rectangle rectangle in _colliders)
            {
                if (rectangle.Contains(point))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public void RemoveSelect()
        {
            IsSelected = false;
        }

        public Arrow Clone()
        {
            Arrow arrow = new Arrow(ArrowLine, ArrowHead, ArrowNock, _pen);
            arrow.StartPoint = StartPoint;
            arrow.EndPoint = EndPoint;
            arrow.Color = Color;
            arrow.WidthLine = WidthLine;
            arrow.IsSelected = IsSelected;
            arrow._lastColor = _lastColor;

            return arrow;
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