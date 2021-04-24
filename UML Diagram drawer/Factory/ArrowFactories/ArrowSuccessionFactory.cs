using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Arrows.ArrowHeads;
using UML_Diagram_drawer.Arrows.ArrowLines;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    public class ArrowSuccessionFactory : IArrowsFactory
    {
        public Arrow GetArrow()
        {
            return new Arrow(new SolidArrowLine(), arrowHead: new TriangleArrowHead());
        }
        public Arrow GetArrow(Arrow arrow)
        {
            return new Arrow(arrow, new SolidArrowLine(), arrowHead: new TriangleArrowHead());
        }
    }
}