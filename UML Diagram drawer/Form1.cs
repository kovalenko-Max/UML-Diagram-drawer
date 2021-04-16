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
        public FormMain()
        {
            InitializeComponent();
            //panelMain.Controls.Add(new PanelWithMouseDraw());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //new ArrowAssociation(System.Drawing.Pen, colorDialog1.Color);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            pictureBox1.Visible = false;
        }

        private void toolStrip1_MouseLeave(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
