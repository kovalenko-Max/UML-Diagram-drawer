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
        private List<ISelectable> _selectedObjects = new List<ISelectable>();
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
                _selectPoint = e.Location;

                DrawArrowOnMouseDown(e.Location);
                RemoveAllSelectArrow();
                SelectArrow();

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

            if (e.Button == MouseButtons.Left)
            {
                foreach (var item in _selectedObjects)
                {
                    item.Move(e.X - _lastMousePosition.X, e.Y - _lastMousePosition.Y);
                    _lastMousePosition = e.Location;
                }
            }
            _lastMousePosition = e.Location;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                DrawArrowOnMouseUp(e.Location);
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
            _selectArrow = null;
        }

        public void Delete()
        {
            _arrows.Clear();
            _selectedObjects.Clear();
            Invalidate();
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
                foreach (var arrow in _selectedObjects)
                {
                    if (arrow.IsSelected)
                    {
                        arrow.RemoveSelect();
                        //_selectedObjects.Remove(arrow);
                    }
                }
                _selectedObjects.Clear();
                _selectArrow = null;
            }
        }

        private void SelectArrow()
        {
            if (!IsDrawArrow)
            {
                foreach (var arrow in _arrows)
                {
                    if (arrow.Select(_lastMousePosition)&&arrow!=_selectArrow)
                    {
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
