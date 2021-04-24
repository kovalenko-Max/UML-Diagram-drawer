using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.Handlers;

namespace UML_Diagram_drawer
{
    public partial class FormEditor : System.Windows.Forms.Form
    {
        private MainData _mainData;
        private IEditHandler _handler;

        public FormEditor()
        {
            _mainData = MainData.GetMainData();
            if (_mainData.SelectForm != null && _mainData.PictureBoxMain != null)
            {
                InitializeComponent();
                panelEditForm.Visible = true;
                _handler = new FormEditorHandler(colorCoiseDialog, fontDialog1);
            }
            else if (_mainData.SelectArrow != null && _mainData.PictureBoxMain != null)
            {
                InitializeComponent();
                panelEditForm.Visible = false;
                _handler = new ArrowEditorHandler(colorCoiseDialog, fontDialog1);
            }
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            if (_mainData.SelectForm != null)
            {
                trackBarLineThickness.Value = (int)_mainData.SelectForm.WidthLine;
                trackBarSizeForm.Value = (int)_mainData.SelectForm.Font.Size;
            }
        }

        private void buttonColorChoice_Click(object sender, EventArgs e)
        {
            _handler.SetColor_Click();
        }

        private void trackBarSizeForm_Scroll(object sender, EventArgs e)
        {
            _handler.SetSize_Scroll(trackBarSizeForm);
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            _handler.SetFont_Click();
        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            _handler.AddField_Click();
        }

        private void buttonAddMethod_Click(object sender, EventArgs e)
        {
            _handler.AddMethod_Click();
        }

        private void buttonColorTextChoice_Click(object sender, EventArgs e)
        {
            _handler.SetColorText_Click();
        }

        private void trackBarLineThickness_Scroll(object sender, EventArgs e)
        {
            _handler.SetWidthLine(trackBarLineThickness);
        }

        private void buttonSetBackColor_Click(object sender, EventArgs e)
        {
            _handler.SetBackColor_Click();
        }
    }
}
