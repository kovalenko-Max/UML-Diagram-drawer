using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Factory;
using UML_Diagram_drawer.Factory.ArrowFactories;
using UML_Diagram_drawer.Forms;
using UML_Diagram_drawer.MouseHandlers;

namespace UML_Diagram_drawer
{
    public class MainData
    {
        private static MainData _mainData;
        public static Stack<MainData> lastChanges;

        public PictureBox PictureBoxMain { get; set; }
        public AbstractForm SelectForm { get; set; }
        public Arrow SelectArrow { get; set; }
        public AbstractForm CurrentFormUML { get; set; }
        public Arrow CurrentArrow { get; set; }
        public AbstractForm FormInBuffer { get; set; }
        public List<AbstractForm> FormsList { get; set; }
        public List<Arrow> ArrowsList { get; set; }
        public IFormsFactory _formFactory { get; set; }
        public IArrowsFactory _arrowsFactory { get; set; }
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
            lastChanges.Push((MainData)_mainData.DeepCopy());
        }

        public static void rollingBackChanges()
        {
            if (lastChanges.Count > 0)
            {
                MainData previousMainData = lastChanges.Pop();
                previousMainData.IMouseHandler = new MoveAndSelectMouseHandler();
                previousMainData.PictureBoxMain.Invalidate();
                _mainData = previousMainData;
            }
        }

        private MainData DeepCopy()
        {
            MainData mainDataClone = (MainData)this.MemberwiseClone();
            //reference
            mainDataClone.PictureBoxMain = this.PictureBoxMain;
            mainDataClone.CurrentArrow = this.CurrentArrow;
            mainDataClone.CurrentFormUML = this.CurrentFormUML;
            mainDataClone.SelectArrow = this.SelectArrow;
            mainDataClone.SelectForm = this.SelectForm;

            //clone
            mainDataClone.FormsList = MainData.CloneFormsList(FormsList);
            mainDataClone.ArrowsList = MainData.CloneArrowList(ArrowsList);

            return mainDataClone;
        }

        private static List<AbstractForm> CloneFormsList(List<AbstractForm> listForClone)
        {
            List<AbstractForm> newList = new List<AbstractForm>(listForClone.Count);

            listForClone.ForEach((item) =>
            {
                newList.Add((AbstractForm)item.Clone());
            });

            return newList;
        }

        private static List<Arrow> CloneArrowList(List<Arrow> listForClone)
        {
            List<Arrow> newList = new List<Arrow>(listForClone.Count);

            listForClone.ForEach((item) =>
            {
                newList.Add((Arrow)item.Clone());
            });

            return newList;
        }
    }
}
