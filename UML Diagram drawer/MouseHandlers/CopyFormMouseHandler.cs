using System.Windows.Forms;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.MouseHandlers
{
    public class CopyFormMouseHandler : IMouseHandler
    {
        private MainData _mainData = MainData.GetMainData();

        public void MouseClick(object sender, MouseEventArgs e)
        {
            foreach (AbstractForm form in _mainData.FormsList)
            {
                if (form.Contains(e.Location))
                {
                    form.Select(e.Location);
                    _mainData.CurrentFormUML = form;
                }
            }

            _mainData.PictureBoxMain.Invalidate();
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (_mainData.SelectForm != null)
            {
                _mainData.SelectForm.RemoveSelectTextFields();
                _mainData.SelectTextField = null;
            }

            if(_mainData.SelectForm != null)
            {
               var textField =  _mainData.SelectForm.GetTextField(e.Location);
                if (textField != null)
                {
                    textField.Select();
                    _mainData.SelectTextField = textField;
                }

                _mainData.PictureBoxMain.Invalidate();
            }
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {

        }

        public void MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
