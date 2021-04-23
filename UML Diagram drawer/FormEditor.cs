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
        private PictureBox _canvas;
        private AbstractForm _form;
        private AbstactArrow _arrow;
        private IEditHandler _handler;

        public FormEditor()
        {
            _handler = new FormEditorHandler(_form,_canvas,colorCoiseDialog,fontDialog1);
            InitializeComponent();
        }

        public FormEditor(AbstractForm form, PictureBox pb)
        {
            if (form != null && pb != null)
            {
                _form = form;
                _canvas = pb;
                InitializeComponent();
                _handler = new FormEditorHandler(_form, _canvas, colorCoiseDialog, fontDialog1);
            }
            else
            {
                throw new ArgumentNullException("Values is null");
            }
        }

        public FormEditor(AbstactArrow arrow, PictureBox pb)
        {
            if (arrow != null && pb != null)
            {
                _arrow = arrow;
                _canvas = pb;
                InitializeComponent();
            }
            else
            {
                throw new ArgumentNullException("Values is null");
            }
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            trackBarLineThickness.Value = (int)_form.WidthLine;
            trackBarLineThickness.Value = (int)_form.WidthLine;
            trackBarSizeForm.Value = (int)_form.Font.Size;
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
