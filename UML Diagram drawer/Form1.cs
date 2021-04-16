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
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if(colorDialog1.Color==Color.Black)
            {
                toolStripButton12.ForeColor = Color.White;
            }
            else
            {
                toolStripButton12.ForeColor = Color.Black;
            }

            toolStripButton12.BackColor = colorDialog1.Color;
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

        private void toolStripButtonArrowAssociation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowSuccession_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowRealization_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowAggregation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowAggregationAndAssociation_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowComposition_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonArrowCompositionAndAssociation_Click(object sender, EventArgs e)
        {

        }
    }
}
