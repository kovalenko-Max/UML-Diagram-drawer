using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.MouseHandlers
{
    public class SelectFormMouseHandler : IMouseHandler
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
