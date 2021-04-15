using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.Arrows;
using System.Drawing;

namespace UML_Diagram_drawer
{
    public class CanvasPanel : Panel
    {
        public List<FormUML> Forms;
        public FormUML CurrentForm;

        public List<AbstactArrow> ArrowsList;
        public AbstactArrow CurrentArrow;

        public ContactPoint SelectContactPoint;
        public Pen pen = new Pen(Brushes.Black, 3);

        public bool IsFormDraw { get; set; }
        public CanvasPanel()
        {
            Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            Forms = new List<FormUML>();
            ArrowsList = new List<AbstactArrow>();
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
                if (IsFormDraw)
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
                if (IsFormDraw)
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
                if (IsFormDraw)
                {
                    CurrentForm = null;
                    IsFormDraw = false;
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

        public void OnMouseDown_Arrow(MouseEventArgs e)
        {
            CurrentArrow = new ArrowSuccession(pen, MainGraphics.Graphics);
            CurrentArrow.StartPoint.Location = e.Location;
        }

    }
}
