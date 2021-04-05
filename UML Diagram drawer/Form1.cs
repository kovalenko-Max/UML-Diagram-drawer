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
        private Bitmap _bitmapTemp;
        private Graphics _graphics;

        private Point _pointStart = Point.Empty;

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

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            DrawArrow(e.Location);
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Invalidate();
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_pointStart.IsEmpty)
            {
                _bitmapTemp = (Bitmap)_bitmapMain.Clone();
                _graphics = Graphics.FromImage(_bitmapTemp);
                DrawArrow(e.Location);
                pictureBoxMain.Image = _bitmapTemp;
                GC.Collect();
            }
        }

        private void DrawArrow(Point point)
        {
            if (_pointStart.IsEmpty)
            {
                _pointStart = point;
            }
            else
            {
                new ArrowSuccession(_graphics, Color.Red).Draw(_pointStart, point);
            }
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            DrawArrow(e.Location);
            _bitmapMain = _bitmapTemp;
            _pointStart = Point.Empty;
        }
    }
}
