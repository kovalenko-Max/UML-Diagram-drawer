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

        bool Check = false;
        private Point _fromPoint = Point.Empty;
        private Point _toPoint = Point.Empty;
        private Point _movePoint = Point.Empty;

        private ArrowSuccession tempArrow;

        private List<ArrowSuccession> _arrows = new List<ArrowSuccession>();

        private Squere tempSquere;

        private List<Squere> squeres = new List<Squere>();

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
        private void CreateSqueres(Point point)
        {
            if (tempSquere is null)
            {
                tempSquere = new Squere(Color.Red);
                tempSquere.Location = point;
                
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Right)
            {
                _fromPoint = e.Location;
                CreateSqueres(e.Location);
            }
            if (e.Button == MouseButtons.Left)
            {
                _fromPoint = e.Location;
                _movePoint = e.Location;
                Check = true;
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
               // _arrows.Add(tempArrow);
            }
            Check = false;
            //_fromPoint = Point.Empty;
            //_toPoint = Point.Empty;
            tempArrow = null;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                _toPoint = e.Location;
                _movePoint = e.Location;
            }

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            CreateArrow(e.Graphics);

            foreach (var arrow in _arrows)
            {
                arrow.Draw(e.Graphics, arrow.From, arrow.To);
            }
            if(tempSquere != null)
            {
                tempSquere.Draw(e.Graphics);
            }
            if (Check)
            {
                tempSquere.Location = _movePoint;
                tempSquere.OnCollisionEnter(e.Graphics,_fromPoint);
            }
            if (!_fromPoint.IsEmpty && !_toPoint.IsEmpty)
            {
                //tempArrow.Draw(e.Graphics, _fromPoint, _toPoint);
            }
        }
    }
}
