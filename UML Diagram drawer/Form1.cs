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
        private Bitmap _bitmapMain;
        private Graphics _graphics;

        private Point _pointStart;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _bitmapMain = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _graphics = Graphics.FromImage(_bitmapMain);

            pictureBoxMain.Image = _bitmapMain;
        }


        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Invalidate();
        }

        private void DrawSuccessionArrow_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = e.Location;

            if (_pointStart.IsEmpty)
            {
                _pointStart = point;
            }
            else
            {
                ArrowSuccession successionArrow = new ArrowSuccession(_graphics, Color.Red);
                successionArrow.From = _pointStart;
                successionArrow.To = point;
                successionArrow.Draw();
                _pointStart = Point.Empty;

                pictureBoxMain.MouseDown -= DrawSuccessionArrow_MouseDown;
            }
        }

        private void DrawRealizationArrow_MouseDown(object sender, MouseEventArgs e)
        {
            Point point = e.Location;

            if (_pointStart.IsEmpty)
            {
                _pointStart = point;
            }
            else
            {
                ArrowRealization arrowRealization = new ArrowRealization(_graphics, Color.Red);
                arrowRealization.From = _pointStart;
                arrowRealization.To = point;
                arrowRealization.Draw();
                _pointStart = Point.Empty;

                pictureBoxMain.MouseDown -= DrawRealizationArrow_MouseDown;
            }
        }

        private void buttonRealization_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += DrawRealizationArrow_MouseDown;
        }

        private void button_Succession_Click(object sender, EventArgs e)
        {
            pictureBoxMain.MouseDown += DrawSuccessionArrow_MouseDown;
        }
    }
}
