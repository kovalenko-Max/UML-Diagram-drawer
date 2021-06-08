﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.Arrows;
using Form = System.Windows.Forms.Form;
using UML_Diagram_drawer.Factory;
using UML_Diagram_drawer.MouseHandlers;
using UML_Diagram_drawer.Factory.ArrowFactories;

namespace UML_Diagram_drawer
{
    public partial class FormMain : Form
    {
        private MainData _mainData;

        public Pen pen = new Pen(Brushes.Black, 3);

        public FormMain()
        {
            InitializeComponent();
        }

        #region Json
        private string JsonSerialize(TypeOfData type)
        {
            if (type == TypeOfData.Forms)
            {
                string fileDataForms = JsonConvert.SerializeObject(_mainData.FormsList, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });

                return fileDataForms;
            }
            else if (type == TypeOfData.Arrows)
            {
                string fileDataArrows = JsonConvert.SerializeObject(_mainData.ArrowsList, Formatting.Indented,
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });

                return fileDataArrows;
            }
            throw new Exception();
        }

        private void JsonDeserialize(string[] fileData)
        {
            if (fileData[0] != String.Empty)
            {
                _mainData.FormsList = JsonConvert.DeserializeObject<List<AbstractForm>>(fileData[0],
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
            }
            else
            {
                _mainData.FormsList = new List<AbstractForm>();
            }

            if (fileData[1] != String.Empty)
            {

                _mainData.ArrowsList = JsonConvert.DeserializeObject<List<Arrow>>(fileData[1],
                    new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    });
                foreach (var item in _mainData.ArrowsList)
                {
                    item.Color = Color.Black;
                }
            }
            else
            {
                _mainData.ArrowsList = new List<Arrow>();
            }
        }

        #endregion

        private void RemoveArrowСonnections()
        {
            foreach (Arrow arrow in _mainData.ArrowsList)
            {
                foreach (AbstractForm form in _mainData.FormsList)
                {
                    foreach (ContactPoint point in form.ContactPoints)
                    {
                        if (arrow.StartPoint.Equals(point))
                        {
                            arrow.StartPoint = point;
                        }
                        else
                        {
                            arrow.StartPoint.Location = Point.Empty;
                        }
                        if (arrow.EndPoint.Equals(point))
                        {
                            arrow.EndPoint = point;
                        }
                        else
                        {
                            arrow.EndPoint.Location = Point.Empty;
                        }
                    }
                }
            }

            for (int i = 0; i < _mainData.ArrowsList.Count; i++)
            {
                if (_mainData.ArrowsList[i].StartPoint.Location == Point.Empty || _mainData.ArrowsList[i].EndPoint.Location == Point.Empty)
                {
                    _mainData.ArrowsList.Remove(_mainData.ArrowsList[i]);
                    --i;
                }
            }
        }

        private void RebindingArrows()
        {
            foreach (Arrow arrow in _mainData.ArrowsList)
            {
                foreach (AbstractForm form in _mainData.FormsList)
                {
                    foreach (ContactPoint point in form.ContactPoints)
                    {
                        if (arrow.StartPoint.Equals(point))
                        {
                            arrow.StartPoint = point;
                        }
                        //else
                        //{
                        //    arrow.StartPoint.Location = Point.Empty;
                        //}
                        else if (arrow.EndPoint.Equals(point))
                        {
                            arrow.EndPoint = point;
                        }
                        //else
                        //{
                        //    arrow.EndPoint.Location = Point.Empty;
                        //}
                    }
                }
            }

            //for (int i = 0; i < _mainData.ArrowsList.Count; i++)
            //{
            //    if (_mainData.ArrowsList[i].StartPoint.Location == Point.Empty|| _mainData.ArrowsList[i].EndPoint.Location == Point.Empty)
            //    {
            //        _mainData.ArrowsList.Remove(_mainData.ArrowsList[i]);
            //        --i;
            //    }
            //}
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _mainData = MainData.GetMainData();
            _mainData.PictureBoxMain = pictureBoxMain;
            _mainData.FormsList = new List<AbstractForm>();
            _mainData.ArrowsList = new List<Arrow>();
            _mainData._formFactory = Default.Factory.Form;
            _mainData.IMouseHandler = new MoveAndSelectMouseHandler();
            _mainData.SaveChanges();
        }

        #region Tool Strip

        #region CreateArrows
        private void toolStripButtonArrowAssociation_Click(object sender, EventArgs e)
        {
            statusStripStatusLabel.Text = "Click to start point and drag mouse to end point, to crate arrow association";
            _mainData._arrowsFactory = new ArrowAssociationFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();             
        }
        private void toolStripButtonArrowSuccession_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowSuccessionFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void toolStripButtonArrowRealization_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowRealizationFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void toolStripButtonArrowAggregation_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowAggregationFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void toolStripButtonArrowComposition_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowCompositionFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        #endregion

        #region CreateForm
        private void toolStripButtonCreateClassForm_Click(object sender, EventArgs e)
        {
            _mainData._formFactory = new ClassFormFactory();
            _mainData.IMouseHandler = new DrawFromMouseHandler();
        }

        private void toolStripButtonInterfaceForm_Click(object sender, EventArgs e)
        {
            _mainData._formFactory = new InterfaceFormFactory();
            _mainData.IMouseHandler = new DrawFromMouseHandler();
        }

        #endregion

        private void toolStripButtonEditObject_Click(object sender, EventArgs e)
        {
            FormEditor formEditor = new FormEditor();
            formEditor.Show();
            _mainData.IMouseHandler = new SelectFormMouseHandler();
        }

        private void toolStripButtonSelectForm_Click(object sender, EventArgs e)
        {
            _mainData.IMouseHandler = new SelectFormMouseHandler();
        }

        private void toolStripButtonNewFile_Click(object sender, EventArgs e)
        {
            if (_mainData.FormsList.Count != 0)
            {
                const string infoText = "Создание нового файла удалит несохраненные изменения. Сохранить изменения?";
                const string warningText = "Внимание!";
                DialogResult dialogResult = MessageBox.Show(infoText, warningText, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    toolStripButtonSaveFile_Click(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    _mainData.FormsList = new List<AbstractForm>();
                    _mainData.ArrowsList = new List<Arrow>();
                    _mainData.PictureBoxMain.Invalidate();
                }
            }
        }

        #region Save&Load
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
                string[] fileData = SaveAndLoad.OpenFile(openFileDialog1.FileName);
                JsonDeserialize(fileData);
                RebindingArrows();
                _mainData.PictureBoxMain.Invalidate();
            }
        }

        private void toolStripButtonSaveImageFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBoxMain.Width, pictureBoxMain.Height));
                bmp.Save(saveFileDialog2.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
        #endregion

        #region CopyPaste
        private void toolStripButtonCopy_Click(object sender, EventArgs e)
        {
            copyToStackButton_Click(sender, e);
        }

        private void toolStripButtonPaste_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += PasteObject_MouseDown;
        }

        private void toolStripButtonCut_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += EditObject_MouseDown;
        }

        #endregion

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            MainData.UnDo();
            _mainData = MainData.GetMainData();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            MainData.ReDo();
            _mainData = MainData.GetMainData();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (_mainData.SelectArrow != null)
            {
                _mainData.ArrowsList.Remove(_mainData.SelectArrow);
                _mainData.SelectArrow = null;
            }
            else if (_mainData.SelectForm != null)
            {
                _mainData.FormsList.Remove(_mainData.SelectForm);
                _mainData.SelectForm = null;
                RemoveArrowСonnections();
            }

            _mainData.PictureBoxMain.Invalidate();
        }

        #endregion

        private void copyToStackButton_Click(object sender, EventArgs e)
        {
            _mainData.FormInBuffer = null;

            foreach (AbstractForm form in _mainData.FormsList)
            {
                if (form.IsSelected)
                {
                    _mainData.FormInBuffer = new UML_Diagram_drawer.Forms.Form(form);
                }
            }
        }

        private void PasteObject_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_mainData.FormInBuffer != null)
                {
                    _mainData.FormInBuffer.Location = e.Location;
                    _mainData.FormsList.Add(_mainData.FormInBuffer);
                    _mainData.FormInBuffer = null;
                }
            }

            pictureBoxMain.MouseDown -= PasteObject_MouseDown;
            pictureBoxMain.Invalidate();
        }

        private void EditObject_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (_mainData.CurrentFormUML != null)
                {
                    _mainData.FormInBuffer = new UML_Diagram_drawer.Forms.Form(_mainData.CurrentFormUML);
                    _mainData.FormsList.Remove(_mainData.CurrentFormUML);
                }
            }

            pictureBoxMain.Invalidate();
        }

        #region PictureBoxEvent
        private void pictureBoxMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (_mainData.IMouseHandler != null)
            {
                _mainData.IMouseHandler.MouseClick(sender, e);
            }
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (_mainData.IMouseHandler != null)
            {
                _mainData.IMouseHandler.MouseDown(sender, e);
            }
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (_mainData.IMouseHandler != null)
            {
                _mainData.IMouseHandler.MouseUp(sender, e);
            }
            statusStripStatusLabel.Text = "Ready";
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mainData.IMouseHandler != null)
            {
                _mainData.IMouseHandler.MouseMove(sender, e);
            }
        }

        private void PictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            MainGraphics.Graphics = e.Graphics;

            foreach (AbstractForm form in _mainData.FormsList)
            {
                form.Draw();
            }

            foreach (var arrow in _mainData.ArrowsList)
            {
                arrow.Draw();
            }
        }

        #endregion

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                pictureBoxMain.Height += e.NewValue - e.OldValue;
            }
            else
            {
                pictureBoxMain.Width += e.NewValue - e.OldValue;
            }
        }

        private void pictureBoxHamburger_Click(object sender, EventArgs e)
        {
            if(toolStrip1.Visible==false)
            {
                toolStrip1.Visible = true;
                menuStrip1.Visible = true;
            }
            else if(toolStrip1.Visible==true)
            {
                toolStrip1.Visible = false;
                menuStrip1.Visible = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mainData.FormsList.Count != 0)
            {
                const string infoText = "Создание нового файла удалит несохраненные изменения. Сохранить изменения?";
                const string warningText = "Внимание!";
                DialogResult dialogResult = MessageBox.Show(infoText, warningText, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    toolStripButtonSaveFile_Click(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {
                    _mainData.FormsList = new List<AbstractForm>();
                    _mainData.ArrowsList = new List<Arrow>();
                    _mainData.PictureBoxMain.Invalidate();
                }
            }
        }

        private void saveFileInToJPEGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                pictureBoxMain.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBoxMain.Width, pictureBoxMain.Height));
                bmp.Save(saveFileDialog2.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void cutObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += EditObject_MouseDown;
        }

        private void interfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainData._formFactory = new InterfaceFormFactory();
            _mainData.IMouseHandler = new DrawFromMouseHandler();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainData._formFactory = new ClassFormFactory();
            _mainData.IMouseHandler = new DrawFromMouseHandler();
        }

        private void compositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowCompositionFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Переустановить виндовс?", "Во халепа", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] fileData = SaveAndLoad.OpenFile(openFileDialog1.FileName);
                JsonDeserialize(fileData);
                RebindingArrows();
                _mainData.PictureBoxMain.Invalidate();
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    pictureBoxMain.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBoxMain.Width, pictureBoxMain.Height));
                    bmp.Save(saveFileDialog2.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fileDataForms = JsonSerialize(TypeOfData.Forms);
                    string fileDataArrows = JsonSerialize(TypeOfData.Arrows);
                    SaveAndLoad.SaveFile(saveFileDialog1.FileName, fileDataForms, fileDataArrows);
                }
            }
            if (e.Control && e.KeyCode == Keys.J)
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
                    pictureBoxMain.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBoxMain.Width, pictureBoxMain.Height));
                    bmp.Save(saveFileDialog2.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            if (e.Control && e.KeyCode == Keys.E)
            {

                
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                copyToStackButton_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                pictureBoxMain.MouseDown += PasteObject_MouseDown;
            }
            if (e.Control && e.KeyCode == Keys.D)
            {
                if (_mainData.SelectArrow != null)
                {
                    _mainData.ArrowsList.Remove(_mainData.SelectArrow);
                    _mainData.SelectArrow = null;
                }
                else if (_mainData.SelectForm != null)
                {
                    _mainData.FormsList.Remove(_mainData.SelectForm);
                    _mainData.SelectForm = null;
                    RemoveArrowСonnections();
                }

                _mainData.PictureBoxMain.Invalidate();
            }
            
            if (e.Control && e.KeyCode == Keys.L)
            {
                _mainData._formFactory = new ClassFormFactory();
                _mainData.IMouseHandler = new DrawFromMouseHandler();
            }
            if (e.Control && e.KeyCode == Keys.I)
            {
                _mainData._formFactory = new InterfaceFormFactory();
                _mainData.IMouseHandler = new DrawFromMouseHandler();
            }
            if (e.Control && e.KeyCode == Keys.N)
            {
                if (_mainData.FormsList.Count != 0)
                {
                    const string infoText = "Создание нового файла удалит несохраненные изменения. Сохранить изменения?";
                    const string warningText = "Внимание!";
                    DialogResult dialogResult = MessageBox.Show(infoText, warningText, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        toolStripButtonSaveFile_Click(sender, e);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        _mainData.FormsList = new List<AbstractForm>();
                        _mainData.ArrowsList = new List<Arrow>();
                        _mainData.PictureBoxMain.Invalidate();
                    }
                }
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                statusStripStatusLabel.Text = "Click to start point and drag mouse to end point, to crate arrow association";
                _mainData._arrowsFactory = new ArrowAssociationFactory();
                _mainData.IMouseHandler = new DrawArrowMouseHandler();
            }
            if (e.Control && e.KeyCode == Keys.M)
            {
                _mainData._arrowsFactory = new ArrowCompositionFactory();
                _mainData.IMouseHandler = new DrawArrowMouseHandler();
            }
            if (e.Control && e.KeyCode == Keys.R)
            {
                _mainData._arrowsFactory = new ArrowRealizationFactory();
                _mainData.IMouseHandler = new DrawArrowMouseHandler();
            }
            
            if (e.Control && e.KeyCode == Keys.S)
            {
                _mainData._arrowsFactory = new ArrowSuccessionFactory();
                _mainData.IMouseHandler = new DrawArrowMouseHandler();
            }
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.Close();
            }



        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileDataForms = JsonSerialize(TypeOfData.Forms);
                string fileDataArrows = JsonSerialize(TypeOfData.Arrows);
                SaveAndLoad.SaveFile(saveFileDialog1.FileName, fileDataForms, fileDataArrows);
            }
        }

        private void closeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToStackButton_Click(sender, e);
        }

        private void pasteObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += PasteObject_MouseDown;
        }

        private void editObjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor formEditor = new FormEditor();
            formEditor.Show();
            _mainData.IMouseHandler = new SelectFormMouseHandler();
        }

        private void aggregationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowAggregationFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void realizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowRealizationFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void successionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mainData._arrowsFactory = new ArrowSuccessionFactory();
            _mainData.IMouseHandler = new DrawArrowMouseHandler();
        }

        private void shotkeyListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shot key in UML bilder\n" +
                "Ctrl+C - Copy object\n" +
                "Ctrl+P - Paste object\n" +
                "Ctrl+O - Open UML-diagram\n" +
                "Ctrl+S - Save UML-diagram\n" +
                "Ctrl+J - Save UML-diagram in JPEG\n" +
                "Ctrl+N - Create new UML-diagram\n" +
                "Ctrl+X - Close UML-diagram\n" +
                "Ctrl+l - Add class\n" +
                "Ctrl+A - Add aggregation arrow\n" +
                "Ctrl+I - Add interfase arrow\n" +
                "Ctrl+M - Add composition arrow\n" +
                "Ctrl+R - Add Realization arrow\n" +
                "Ctrl+S - Add succession arrow\n"
                );

        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How to create UML-diagram?\n" +
                "If you want create UML-diagram, you should set up on the desk all classes and interfases\n" +
                "and create dependances for all classes and interfases\n" +
                "How to save UML-diagram?\n" +
                "If you want create UML-diagram, you should mouse down on button Save to Jpeg or Save to\n" +
                "or Keydown short key Ctrl+S OR Ctrl+J\n");

        }
    }
}