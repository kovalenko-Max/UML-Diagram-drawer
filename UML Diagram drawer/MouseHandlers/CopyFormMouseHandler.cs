﻿using System.Windows.Forms;
using UML_Diagram_drawer.Forms;
using Form = UML_Diagram_drawer.Forms.Form;

namespace UML_Diagram_drawer.MouseHandlers
{
    public class CopyFormMouseHandler : IMouseHandler
    {
        private MainData _mainData = MainData.GetMainData();

        public void MouseClick(object sender, MouseEventArgs e)
        {
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (_mainData.SelectForm != null)
            {
                if (_mainData.SelectForm.Contains(e.Location))
                {
                    _mainData.FormInBuffer = new Form(_mainData.SelectForm);
                }
                else
                {
                    _mainData.SelectForm.RemoveSelect();
                }
            }
            else if(_mainData.SelectForm == null)
            {
                foreach (AbstractForm form in _mainData.FormsList)
                {
                    if (form.Contains(e.Location))
                    {
                        form.Select(e.Location);
                        _mainData.SelectForm = form;
                        _mainData.FormInBuffer = new Form(form);
                    }
                }
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
