using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    interface ISelectable
    {
        bool IsSelected { get; set; }

        void Move(int deltaX, int deltaY);

        void Draw();

        bool Select(Point point);

        void RemoveSelect();
    }
}
