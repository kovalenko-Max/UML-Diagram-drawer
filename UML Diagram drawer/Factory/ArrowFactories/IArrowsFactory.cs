using UML_Diagram_drawer.Arrows;

namespace UML_Diagram_drawer.Factory.ArrowFactories
{
    public interface IArrowsFactory
    {
        Arrow GetArrow();

        Arrow GetArrow(Arrow arrow);
    }
}