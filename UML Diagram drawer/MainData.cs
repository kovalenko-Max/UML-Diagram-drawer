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

        public Stack<MainData> lastChanges;
        public PictureBox PictureBoxMain { get; set; }
        public AbstractForm SelectForm { get; set; }
        public Arrow SelectArrow { get; set; }
        public AbstractForm CurrentFormUML { get; set; }
        public Arrow CurrentArrow { get; set; }
        public AbstractForm FormInBuffer { get; set; }
        public List<AbstractForm> FormsList { get; set; }
        public List<Arrow> ArrowsList { get; set; }

        public IMouseHandler IMouseHandler { get; set; }
        
        private MainData()
        {
            lastChanges = new Stack<MainData>();
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

        public void SaveChanges()
        {
            lastChanges.Push((MainData)_mainData.MemberwiseClone());
        }

        public void rollingBackChanges()
        {
            _mainData = lastChanges.Pop();
            _mainData.PictureBoxMain.Invalidate();
        }
    }
}
