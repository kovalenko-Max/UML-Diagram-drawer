using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
//using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.Arrows;
using Form = System.Windows.Forms.Form;
using UML_Diagram_drawer.Factory;

namespace UML_Diagram_drawer
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        private ContactPoint _currntCountactPoint;
        private AbstactArrow _arrow;
        private AbstractForm _formUML;
        private IFormsFactory _formFactory;
        public List<AbstractForm> FormsList;

        private AbstractForm _buffer;


        public List<AbstractForm> FormsList;
        public AbstractForm CurrentForm;

        public List<AbstactArrow> ArrowsList;
        public AbstactArrow CurrentArrow;
        
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
            pictureBoxMain.MouseDown += MouseDown_FormMoving;
            FormsList = new List<AbstractForm>();
            _formFactory = Default.Factory.Form;
        }

        #region Tool Strip
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
        #endregion

        private void MouseClick_DrawFormUML(object sender, MouseEventArgs e)
        {
            _formUML.Location = e.Location;
            pictureBoxMain.MouseClick -= MouseClick_DrawFormUML;
            pictureBoxMain.MouseClick += MouseClick_SelectObject;
            pictureBoxMain.Invalidate();
            pictureBoxMain.MouseDown += MouseDown_FormMoving;
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

        private void MouseClick_SelectObject(object sender, MouseEventArgs e)
        {
            //foreach (AbstactArrow arrow in ArrowsList)
            //{
            //    if (arrow.Select(e.Location))
            //    {
            //        _arrow = arrow;
            //        ArrowsList.Add(_arrow);
            //        ArrowsList.Remove(_arrow);
            //        return;
            //    }
            //}

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

        private void PictureBoxMain_Paint(object sender, PaintEventArgs e)
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

            foreach (AbstractForm form in FormsList)
            {
                _formUML.Move(e.X, e.Y);
                pictureBoxMain.Invalidate();
            }
        }
        private AbstactArrow CreateArrow()
        {
            return new ArrowSuccession(pen);
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

        private void toolStripButtonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileDataForms = JsonSerialize(TypeOfData.Forms);
                string fileDataArrows = JsonSerialize(TypeOfData.Arrows);
                SaveAndLoad.SaveFile(saveFileDialog1.FileName, fileDataForms, fileDataArrows);
            }
        }

        private void toolStripButtonOpenFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Переустановить виндовс?", "Во халепа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileData = SaveAndLoad.OpenFile(openFileDialog1.FileName, TypeOfData.Forms);
                JsonDeserialize(fileData);
            }
        }

        public string JsonSerialize(TypeOfData type)
        {
            if (type == TypeOfData.Forms)
            {
                string fileDataForms = JsonConvert.SerializeObject(FormsList, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
                return fileDataForms;
            }
            else if (type == TypeOfData.Arrows)
            {
                string fileDataArrows = JsonConvert.SerializeObject(ArrowsList, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
                return fileDataArrows;
            }
            throw new Exception();
        }

        public void JsonDeserialize(string[] fileData)
        {
            if (fileData[0] != String.Empty)
            {
                FormsList = JsonConvert.DeserializeObject<List<AbstractForm>>(fileData[0],
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
            }
            else
            {
                FormsList = new List<AbstractForm>();
            }

            if (fileData[1] != null)
            {

                ArrowsList = JsonConvert.DeserializeObject<List<AbstactArrow>>(fileData[1],
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
            }
            else
            {
                ArrowsList = new List<AbstactArrow>();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            FormEditor form = new FormEditor(_formUML,pictureBoxMain);
            form.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
