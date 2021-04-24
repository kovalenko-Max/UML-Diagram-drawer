using System.Drawing;

namespace UML_Diagram_drawer.Arrows
{
    public interface IArrowHead
    {
        void Draw(Pen pen, Point endPoint, Point preEndPoint);
    }
}
