using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public abstract class AbstactArrow:ISelected
    {
        private int _width = 5;
        private int _sizeArrowhead;
        private Point _from = Point.Empty;
        private Point _to = Point.Empty;
        private Color _selectColor = Color.Blue;
        private Color _defaultColor = Color.Black;
        private Color _color;
        private Point[] _points;
        private Rectangle[] _rectangls;

        public bool IsHorizontal { get; set; }
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

        public abstract void Draw();

        public void DrawStraightBrokenLine(int wipeFromStartArrow = 0, int wipeFromEndArrow = 0)
        {
            if (!From.IsEmpty && !To.IsEmpty)
            {
                Point[] Points;

                if (IsHorizontal)
                {
                    wipeFromEndArrow = To.X > From.X ? wipeFromEndArrow * (-1) : wipeFromEndArrow;
                    wipeFromStartArrow = To.X > From.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    Points = new Point[]
                    {
                        new Point(From.X+wipeFromStartArrow,From.Y),
                        new Point((To.X + From.X) / 2,From.Y),
                        new Point((To.X + From.X) / 2,To.Y),
                        new Point(To.X+wipeFromEndArrow,To.Y)
                    };

                    Graphics.DrawLines(Pen, Points);
                }
                else
                {
                    wipeFromEndArrow = To.Y < From.Y ? wipeFromEndArrow : wipeFromEndArrow * (-1);
                    wipeFromStartArrow = To.X > From.X ? wipeFromStartArrow : wipeFromStartArrow * (-1);

                    Points = new Point[]
                    {
                        new Point(From.X+wipeFromStartArrow,From.Y),
                        new Point(To.X, From.Y),
                        new Point(To.X,To.Y+wipeFromEndArrow)
                    };

                    Graphics.DrawLines(Pen, Points);
                }
                
            }
        }

        public void Select()
        {
            Color = _selectColor;
            Draw();
        }

        public void RemoveSelect()
        {
            Color = _defaultColor;
            Draw();
        }

        private void CreateRectangls()
        {
            _rectangls = new Rectangle[_points.Count() - 1];
            for (int i = 0; i < _rectangls.Count(); i++)
            {
                if (_points[i].X < _points[i + 1].X) 
                {
                    int width = _points[i + 1].X - _points[i].X;
                    int height = SizeArrowhead;
                    _rectangls[i] = new Rectangle(_points[i].X,_points[i].Y-SizeArrowhead/2,width,height);
                }
                else if(_points[i].X > _points[i + 1].X)
                {
                    int width = (_points[i + 1].X - _points[i].X)*(-1);
                    int height = SizeArrowhead;
                    _rectangls[i] = new Rectangle(_points[i+1].X, _points[i].Y - SizeArrowhead / 2, width, height);
                }
                else if(_points[i].Y < _points[i + 1].Y)
                {
                    int width = SizeArrowhead;
                    int height = (_points[i + 1].Y - _points[i].Y) * (-1);
                    _rectangls[i] = new Rectangle(_points[i].X - SizeArrowhead / 2, _points[i].Y, width, height);
                }
                else if(_points[i].Y > _points[i + 1].Y)
                {
                    int width = SizeArrowhead;
                    int height = (_points[i + 1].Y - _points[i].Y) * (-1);
                    _rectangls[i] = new Rectangle(_points[i].X - SizeArrowhead / 2, _points[i+1].Y, width, height);
                }
            }

            Graphics.DrawRectangles(Pen, _rectangls);
        }
    }
}
