using System.Collections.Generic;
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
        const int maxCountChanges = 15;
        private static MainData _mainData;
        private static List<MainData> _unDoStates;
        private static List<MainData> _reDoStates;

        public PictureBox PictureBoxMain { get; set; }
        public AbstractForm SelectForm { get; set; }
        public TextField SelectTextField { get; set; }
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
            _unDoStates = new List<MainData>();
            _reDoStates = new List<MainData>();
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
            _unDoStates.Add((MainData)_mainData.DeepCopy());
            if(_unDoStates.Count > maxCountChanges)
            {
                _unDoStates.RemoveAt(0);
            }
        }

        public static void ReDo()
        {
            if(_reDoStates.Count > 0)
            {
                int lastIndex = _reDoStates.Count - 1;
                MainData previousMainData = _reDoStates[lastIndex];
                _reDoStates.RemoveAt(lastIndex);
                previousMainData.IMouseHandler = new MoveAndSelectMouseHandler();
                _mainData = previousMainData;
                previousMainData.PictureBoxMain.Invalidate();
            }
        }

        public static void UnDo()
        {
            if (_unDoStates.Count > 0)
            {
                int lastIndex = _unDoStates.Count - 1;
                MainData previousMainData = _unDoStates[lastIndex];
                _reDoStates.Add(_unDoStates[lastIndex]);
                _unDoStates.RemoveAt(lastIndex);
                previousMainData.IMouseHandler = new MoveAndSelectMouseHandler();
                _mainData = previousMainData;
                _mainData.PictureBoxMain.Invalidate();
            }
        }

        private MainData DeepCopy()
        {
            MainData mainDataClone = (MainData)this.MemberwiseClone();

            mainDataClone.PictureBoxMain = this.PictureBoxMain;
            mainDataClone.CurrentArrow = this.CurrentArrow;
            mainDataClone.CurrentFormUML = this.CurrentFormUML;
            mainDataClone.SelectArrow = this.SelectArrow;
            mainDataClone.SelectForm = this.SelectForm;

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
