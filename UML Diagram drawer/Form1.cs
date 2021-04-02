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
        private Point _pointStart;
        private Point _pointEnd;
        private Panel _panel = new Panel();
        private GroupBox _groupBox = new GroupBox();
        private TextBox _textBox = new TextBox();


        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Point point = new Point(1, 2);

            _bitmap = new Bitmap(pictureBoxMain.Width, pictureBoxMain.Height);
            _pen = new Pen(Color.Green, 2);
            _graphics = Graphics.FromImage(_bitmap);

            //_pen.StartCap = LineCap.RoundAnchor;
            //_pen.EndCap = LineCap.ArrowAnchor;

            //_graphics.DrawLine(_pen, 0, 0, 200, 300);
            pictureBoxMain.Image = _bitmap;

            //this.Controls.Add(new TextBox() { Name = "test", Location = new Point(2, 3), Text = "I lave Lysya!" });
            //this.Controls.Add(new Panel() { Name = "TestName" });
            _groupBox.Name = "TestName";
            _groupBox.Location = new Point(2, 3);
            _groupBox.Size = new Size(100, 500);
            this.Controls.Add(_groupBox);
            this.KeyPreview = true;

            _textBox.Name = "textBoxMain";
            _textBox.Text = "<Interfase>";
            _textBox.Multiline = true;
            _textBox.Size = new Size(50, 100);

            _textBox.KeyPress += new KeyPressEventHandler(MyTestPressEnter);
            _textBox.MouseClick += new MouseEventHandler(MyTestMouseClick);
            
            _groupBox.Controls.Add(_textBox);

        }
        private void MyTestMouseClick(object sender, MouseEventArgs e)
        {
            _textBox.Size = new Size(200, 50);
        }
        private void MyTestPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _textBox.Size = new Size(50, 300);
            }
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

                DrawStraightBrokenLine(_pointStart, _pointEnd);
                _pointStart = Point.Empty;
            }
        }

        private void DrawStraightBrokenLine(Point startP, Point endP)
        {
            Point tempPointStart = Point.Empty;
            Point tempPointEnd = Point.Empty;

            tempPointStart.X = (endP.X + startP.X) / 2;
            tempPointStart.Y = startP.Y;

            //_pen.StartCap = LineCap.RoundAnchor;
            _graphics.DrawLine(_pen, startP, tempPointStart);
            //_pen.StartCap = LineCap.Custom;

            tempPointEnd.X = (endP.X + startP.X) / 2;
            tempPointEnd.Y = endP.Y;

            _graphics.DrawLine(_pen, tempPointStart, tempPointEnd);

            DrawEndPointerRhombus(tempPointEnd, endP);
            //_pen.EndCap = LineCap.ArrowAnchor;
            //_graphics.DrawLine(_pen, tempPointEnd, endP);
            //_pen.EndCap = LineCap.Custom;
        }

        private void DrawEndPointerArrow(Point startP, Point endP)
        {
            int offsetX = 10;
            int offsetY = offsetX / 2;

            _graphics.DrawLine(_pen, startP.X, startP.Y, endP.X - offsetX, endP.Y);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y, endP.X - offsetX, endP.Y - offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y - offsetY, endP.X, endP.Y);
            _graphics.DrawLine(_pen, endP.X, endP.Y, endP.X - offsetX, endP.Y + offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y + offsetY, endP.X - offsetX, endP.Y);
        }

        private void DrawEndPointerRhombus(Point startP, Point endP)
        {
            int offsetX = 10;
            int offsetY = offsetX - 2;

            _graphics.DrawLine(_pen, startP.X, startP.Y, endP.X - offsetX * 2, endP.Y);
            _graphics.DrawLine(_pen, endP.X - offsetX * 2, endP.Y, endP.X - offsetX, endP.Y - offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y - offsetY, endP.X, endP.Y);
            _graphics.DrawLine(_pen, endP.X, endP.Y, endP.X - offsetX, endP.Y + offsetY);
            _graphics.DrawLine(_pen, endP.X - offsetX, endP.Y + offsetY, endP.X - offsetX * 2, endP.Y);
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Invalidate();
        }
    }
}
