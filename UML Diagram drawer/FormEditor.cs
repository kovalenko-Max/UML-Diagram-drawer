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
        private AbstractForm _form;
        private int x = (Default.Size.FormSize.Width * 100) / 30;
        private int y = (Default.Size.FormSize.Height * 100) / 30;
        public FormEditor()
        {
            InitializeComponent();
        }

        public FormEditor(AbstractForm form)
        {
            _form = form;
            InitializeComponent();
        }
        private void FormEditor_Load(object sender, EventArgs e)
        {
            trackBarLineThickness.Value = (int)_form.WidthLine;

            int x = (Default.Size.FormSize.Width * 100) / 30;
            int y = (Default.Size.FormSize.Height * 100) / 30;
            int x1 = (_form.Size.Width * 100) / x;
            int y1 = (_form.Size.Height * 100) / y;
            trackBarSizeForm.Value = (x1 + y1) / 2;
        }

        private void buttonColorChoice_Click(object sender, EventArgs e)
        {
            colorCoiseDialog.ShowDialog();
            _form.Color = colorCoiseDialog.Color;
        }

        private void trackBarSizeForm_Scroll(object sender, EventArgs e)
        {
            //int x1 = (x * trackBarSizeForm.Value) / 100;
            //int y1 = (y * trackBarSizeForm.Value) / 100;
            //_form.SIze = new Size(x1,y1);
            _form.Resize(trackBarSizeForm.Value);
        }
    }
}
