using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Handlers
{
    public interface IEditHandler
    {
        ColorDialog ColorDialog { get; set; }
        FontDialog FontDialog { get; set; }

        void SetColor_Click();
        void SetSize_Scroll(TrackBar trackBar);
        void SetFont_Click();
        void AddField_Click();
        void AddMethod_Click();
        void SetColorText_Click();
        void SetWidthLine(TrackBar trackBar);
        void SetBackColor_Click();
        void SetArrowType();
    }
}
