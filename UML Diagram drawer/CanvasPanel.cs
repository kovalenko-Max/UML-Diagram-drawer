using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer
{
    class CanvasPanel : Panel
    {
        private AbstactFormClass _form;

        public CanvasPanel()
        {
            Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (_form == null)
            {
                _form = new AbstactFormClass(isDrawFields: true, isDrawMethods: true);
                this.Controls.Add(_form);
            }

            _form.Location = e.Location;

            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_form != null)
            {
                //_form.Graphics = e.Graphics;
                MainGraphics.Graphics = e.Graphics;
                _form.Draw();
            }
        }
    }
}
