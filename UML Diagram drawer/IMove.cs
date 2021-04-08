using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    public interface IMove
    {
        bool IsMove { get; set; }
        Pen Pen { get; set; }
        Graphics Graphics { get; set; }

        void Draw();

        void StartMove(Point point);
        void Move(Point point);
        void EndMove();
    }
}
