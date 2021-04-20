using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    public enum TypeOfLineDirection
    {
        FourPointsZikzakLeftRightLine,
        FourPointsZikzakUpDownLine,
        ThreePointsRectangeleLeftRightLine,
        ThreePointsRectangelUpDownLine,

        FivePointsFromeButomToFlankLine,
        FivePointsFromUpToFlankLine,
        FivePointsFromRightToUpOfBottomLine,
        FivePointsFromRightToUpOfBottomLineWithArounding,
        SixPointsFromRightToLeftOfRightLineWithArounding,
        //FivePointsFromLowerRightToUpLine,
        //FivePointsFromUpperRightToBottomLine,

        FivePointsFromLeftToBottomOrUpLine,

        FourPointsFromUpToUp,
        FourPointsFromBottomToBottom,
        FourPointsFromLeftToLeft,
        FourPointsFromRightToRight,
        FourPointsFromRightToRightWithArounding
    }
}
