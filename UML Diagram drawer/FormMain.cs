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

        private CanvasPanel _drawingPanel;


        public enum ObjectType
        {
            ArrowAggregation,
            ArrowAssociation,
            ArrowComposition,
            ArrowRealization,
            ArrowSuccession
        }

        public FormMain()
        {
            InitializeComponent();
            _drawingPanel = new CanvasPanel();
            panelMain.Controls.Add(_drawingPanel);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDrawArrow_Click(object sender, EventArgs e)
        {
            _drawingPanel.CreateObject(ObjectType.ArrowComposition);


        }

        private void buttonDeleteOBJ_Click(object sender, EventArgs e)
        {
            //_drawingPanel.Delete();

        }

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
    }
}
