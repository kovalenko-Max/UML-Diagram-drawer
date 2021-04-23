using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer.MouseHandlers
{
    public interface IMouseHandler
    {
        void MouseClick(object sender, MouseEventArgs e);
        void MouseDown(object sender, MouseEventArgs e);
        void MouseUp(object sender, MouseEventArgs e);
        void MouseMove(object sender, MouseEventArgs e);
    }
}
