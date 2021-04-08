using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public abstract class AbstactArrow :Control, ISelected,IMove
    {
        private int _width = 5;
        private int _selectWigth = 10;
        private int _defaultWidth = 5;
        private int _sizeArrowhead;
        private Point _tempPointStartMove = Point.Empty;
        private Point _from = Point.Empty;
        private Point _to = Point.Empty;
        private Color _selectColor = Color.Blue;
        private Color _defaultColor = Color.Black;
        private Color _color = Color.Black;
        private Point[] _points;
        private Rectangle[] _rectangls;

        public bool IsSelected { get; set; } = false;
        public bool IsHorizontal { get; set; } = true;
        public Graphics Graphics { get; set; }
        public Pen Pen { get; set; }
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                Pen.Color = _color;
            }
        }
        public Point From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
            }
        }
        public Point To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value > 0 ? value : 0;
                Pen.Width = _width;
                _sizeArrowhead = _width * 3;
            }
        }
        public int SizeArrowhead
        {
            get
            {
                return _sizeArrowhead;
            }
            set
            {
                _sizeArrowhead = value > 0 ? value : 0;
            }
        }

        public bool IsMove { get; set; } = false;

        public abstract void Draw();

        public void DrawStraightBrokenLine(int wipeFromStartArrow = 0, int wipeFromEndArrow = 0)
        {
            if (!From.IsEmpty && !To.IsEmpty)
            {
                if (IsHorizontal)
                {
                    wipeFromEndArrow = To.X > From.X ? wipeFromEndArrow * (-1) : wipeFromEndArrow;
                    wipeFromStartArrow = To.X > From.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    _points = new Point[]
                    {
                        new Point(From.X+wipeFromStartArrow,From.Y),
                        new Point((To.X + From.X) / 2,From.Y),
                        new Point((To.X + From.X) / 2,To.Y),
                        new Point(To.X+wipeFromEndArrow,To.Y)
                    };

                    Graphics.DrawLines(Pen, _points);
                }
                else
                {
                    wipeFromEndArrow = To.Y < From.Y ? wipeFromEndArrow : wipeFromEndArrow * (-1);
                    wipeFromStartArrow = To.X > From.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    _points = new Point[]
                    {
                        new Point(From.X+wipeFromStartArrow,From.Y),
                        new Point(To.X, From.Y),
                        new Point(To.X,To.Y+wipeFromEndArrow)
                    };

                    Graphics.DrawLines(Pen, _points);
                }

                CreateRectangles();
            }
        }

        public bool Select(Point point)
        {
            foreach (Rectangle rectangle in _rectangls)
            {
                if (rectangle.Contains(point))
                {
                    IsSelected = true;
                    Color = _selectColor;
                    Width = _selectWigth;
                    return true;
                }
            }

            return false;
        }

        public void RemoveSelect()
        {
            if (IsSelected)
            {
                IsSelected = false;
                Width = _defaultWidth;
                Color = _defaultColor;
            }
        }

        public override bool Equals(object obj)
        {
            if(!(obj is null))
            {
                if(obj is AbstactArrow)
                {
                    var temp = (AbstactArrow)obj;
                    if (From == temp.From && To == temp.To)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new ArgumentException("Incorrect object type");
                }
            }
            else
            {
                throw new ArgumentNullException($"Object {obj} is null");
            }
        }

        private void CreateRectangles()
        {
            if (_points.Count() > 0)
            {
                _rectangls = new Rectangle[_points.Count() - 1];
                for (int i = 0; i < _rectangls.Count(); i++)
                {
                    if (_points[i].X < _points[i + 1].X)
                    {
                        int width = _points[i + 1].X - _points[i].X;
                        int height = SizeArrowhead;
                        _rectangls[i] = new Rectangle(_points[i].X, _points[i].Y - SizeArrowhead / 2, width, height);
                    }
                    else if (_points[i].X > _points[i + 1].X)
                    {
                        int width = (_points[i + 1].X - _points[i].X) * (-1);
                        int height = SizeArrowhead;
                        _rectangls[i] = new Rectangle(_points[i + 1].X, _points[i].Y - SizeArrowhead / 2, width, height);
                    }
                    else if (_points[i].Y < _points[i + 1].Y)
                    {
                        int width = SizeArrowhead;
                        int height = (_points[i + 1].Y - _points[i].Y);
                        _rectangls[i] = new Rectangle(_points[i].X - SizeArrowhead / 2, _points[i].Y, width, height);
                    }
                    else if (_points[i].Y > _points[i + 1].Y)
                    {
                        int width = SizeArrowhead;
                        int height = (_points[i + 1].Y - _points[i].Y) * (-1);
                        _rectangls[i] = new Rectangle(_points[i].X - SizeArrowhead / 2, _points[i + 1].Y, width, height);
                    }
                }
            }
        }

        public void Move(Point point)
        {
            IsMove = true;
            _from.X = From.X + (point.X - _tempPointStartMove.X);
            _from.Y = From.Y + (point.Y - _tempPointStartMove.Y);
            _to.X = To.X + (point.X - _tempPointStartMove.X);
            _to.Y = To.Y + (point.Y - _tempPointStartMove.Y);
        }

        public void StartMove(Point point)
        {
            if (!IsMove)
            { 
                IsMove = true;
                _tempPointStartMove = point;
            }
        }

        public void EndMove()
        {
            IsMove = false;
            _tempPointStartMove = Point.Empty;
        }
    }
}
