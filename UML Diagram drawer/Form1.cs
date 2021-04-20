using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string pathSaveFile = saveFileDialog1.FileName;
            string fileData = JsonSerialize();
            SaveAndLoad.SaveFile(pathSaveFile, fileData);
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string pathOpenFile = saveFileDialog1.FileName;
            string fileDataForms = SaveAndLoad.OpenFile(pathOpenFile, TypeOfData.Forms);
            string fileDataArrows = SaveAndLoad.OpenFile(pathOpenFile, TypeOfData.Arrows);
            JsonDeserialize(fileDataForms, fileDataArrows);
        }

        public string JsonSerialize()
        {
            string fileData = JsonSerializer.Serialize<List<AbstractForm>>(FormsList);
            fileData += JsonSerializer.Serialize<List<AbstactArrow>>(ArrowsList);
            return fileData;
        }

        public void JsonDeserialize(string fileDataForms, string fileDataArrows)
        {
            FormsList = JsonSerializer.Deserialize<List<AbstractForm>>(fileDataForms);
            ArrowsList = JsonSerializer.Deserialize<List<AbstactArrow>>(fileDataArrows);        
        }
    }
}
