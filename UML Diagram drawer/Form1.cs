using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Factory;

namespace UML_Diagram_drawer
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public List<AbstractForm> FormsList;

        public List<AbstactArrow> ArrowsList;
        public AbstactArrow CurrentArrow;

        private ContactPoint _currntCountactPoint;
        public Pen pen = new Pen(Brushes.Black, 3);

        private AbstactArrow _arrow;
        private AbstractForm _formUML;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ArrowsList = new List<AbstactArrow>();
            FormsList = new List<AbstractForm>();
            pictureBoxMain.MouseDown += MouseDown_FormMoving;
        }

        private void Button_AddForm_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown -= MouseDown_FormMoving;
            _formUML = CreateFormUML();
            FormsList.Add(_formUML);
            pictureBoxMain.MouseClick += MouseClick_DrawFormUML;
        }

        private void MouseClick_DrawFormUML(object sender, MouseEventArgs e)
        {
            _formUML.Location = e.Location;
            pictureBoxMain.MouseClick -= MouseClick_DrawFormUML;
            pictureBoxMain.Invalidate();
            pictureBoxMain.MouseDown += MouseDown_FormMoving;
        }

        private void Button_AddArrow_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown -= MouseDown_FormMoving;
            pictureBoxMain.MouseDown += MouseDown_DrawArrow;
            _arrow = CreateArrow();
            ArrowsList.Add(_arrow);
        }

        private void MouseDown_DrawArrow(object sender, MouseEventArgs e)
        {
            foreach (var form in FormsList)
            {
                foreach (var contactPoint in form.ContactPoints)
                {
                    if (contactPoint.Contains(e.Location))
                    {
                        _currntCountactPoint = form.ConnectArrow(e.Location);
                    }
                }
            }

            if (!(_currntCountactPoint is null))
            {
                _arrow.StartPoint = _currntCountactPoint;
                _currntCountactPoint = null;
                pictureBoxMain.MouseMove += MouseMove_DrawArrow;
                pictureBoxMain.MouseUp += MouseUp_DrawArrow;
                pictureBoxMain.Invalidate();
            }
        }

        private void MouseMove_DrawArrow(object sender, MouseEventArgs e)
        {
            if (!(_arrow is null))
            {
                _arrow.EndPoint.Location = e.Location;

            }

            pictureBoxMain.Invalidate();
        }

        private void MouseUp_DrawArrow(object sender, MouseEventArgs e)
        {
            foreach (var form in FormsList)
            {
                foreach (var contactPoint in form.ContactPoints)
                {
                    if (contactPoint.Contains(e.Location))
                    {
                        _currntCountactPoint = form.ConnectArrow(e.Location);
                    }
                }
            }

            if (!(_arrow is null))
            {
                if (!(_currntCountactPoint is null))
                {
                    _arrow.EndPoint = _currntCountactPoint;
                    _currntCountactPoint = null;

                    pictureBoxMain.MouseDown -= MouseDown_DrawArrow;
                    pictureBoxMain.MouseMove -= MouseMove_DrawArrow;
                    pictureBoxMain.MouseUp -= MouseUp_DrawArrow;
                    pictureBoxMain.MouseDown += MouseDown_FormMoving;
                }
                else
                {
                    ArrowsList.Remove(_arrow);
                    _arrow = CreateArrow();
                    ArrowsList.Add(_arrow);
                    pictureBoxMain.MouseMove -= MouseMove_DrawArrow;
                    pictureBoxMain.MouseUp -= MouseUp_DrawArrow;
                    pictureBoxMain.MouseDown += MouseDown_FormMoving;
                }

                pictureBoxMain.Invalidate();
            }
        }

        private void MouseDown_FormMoving(object sender, MouseEventArgs e)
        {
            if (FormsList.Count > 0)
            {
                foreach (var form in FormsList)
                {
                    if (form.Select(e.Location))
                    {
                        _formUML = form;
                        pictureBoxMain.MouseMove += MouseMove_FormMoving;
                        pictureBoxMain.MouseUp += MouseUp_FormMoving;
                    }
                }
            }
        }

        private void MouseMove_FormMoving(object sender, MouseEventArgs e)
        {
            if (_formUML != null)
            {
                _formUML.Move(e.X, e.Y);
                pictureBoxMain.Invalidate();
            }
        }

        private void MouseUp_FormMoving(object sender, MouseEventArgs e)
        {
            _formUML = null;
            pictureBoxMain.MouseMove -= MouseMove_FormMoving;
            pictureBoxMain.MouseUp += MouseUp_FormMoving;
            pictureBoxMain.Invalidate();
        }

        private void PictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            MainGraphics.Graphics = e.Graphics;

            foreach (var arrow in ArrowsList)
            {
                arrow.Draw();
            }

            foreach (AbstractForm form in FormsList)
            {
                form.Draw();
            }
        }

        private AbstactArrow CreateArrow()
        {
            return new ArrowSuccession(pen, MainGraphics.Graphics);
        }

        private AbstractForm CreateFormUML()
        {
            return new ClassFormFactory().GetForm();
        }
    }
}
