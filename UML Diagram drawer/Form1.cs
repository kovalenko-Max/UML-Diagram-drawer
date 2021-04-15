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

        public FormMain()
        {
            InitializeComponent();
            Canvas = new CanvasPanel();
            panelMain.Controls.Add(Canvas);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Canvas.IsDraw = true;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Canvas.Forms[Canvas.Forms.Count-1].Modules[1].AddTextField();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Canvas.Forms[Canvas.Forms.Count - 1].Modules[2].AddTextField();
        }
    }
}
