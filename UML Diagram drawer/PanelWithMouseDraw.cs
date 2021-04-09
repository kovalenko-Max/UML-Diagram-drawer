using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer
{
    class PanelWithMouseDraw : Panel
    {
        private Point _fromPoint = Point.Empty;
        private Point _toPoint = Point.Empty;

        public Pen pen = new Pen(Brushes.Blue, 5);

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
                tempArrow = new ArrowSuccession(pen, graphics);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                _fromPoint = e.Location;
                tempArrow.StartPoint.Location = _fromPoint;
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
                tempArrow.StartPoint.Location = _fromPoint;
                tempArrow.EndPoint.Location = _toPoint;
                _arrows.Add(tempArrow);
            }

            _fromPoint = Point.Empty;
            _toPoint = Point.Empty;
            tempArrow = null;

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
                tempArrow.EndPoint.Location = _toPoint;
                tempArrow.Draw();
            }
        }
    }
}
