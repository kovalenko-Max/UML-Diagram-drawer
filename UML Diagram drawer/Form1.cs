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

namespace UML_Diagram_drawer
{
    public partial class FormMain : Form
    {
        public List<FormUML> FormsList;
        public FormUML CurrentForm;

        public List<AbstactArrow> ArrowsList;
        public AbstactArrow CurrentArrow;

        public ContactPoint SelectContactPoint;
        public Pen pen = new Pen(Brushes.Black, 3);

        private AbstactArrow _arrow;
        private FormUML _formUML;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ArrowsList = new List<AbstactArrow>();
            FormsList = new List<FormUML>();
        }

        private void Button_AddForm_Click(object sender, EventArgs e)
        {
            _formUML = CreateFormUML();
            FormsList.Add(_formUML);
            pictureBoxMain.MouseClick += MouseClick_DrawFormUML;
        }

        private void MouseClick_DrawFormUML(object sender, MouseEventArgs e)
        {
            _formUML.Location = e.Location;
            pictureBoxMain.MouseClick -= MouseClick_DrawFormUML;
            pictureBoxMain.Invalidate();
        }

        private void Button_AddArrow_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += MouseDown_DrawArrow;
            _arrow = CreateArrow();
            ArrowsList.Add(_arrow);
        }

        private void MouseDown_DrawArrow(object sender, MouseEventArgs e)
        {
            _arrow.StartPoint.Location = e.Location;
            _arrow.StartPoint.Side = Side.Bottom;
            pictureBoxMain.MouseMove += MouseMove_DrawArrow;
            pictureBoxMain.MouseUp += MouseUp_DrawArrow;
            pictureBoxMain.Invalidate();
        }

        private void MouseMove_DrawArrow(object sender, MouseEventArgs e)
        {
            if (!(_arrow is null))
            {
                _arrow.EndPoint.Location = e.Location;
                _arrow.EndPoint.Side = Side.Up;
            }
            pictureBoxMain.Invalidate();
        }

        private void MouseUp_DrawArrow(object sender, MouseEventArgs e)
        {
            if (!(_arrow is null))
            {
                _arrow.EndPoint.Location = e.Location;
                _arrow.EndPoint.Side = Side.Up;
            }
            pictureBoxMain.Invalidate();
            pictureBoxMain.MouseDown -= MouseDown_DrawArrow;
            pictureBoxMain.MouseMove -= MouseMove_DrawArrow;
            pictureBoxMain.MouseUp -= MouseUp_DrawArrow;
        }

        private void PictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            MainGraphics.Graphics = e.Graphics;

            foreach (var arrow in ArrowsList)
            {
                arrow.Draw();
            }

            foreach (FormUML form in FormsList)
            {
                form.Draw();
            }

        }

        private AbstactArrow CreateArrow()
        {
            return new ArrowSuccession(pen, MainGraphics.Graphics);
        }

        private FormUML CreateFormUML()
        {
            return new FormUML();
        }
    }
}
