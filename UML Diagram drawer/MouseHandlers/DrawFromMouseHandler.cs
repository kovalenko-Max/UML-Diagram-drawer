using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.MouseHandlers;

namespace UML_Diagram_drawer.MouseHandlers
{
    class DrawFromMouseHandler : IMouseHandler
    {
        private MainData _mainData = MainData.GetMainData();
        public void MouseClick(object sender, MouseEventArgs e)
        {
            _mainData.CurrentFormUML.Location = e.Location;
            _mainData.PictureBoxMain.Invalidate();
            _mainData.CurrentFormUML = null;
            _mainData.IMouseHandler = new MoveAndSelectMouseHandler();
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
           
        }
    }
}
