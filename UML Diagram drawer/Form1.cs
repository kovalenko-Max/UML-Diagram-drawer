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
        public CanvasPanel Panels = new CanvasPanel();
        public FormMain()
        {
            InitializeComponent();
            Panels = new CanvasPanel();
            panelMain.Controls.Add(Panels);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

    }
}
