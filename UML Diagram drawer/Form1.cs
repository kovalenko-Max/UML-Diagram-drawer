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

            pictureBoxMain.Image = _bitmap;
            PointerDrawer.Initialize(pictureBoxMain, _bitmap, _graphics, _pen);


            //this.Controls.Add(new TextBox() { Name = "test", Location = new Point(2, 3), Text = "I lave Lysya!" });
            //this.Controls.Add(new Panel() { Name = "TestName" });
            _groupBox.Name = "TestName";
            _groupBox.Location = new Point(10, 10);
            _groupBox.Size = new Size(300, 500);
            _groupBox.BackColor = Color.Red;
            this.Controls.Add(_groupBox);
            _groupBox.BringToFront();
            this.KeyPreview = true;

            _textBox.Name = "textBoxMain";
            _textBox.Text = "<Interfase>";
            _textBox.Multiline = true;
            _textBox.Size = new Size(50, 100);

            _textBox.KeyPress += new KeyPressEventHandler(MyTestPressEnter);
            _textBox.MouseClick += new MouseEventHandler(MyTestMouseClick);

            ContackPoint cp = new ContackPoint(_groupBox,this);
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

                PointerDrawer.DrawSuccession(_pointStart, _pointEnd);
                _pointStart = Point.Empty;
            }
            PointerDrawer.Eraser(e.Location);
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Invalidate();
        }

        
    }
}
