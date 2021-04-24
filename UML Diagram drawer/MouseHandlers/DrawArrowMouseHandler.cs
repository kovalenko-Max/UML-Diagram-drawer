using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.MouseHandlers;

namespace UML_Diagram_drawer.MouseHandlers
{
    class DrawArrowMouseHandler : IMouseHandler
    {
        private MainData _mainData = MainData.GetMainData();

        public void MouseClick(object sender, MouseEventArgs e)
        {
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            ContactPoint currentContactPoint = null;
            foreach (var form in _mainData.FormsList)
            {
                foreach (var contactPoint in form.ContactPoints)
                {
                    if (contactPoint.Contains(e.Location))
                    {
                        currentContactPoint = form.ConnectArrow(e.Location);
                    }
                }
            }

            if (currentContactPoint != null)
            {
                _mainData.CurrentArrow.StartPoint = currentContactPoint;
                currentContactPoint = null;
                _mainData.PictureBoxMain.Invalidate();
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (_mainData.CurrentArrow != null)
            {
                _mainData.CurrentArrow.EndPoint.Location = e.Location;
                _mainData.PictureBoxMain.Invalidate();
            }
        }

        public void MouseUp(object sender, MouseEventArgs e)
        {
            ContactPoint currentContactPoint = null;

            foreach (var form in _mainData.FormsList)
            {
                foreach (var contactPoint in form.ContactPoints)
                {
                    if (contactPoint.Contains(e.Location))
                    {
                        currentContactPoint = form.ConnectArrow(e.Location);
                    }
                }
            }

            if (_mainData.CurrentArrow != null)
            {
                if (currentContactPoint != null)
                {
                    _mainData.CurrentArrow.EndPoint = currentContactPoint;
                    currentContactPoint = null;
                    _mainData.IMouseHandler = new MoveAndSelectMouseHandler();
                }
                else
                {
                    _mainData.ArrowsList.Remove(_mainData.CurrentArrow);
                }
                _mainData.PictureBoxMain.Invalidate();
            }
        }
    }
}
