using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Factory;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer
{
    public class CanvasPanel : Panel
    {
        public List<AbstractForm> Forms;
        public AbstractForm CurrentForm;
        public AbstractForm SelectForm;
        public Point LastMousePosition;
        public ContactPoint SelectContactPoint;
        public TextField selectText;
        public bool IsDraw { get; set; }
        public bool IsRedactor { get; set; }
        public bool IsRemove { get; set; }
        public CanvasPanel()
        {
            Dock = DockStyle.Fill;
            this.DoubleBuffered = true;
            Forms = new List<AbstractForm>();
        }

        private void CreateForm()
        {
            if (CurrentForm == null)
            {
                //var t=new ClassFormFactory();
                CurrentForm = new InterfaceFormFactory().GetForm();
            }
        }

        public void RedactorTextField(string text)
        {
            if (IsRedactor)
            {
                selectText.Brush = new SolidBrush(Color.Red);
                selectText.Text = text;
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
                    //foreach (var form in Forms)
                    //{
                    //    foreach (var contactPoint in form.ContactPoints)
                    //    {
                    //        if (contactPoint.Select(e.Location))
                    //        {
                    //            SelectContactPoint = form.ConnectArrow(e.Location);
                    //        }
                    //    }
                    //}
                    //foreach (var form in Forms)
                    //{
                    //    if (form.Select(e.Location))
                    //    {
                    //        SelectForm = form;
                    //    }
                    //}
                    if (IsRedactor)
                    {
                        foreach (var form in Forms)
                        {
                            //form.ChangeTextField(e.Location)
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
                else
                {
                    if (SelectForm != null)
                    {
                        SelectForm.Move(e.X - LastMousePosition.X, e.Y - LastMousePosition.Y);
                        LastMousePosition = e.Location;
                    }
                }
            }
            LastMousePosition = e.Location;

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
                else
                {
                    SelectForm = null;
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
