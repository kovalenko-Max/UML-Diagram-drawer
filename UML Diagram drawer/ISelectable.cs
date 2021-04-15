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
        Pen Pen { get; set; }
        Rectangle[] Rectangles { get; set; }
        Point[] Points { get; set; }

        void CreateSelectionBorders();

        void Move(int deltaX, int deltaY);

        void Draw();

        void Select(Point point);

        void RemoveSelect();
    }
}
