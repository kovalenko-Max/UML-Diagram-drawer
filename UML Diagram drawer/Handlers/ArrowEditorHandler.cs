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
    class ArrowEditorHandler : IEditHandler
    {
        private MainData _mainData;
        
        public ColorDialog ColorDialog { get ; set ; }
        public FontDialog FontDialog { get ; set ; }

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

        }

        public void SetFont_Click()
        {

        }

        public void SetSize_Scroll(TrackBar trackBar)
        {

        }

        public void SetWidthLine(TrackBar trackBar)
        {

        }

        public void SetArrowType()
        {
            
        }
    }
}
