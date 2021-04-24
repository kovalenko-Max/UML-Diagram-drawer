using System.Drawing;

namespace UML_Diagram_drawer.Arrows.ArrowLines
{
    public interface IArrowLine
    {
        void Draw(Pen pen, Point[] arrowLinePoints);
    }
}
