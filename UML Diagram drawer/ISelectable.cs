using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public interface ISelectable
    {
        bool IsSelected { get; set; }
        bool IsMove { get; set; }
        Pen Pen { get; set; }
        Graphics Graphics { get; set; }
        void Draw();

        bool Select(Point point);
        void RemoveSelect();

        void Move(int deltaX, int deltaY);
    }
}
