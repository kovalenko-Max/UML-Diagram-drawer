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
        private ContactPoint _currntCountactPoint;
        private AbstactArrow _arrow;
        private AbstractForm _formUML;
        private IFormsFactory _formFactory;

        private AbstractForm _buffer;


        public List<AbstractForm> FormsList;
        public AbstractForm CurrentForm;

        public List<AbstactArrow> ArrowsList;
        public AbstactArrow CurrentArrow;

        public Pen pen = new Pen(Brushes.Black, 3);


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ArrowsList = new List<AbstactArrow>();
            FormsList = new List<AbstractForm>();
            _formFactory = Default.Factory.Form;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (colorDialog1.Color == Color.Black)
            {
                toolStripButton12.ForeColor = Color.White;
            }
            else
            {
                toolStripButton12.ForeColor = Color.Black;
            }

            toolStripButton12.BackColor = colorDialog1.Color;
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

        private void toolStripButtonArrowAssociation_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += MouseDown_DrawArrow;
            _arrow = CreateArrow();
            ArrowsList.Add(_arrow);
        }
        private void toolStripButtonCreateClassForm_Click(object sender, EventArgs e)
        {
            _formFactory = new ClassFormFactory();
            _formUML = _formFactory.GetForm();
            FormsList.Add(_formUML);
            pictureBoxMain.MouseClick += MouseClick_DrawFormUML;
        }
        private void MouseClick_DrawFormUML(object sender, MouseEventArgs e)
        {
            _formUML.Location = e.Location;
            pictureBoxMain.MouseClick -= MouseClick_DrawFormUML;
            pictureBoxMain.MouseClick += MouseClick_SelectObject;
            pictureBoxMain.Invalidate();
        }

        private void MouseClick_SelectObject(object sender, MouseEventArgs e)
        {
            foreach (AbstactArrow arrow in ArrowsList)
            {
                if (arrow.Select(e.Location))
                {
                    _arrow = arrow;
                    ArrowsList.Add(_arrow);
                    ArrowsList.Remove(_arrow);
                    return;
                }
            }

            foreach (AbstractForm form in FormsList)
            {
                if (form.Contains(e.Location))
                {
                    _formUML = form;
                    _formUML.Select(e.Location);
                    FormsList.Add(_formUML);
                    FormsList.Remove(_formUML);
                    return;
                }
            }
            pictureBoxMain.Invalidate();
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
         
        
        private void copyToStackButton_Click(object sender, EventArgs e)
        {
            _buffer = null;
            //foreach (var arrow in ArrowsList)
            //{
            //    if (arrow.IsSelected)
            //    {
            //        _buffer.Add(arrow);
            //    }
            //}

            foreach (AbstractForm form in FormsList)
            {
                if (form.IsSelected)
                {
                    _buffer = new UML_Diagram_drawer.Forms.Form(form);
                }
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToStackButton_Click(sender, e);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += PasteObject_MouseDown;
        }

        private void PasteObject_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_buffer != null)
                {
                    _buffer.Location = e.Location;
                    FormsList.Add(_buffer);
                    _buffer = null;
                }
            }
            pictureBoxMain.MouseDown -= PasteObject_MouseDown;
            pictureBoxMain.Invalidate();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += EditObject_MouseDown;
        }
        private void EditObject_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_formUML != null)
                {
                    _buffer = new UML_Diagram_drawer.Forms.Form(_formUML);
                    FormsList.Remove(_formUML);
                }
            }
            pictureBoxMain.Invalidate();
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
           // pictureBoxMain.MouseMove += pictureBoxMain_MouseMove;
            
        }

        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBoxMain.Size += new System.Drawing.Size(140, 140);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
           
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                pictureBoxMain.Height += e.NewValue - e.OldValue;
            else 
                pictureBoxMain.Width += e.NewValue - e.OldValue;
        }
    }
}
