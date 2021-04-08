using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    class PanelWithMouseDraw : Panel
    {
        private Point _lastMousePosition = Point.Empty;
        private Point _selectPoint = Point.Empty;
        private AbstactArrow _drawingArrow;
        private AbstactArrow _selectArrow;
        private List<AbstactArrow> _arrows = new List<AbstactArrow>();
        private List<ISelected> _selectedObjects = new List<ISelected>();
        private Graphics _graphics;

        public bool IsDrawArrow { get; set; }

        public PanelWithMouseDraw()
        {
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                DrawArrowOnMouseDown(e.Location);

                RemoveAllSelectArrow();
                _selectPoint = e.Location;
                SelectArrow();
                MoveArrow();
            }
            else
            {
                RemoveSelectArrow();
            }

            Invalidate();
            
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            _lastMousePosition = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                MoveArrow();
                Invalidate();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                DrawArrowOnMouseUp(e.Location);
                EndMove();
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            _graphics = e.Graphics;

            DrawArrow();

            foreach (var item in _selectedObjects)
            {
                item.Graphics = _graphics;
                item.Draw();
            }
        }

        private void CreateArrow(Graphics graphics)
        {
            if (_drawingArrow is null)
            {
                _drawingArrow = new ArrowSuccession(graphics, Color.Black);
            }
        }

        private void RemoveSelectArrow()
        {
            foreach (var arrow in _arrows)
            {
                if (arrow.Select(_lastMousePosition))
                {
                    arrow.RemoveSelect();
                    _selectedObjects.Remove(arrow);
                }
            }
        }

        private void RemoveAllSelectArrow()
        {
            bool isSelect = false;

            foreach (var arrow in _arrows)
            {
                if (arrow.Select(_lastMousePosition))
                {
                    isSelect = true;
                    break;

                }
            }
            if (!isSelect)
            {
                foreach (var arrow in _arrows)
                {
                    if (arrow.IsSelected)
                    {
                        arrow.RemoveSelect();
                        _selectedObjects.Remove(arrow);
                    }
                }
            }
        }

        private void MoveArrow()
        {
            if(!(_selectArrow is null))
            {
                if (_selectArrow.Select(_lastMousePosition))
                {
                    _selectArrow.StartMove(_lastMousePosition);
                    _selectArrow.Move(_lastMousePosition);
                }
            }
        }
        private void EndMove()
        {
            if (!(_selectArrow is null))
            {
                if (_selectArrow.Select(_lastMousePosition))
                {
                    _selectArrow.EndMove();
                }
            }
        }
        private void SelectArrow()
        {
            if (!IsDrawArrow)
            {
                foreach (var arrow in _arrows)
                {
                    if (arrow.Select(_lastMousePosition))
                    {
                        //arrow.Color = _selectedColor;
                        //arrow.Width = _selectedWight;
                        _selectArrow = arrow;
                        _selectedObjects.Add(arrow);
                        break;
                    }
                }
            }
        }

        private void DrawArrowOnMouseDown(Point location)
        {
            if (IsDrawArrow)
            {
                _drawingArrow.From = location;
            }
        }

        private void DrawArrowOnMouseUp(Point location)
        {
            if (IsDrawArrow)
            {
                if (!(_drawingArrow is null))
                {
                    _drawingArrow.To = location;
                    _arrows.Add(_drawingArrow);
                }
                _drawingArrow = null;
                IsDrawArrow = false;
            }
        }

        private void DrawArrow()
        {
            CreateArrow(_graphics);

            foreach (var arrow in _arrows)
            {
                arrow.Graphics = _graphics;
                arrow.Draw();
            }

            if (!(_drawingArrow is null))
            {
                _drawingArrow.Graphics = _graphics;
                _drawingArrow.To = _lastMousePosition;
                _drawingArrow.Draw();
            }
        }
    }
}
