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
        private Point _fromPoint = Point.Empty;
        private Point _toPoint = Point.Empty;

        private ArrowSuccession _tempArrow;

        private List<ArrowSuccession> _arrows = new List<ArrowSuccession>();

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
                _fromPoint = e.Location;
                _tempArrow.From = e.Location;
            }
            
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                _toPoint = e.Location;
            }

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                if (!_fromPoint.IsEmpty && !_toPoint.IsEmpty)
                {
                    _tempArrow.From = _fromPoint;
                    _tempArrow.To = _toPoint;
                    _arrows.Add(_tempArrow);
                }

                _fromPoint = Point.Empty;
                _toPoint = Point.Empty;
                _tempArrow = null;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawingArrow(e.Graphics);
        }

        private void CreateArrow(Graphics graphics)
        {
            if (_tempArrow is null)
            {
                _tempArrow = new ArrowSuccession(graphics, Color.Red);
            }
        }

        private void DrawingArrow(Graphics graphics)
        {
            CreateArrow(graphics);

            foreach (var arrow in _arrows)
            {
                arrow.Graphics = graphics;
                arrow.Draw();
            }

            if (!_fromPoint.IsEmpty && !_toPoint.IsEmpty)
            {
                _tempArrow.Graphics = graphics;
                _tempArrow.To = _toPoint;
                _tempArrow.Draw();
            }
        }
    }
}
