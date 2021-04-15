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

        public ContactPoint SelectContactPoint;
        public bool IsDraw { get; set; }

        public CanvasPanel()
        {
            Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            Forms = new List<FormUML>();
        }
        public void CreateForm()
        {
            if (CurrentForm == null)
            {
                CurrentForm = new FormUML();

            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                if (IsDraw)
                {
                    CreateForm();
                    CurrentForm.Location = e.Location;
                    Forms.Add(CurrentForm);
                }
                else
                {
                    foreach (var form in Forms)
                    {
                        foreach (var contactPoint in form.ContactPoints)
                        {
                            if (contactPoint.Select(e.Location))
                            {
                                SelectContactPoint = form.ConnectArrow(e.Location);
                            }
                        }
                    }
                }
            }

            Invalidate();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                if (IsDraw)
                {
                    CurrentForm.Location = e.Location;
                }
            }

            Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Left)
            {
                if (IsDraw)
                {
                    CurrentForm = null;
                    IsDraw = false;
                }
            }

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
