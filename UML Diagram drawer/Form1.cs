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
        private Graphics _graphics;
        //private ArrowSuccession tempArrow;

        //private List<AbstactArrow> _arrows = new List<AbstactArrow>();

        public FormMain()
        {
            InitializeComponent();
            panelMain.Controls.Add(new PanelWithMouseDraw());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _graphics = panelMain.CreateGraphics();
        }

        //private void CreateArrow()
        //{
        //    tempArrow = new ArrowSuccession(_graphics, Color.Red);
        //}

        private void DrawArrow(Point point)
        {
            //if(tempArrow is null)
            //{
            //    CreateArrow();
            //}

            //if (tempArrow.From.IsEmpty)
            //{
            //    tempArrow.From = point;
            //}
            //else
            //{
            //    tempArrow.Draw(tempArrow.From, point);
            //}
        }

        //private void ReDraw()
        //{
        //    _graphics.Clear(Color.White);
        //    foreach (var item in _arrows)
        //    {
        //        item.Draw(item.From, item.To);
        //    }
        //}

        private void panelMain_MouseUp(object sender, MouseEventArgs e)
        {
            //DrawArrow(e.Location);
            //_arrows.Add(tempArrow);
            //tempArrow = null;
        }

        private void panelMain_MouseMove(object sender, MouseEventArgs e)
        {
            //if (!(tempArrow is null) && !tempArrow.From.IsEmpty)
            //{
            //    DrawArrow(e.Location);
            //    ReDraw();
            //}
        }

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            //DrawArrow(e.Location);
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            //ReDraw();
        }
    }
}
