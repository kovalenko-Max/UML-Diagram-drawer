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
        //public CanvasPanel Canvas = new CanvasPanel();

        public FormMain()
        {
            InitializeComponent();
            //Canvas = new CanvasPanel();
            //panelMain.Controls.Add(Canvas);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_CreateForm_Click(object sender, EventArgs e)
        {
            //Canvas.IsFormDraw = true;   
        }

        private void button_CreateArrow_Click(object sender, EventArgs e)
        {
            
        }
    }
}
