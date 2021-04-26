using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer.MouseHandlers
{
    class PasteFormMouseHandler : IMouseHandler
    {
        private MainData _mainData = MainData.GetMainData();

        public void MouseClick(object sender, MouseEventArgs e)
        {
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if(_mainData.FormInBuffer != null)
            {
                _mainData.FormInBuffer.Location = e.Location;
                _mainData.FormsList.Add(_mainData.FormInBuffer);
                _mainData.FormInBuffer = null;
            }
            
            _mainData.IMouseHandler = new MoveAndSelectMouseHandler();
            _mainData.PictureBoxMain.Invalidate();
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
        }
    }
}
