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

namespace UML_Diagram_drawer
{
    public partial class FormMain : Form
    {
        public CanvasPanel Canvas = new CanvasPanel();
        public string text;
        public FormMain()
        {
            InitializeComponent();
            Canvas = new CanvasPanel();
            panelMain.Controls.Add(Canvas);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Canvas.IsDraw = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Canvas.Forms[Canvas.Forms.Count - 1]._modules[1].AddTextField();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Canvas.Forms[Canvas.Forms.Count - 1].AddTextField(textBox1.Text, type.MethodModule)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Canvas.Forms[Canvas.Forms.Count - 1].RemoveTextField();
            //if (Canvas.IsRemove)
            //{
            //    Canvas.IsRemove = false;
            //}
            //else
            //{
            //    Canvas.IsRemove = true;
            //}

            if (Canvas.IsRedactor)
            {
                Canvas.IsRedactor = false;
            }
            else
            {
                Canvas.IsRedactor = true;
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode > Keys.A && e.KeyCode < Keys.Z)
            {
                text += e.KeyData;
                textBox1.Text = text;
                Canvas.RedactorTextField(text);
            }
        }
    }
}
