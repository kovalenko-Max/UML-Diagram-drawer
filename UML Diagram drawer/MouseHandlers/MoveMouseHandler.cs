using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.MouseHandlers
{
    class MoveMouseHandler : IMouseHandler
    {
        private MainData _mainData = MainData.GetMainData();
        private Point previousLocation;

        public void MouseClick(object sender, MouseEventArgs e)
        {
            if (_mainData.SelectForm != null && !_mainData.SelectForm.Contains(e.Location))
            {
                foreach (AbstractForm form in _mainData.FormsList)
                {
                    form.RemoveSelect();
                }
                _mainData.SelectForm = null;

                _mainData.PictureBoxMain.Invalidate();
            }
            
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            foreach (AbstractForm form in _mainData.FormsList)
            {
                if (form.Contains(e.Location))
                {
                    _mainData.CurrentFormUML = form;
                    _mainData.SelectForm = form;
                    _mainData.SelectForm.Select(e.Location);
                    previousLocation = e.Location;

                    _mainData.PictureBoxMain.Invalidate();
                }
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (_mainData.CurrentFormUML != null)
            {
                _mainData.CurrentFormUML.Move(e.Location.X - previousLocation.X, e.Location.Y - previousLocation.Y);
                previousLocation = e.Location;
                _mainData.PictureBoxMain.Invalidate();
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            if (_mainData.CurrentFormUML != null)
            {
                _mainData.CurrentFormUML = null;
            }
        }
    }
}
