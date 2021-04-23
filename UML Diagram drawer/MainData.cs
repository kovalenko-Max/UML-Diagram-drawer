using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.MouseHandlers;

namespace UML_Diagram_drawer
{
    public class MainData
    {
        private static MainData _mainData;

        public PictureBox PictureBoxMain { get; set; }
        public AbstractForm CurrentFormUML { get; set; }
        public AbstactArrow CurrentArrow { get; set; }
        public AbstractForm FormInBuffer { get; set; }
        public List<AbstractForm> FormsList { get; set; }
        public List<AbstactArrow> ArrowsList { get; set; }

        public IMouseHandler IMouseHandler { get; set; }
        
        private MainData()
        {
        }

        public static MainData GetMainData()
        {
            if (_mainData == null)
            {
                return _mainData = new MainData();
            }
            else
            {
                return _mainData;
            }
        }
    }
}
