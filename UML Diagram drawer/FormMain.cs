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
        private PanelWithMouseDraw _drawingPanel;



        public FormMain()
        {
            InitializeComponent();
            _drawingPanel = new PanelWithMouseDraw();
            panelMain.Controls.Add(_drawingPanel);
        }
        
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDrawArrow_Click(object sender, EventArgs e)
        {
            _drawingPanel.IsDrawArrow = true;
           
        }

        private void buttonDeleteOBJ_Click(object sender, EventArgs e)
        {
            _drawingPanel.Delete();
        }

        
    }
}
