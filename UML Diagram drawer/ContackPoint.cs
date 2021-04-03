using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Controls;

namespace UML_Diagram_drawer
{
    public class ContackPoint : Control
    {
        private Point _location;
        
        public Control controlObj;
        public Control mainObj;

        private Panel _pointer;

        public ContackPoint(Control obj,Control mainObj)
        {
            controlObj = obj;
            this.mainObj = mainObj;
            SetLocation();

            _pointer = new Panel();
            _pointer.Size = new Size(20, 20);
            _pointer.MouseEnter +=new EventHandler(MouseEnterObj);
            _pointer.MouseLeave += new EventHandler(MouseLeaveObj);
            _pointer.MouseClick += new MouseEventHandler(MouseClick);
            _pointer.Location = _location;
            this.mainObj.Controls.Add(_pointer);
            _pointer.BringToFront();

        }
        public void MouseClick(object sender, MouseEventArgs e)
        {
            FormMain._pointStart = _location;
        }
        private void MouseEnterObj(object sender, EventArgs e)
        {
            _pointer.BackColor = Color.Black;
        }
        private void MouseLeaveObj(object sender, EventArgs e)
        {
            _pointer.BackColor = Color.Transparent;
        }

        public void SetLocation()
        {
            _location.Y = controlObj.Location.Y + controlObj.Height / 2;
            _location.X = controlObj.Location.X + controlObj.Width;
        }
        public void RestartLocation()
        {
            SetLocation();
            _pointer.Location = _location;
        }
    }
}
