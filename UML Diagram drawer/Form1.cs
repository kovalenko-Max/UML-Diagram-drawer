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

        private Bitmap _bitmap;
        private Graphics _graphics;
        private Pen _pen;

        public static Point _pointStart;
        private Point _pointEnd;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _pen = new Pen(Color.Green, 2);
            _graphics = Graphics.FromImage(_bitmap);

            pictureBoxMain.Image = _bitmap;
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (_pointStart.IsEmpty)
            {
                _pointStart = e.Location;
            }
            else
            {
                _pointEnd = e.Location;
                Pointer pointer = new Pointer(pictureBoxMain, _bitmap, _graphics, _pen);
                pointer.DrawSuccession(_pointStart, _pointEnd, false);
                _pointStart = Point.Empty;
            }
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Invalidate();
        }
    }
}
