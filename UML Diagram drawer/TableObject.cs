using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    class TableObject:Control
    {
        private GroupBox _groupBox = new GroupBox();
        private Button _buttonMovement = new Button();

        private TextBox _textBoxClassName = new TextBox();
        private TextBox _textBoxFieldName = new TextBox();
        private TextBox _textBoxMethodName = new TextBox();

        private Size sizeGroupBox = new Size(200, 250);
        private Color _colorGroupBox = Color.FromArgb(255, 193, 111, 147);
        private Point _pointGroupBox = new Point(10, 10);


        private ContackPoint cp;

        bool isBool = true;

        public TableObject(Control formMain)
        {
            _groupBox.Size = sizeGroupBox;
            _groupBox.BackColor = _colorGroupBox;
            _groupBox.Location = _pointGroupBox;
            formMain.Controls.Add(_groupBox);
            _groupBox.BringToFront();
        }

        public void CreateTextBox()
        {
            this.MouseMove += TableObject_MouseMove;
        }

        private void TableObject_MouseMove(object sender, MouseEventArgs e)
        {
            _groupBox.Location = this.PointToClient(Control.MousePosition);
        }

        public void QQQ()
        {
            //_groupBox.Name = "TestName";
            //_groupBox.Location = new Point(10, 10);
            //_groupBox.Size = new Size(200, 200);
            //_groupBox.BackColor = Color.Red;
            //this.Controls.Add(_groupBox);
            //_groupBox.BringToFront();
            //this.KeyPreview = true;

            //textBox = new TextBox();
            //textBox.Multiline = true;
            //textBox.Size = new Size(_groupBox.Width, 50);
            //textBox.Text = "Class";
            //_groupBox.Controls.Add(textBox);
            //textBox.KeyPress += new KeyPressEventHandler(MyTestPressEnter);
            //textBox.BringToFront();



            //cp = new ContackPoint(_groupBox, this);
            //Button btn = new Button();
            //btn.Size = new Size(50, 50);
            //btn.MouseDown += Btn_MouseDown;
            //btn.MouseUp += Btn_MouseUp;
            //btn.MouseMove += Btn_MouseMove;
            //_groupBox.Controls.Add(btn);
            //btn.BringToFront();
            //_groupBox.Move += _groupBox_Move;
        }

        //private void _groupBox_Move(object sender, EventArgs e)
        //{
        //    cp.RestartLocation();
        //}

        //private void Btn_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (!isBool)
        //    {
        //        _groupBox.Location = this.PointToClient(Control.MousePosition);
        //    }
        //}

        //private void Btn_MouseUp(object sender, MouseEventArgs e)
        //{
        //    isBool = true;
        //}

        //private void Btn_MouseDown(object sender, MouseEventArgs e)
        //{
        //    isBool = false;
        //}

        //private void MyTestMouseDown(object sender, MouseEventArgs e)
        //{
        //    if (!isBool)
        //    {
        //        //groupBox1.Location = this.PointToClient(Control.MousePosition);
        //    }
        //}
    }
}
