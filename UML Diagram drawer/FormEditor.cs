using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer
{
    public partial class FormEditor : System.Windows.Forms.Form
    {
        private PictureBox _canvas;
        private AbstractForm _form;

        public FormEditor()
        {
            InitializeComponent();
        }

        public FormEditor(AbstractForm form, PictureBox pb)
        {
            if (form != null && pb != null)
            {
                _form = form;
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
            if (_form != null)
            {
                colorCoiseDialog.ShowDialog();
                _form.SetColor(colorCoiseDialog.Color);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void trackBarSizeForm_Scroll(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.Resize(trackBarSizeForm.Value);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void buttonSelectFont_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                fontDialog1.ShowDialog();
                _form.SetFont(fontDialog1.Font);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.AddTextField(Forms.Modules.ModuleType.Field);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void buttonAddMethod_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.AddTextField(Forms.Modules.ModuleType.Method);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void buttonColorTextChoice_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                colorCoiseDialog.ShowDialog();
                _form.SetColorText(colorCoiseDialog.Color);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void trackBarLineThickness_Scroll(object sender, EventArgs e)
        {
            if (_form != null)
            {
                _form.SetWidthLine( trackBarLineThickness.Value);
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        private void buttonSetBackColor_Click(object sender, EventArgs e)
        {
            if (_form != null)
            {
                colorCoiseDialog.ShowDialog();
                _form.Color = colorCoiseDialog.Color;
                _canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }
    }
}
