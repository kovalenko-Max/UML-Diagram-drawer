using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    public interface IArrowNock
    {
        void Draw(Pen pen, Point StartPoint, Point nextPoint);
    }
}