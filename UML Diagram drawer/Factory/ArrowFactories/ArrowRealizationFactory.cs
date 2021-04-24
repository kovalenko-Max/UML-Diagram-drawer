using UML_Diagram_drawer.Arrows.ArrowHeads;
using UML_Diagram_drawer.Arrows.ArrowLines;
using UML_Diagram_drawer.Arrows;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    public class ArrowRealizationFactory : IArrowsFactory
    {
        public Arrow GetArrow()
        {
            return new Arrow(new DashArrowLine(), arrowHead: new TriangleArrowHead());
        }
    }
}
