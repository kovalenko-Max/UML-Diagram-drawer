using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UML_Diagram_drawer.Arrows;
using UML_Diagram_drawer.Factory.ArrowFactories;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Handlers
{
    class ArrowEditorHandler : IEditHandler
    {
        private MainData _mainData;

        public ColorDialog ColorDialog { get; set; }
        public FontDialog FontDialog { get; set; }

        public ArrowEditorHandler(ColorDialog colorDialog, FontDialog fontDialog)
        {
            if (colorDialog != null && fontDialog != null)
            {
                _mainData = MainData.GetMainData();
                ColorDialog = colorDialog;
                FontDialog = fontDialog;
            }
            else
            {
                throw new ArgumentNullException("Values is null");
            }
        }

        public void AddField_Click()
        {

        }

        public void AddMethod_Click()
        {

        }

        public void SetBackColor_Click()
        {

        }

        public void SetColorText_Click()
        {

        }

        public void SetColor_Click()
        {
            ColorDialog.ShowDialog();
            _mainData.SelectArrow.SetColor( ColorDialog.Color);
            _mainData.PictureBoxMain.Invalidate();
        }

        public void SetFont_Click()
        {

        }

        public void SetSize_Scroll(TrackBar trackBar)
        {

        }

        public void SetWidthLine(TrackBar trackBar)
        {
            _mainData.SelectArrow.WidthLine = trackBar.Value;
            _mainData.PictureBoxMain.Invalidate();
        }

        public void SetArrowType(ComboBox combobox)
        {
            Arrow arrow = null;
            switch (combobox.SelectedIndex)
            {
                case 0:
                    arrow = new ArrowAssociationFactory().GetArrow(_mainData.SelectArrow);
                    break;
                case 1:
                    arrow = new ArrowSuccessionFactory().GetArrow(_mainData.SelectArrow);
                    break;
                case 2:
                    arrow = new ArrowRealizationFactory().GetArrow(_mainData.SelectArrow);
                    break;
                case 3:
                    arrow = new ArrowAggregationFactory().GetArrow(_mainData.SelectArrow);
                    break;
                case 4:
                    arrow = new ArrowCompositionFactory().GetArrow(_mainData.SelectArrow);
                    break;
            }

            if(arrow != null)
            {
                _mainData.ArrowsList.Add(arrow);
                _mainData.ArrowsList.Remove(_mainData.SelectArrow);
                _mainData.SelectArrow = arrow;
            }

            _mainData.PictureBoxMain.Invalidate();
        }
    }
}
