using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer
{
    public class CanvasPanel : Panel
    {
        public List<FormUML> Forms;
        public FormUML CurrentForm;
        public CanvasPanel()
        {
            Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            Forms = new List<FormUML>();
        }
        public void CreateForm()
        {
            if(CurrentForm == null)
            {
            CurrentForm = new FormUML();

            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                CreateForm();
                CurrentForm.Location = e.Location;
                Forms.Add(CurrentForm);

            }

            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                CurrentForm.Location = e.Location;
            }

            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            
            CurrentForm = null;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            MainGraphics.Graphics = e.Graphics;

            foreach (var form in Forms)
            {
                form.Draw();
            }
        }
    }
}
