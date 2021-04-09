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
        private Point _brokePoint = Point.Empty;

        private ArrowSuccession tempArrow;

        private List<ArrowSuccession> _arrows = new List<ArrowSuccession>();

        public PanelWithMouseDraw()
        {
            Dock = DockStyle.Fill;
            DoubleBuffered = true;
        }

        private void CreateArrow(Graphics graphics)
        {
            if (tempArrow is null)
            {
                tempArrow = new ArrowSuccession(graphics, Color.Red);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                _fromPoint = e.Location;
                tempArrow.From = _fromPoint;
            }
            else
            {
                _toPoint = Point.Empty;
            }

            _toPoint = Point.Empty;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (!_fromPoint.IsEmpty && !_toPoint.IsEmpty)
            {
                tempArrow.From = _fromPoint;
                tempArrow.Broke = _brokePoint;
                tempArrow.To = _toPoint;
                _arrows.Add(tempArrow);
            }

            _fromPoint = Point.Empty;
            _toPoint = Point.Empty;
            _brokePoint = Point.Empty;
            tempArrow = null;

            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Right)
            {
                _toPoint = e.Location;
                _brokePoint.X = _fromPoint.X;
                _brokePoint.Y = _toPoint.Y;
            }
            if (e.Button == MouseButtons.Left)
            {
                _toPoint = e.Location;
                _brokePoint.X = _toPoint.X;
                _brokePoint.Y = _fromPoint.Y;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            CreateArrow(e.Graphics);

            foreach (var arrow in _arrows)
            {
                arrow.Graphics = e.Graphics;
                arrow.Draw();
            }

            if (!_fromPoint.IsEmpty && !_toPoint.IsEmpty)
            {
                tempArrow.Graphics = e.Graphics;
                tempArrow.From = _fromPoint;
                tempArrow.Broke = _brokePoint;
                tempArrow.To = _toPoint;
                tempArrow.Draw();
            }
        }
    }
}
