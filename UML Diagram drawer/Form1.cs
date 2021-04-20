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
using Form = System.Windows.Forms.Form;
using UML_Diagram_drawer.Factory;

namespace UML_Diagram_drawer
{
    public partial class FormMain : Form
    {
        public List<AbstractForm> FormsList;
        public AbstractForm CurrentForm;

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
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if(colorDialog1.Color==Color.Black)
            {
                toolStripButton12.ForeColor = Color.White;
            }
            else
            {
                toolStripButton12.ForeColor = Color.Black;
            }

            toolStripButton12.BackColor = colorDialog1.Color;
        private void Button_AddForm_Click(object sender, EventArgs e)
        {
            _formUML = CreateFormUML();
            FormsList.Add(_formUML);
            pictureBoxMain.MouseClick += MouseClick_DrawFormUML;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void toolStrip1_MouseLeave(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            pictureBox1.Visible = true;
        }

        private void toolStripButtonArrowAssociation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowSuccession_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowRealization_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowAggregation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowAggregationAndAssociation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowComposition_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowCompositionAndAssociation_Click(object sender, EventArgs e)
        {

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

            if(!(_currntCountactPoint is null))
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
                }
                else
                {
                    ArrowsList.Remove(_arrow);
                    _arrow = CreateArrow();
                    ArrowsList.Add(_arrow);
                    pictureBoxMain.MouseMove -= MouseMove_DrawArrow;
                    pictureBoxMain.MouseUp -= MouseUp_DrawArrow;
                }
                pictureBoxMain.Invalidate();
            }
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
