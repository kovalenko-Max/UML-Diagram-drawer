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
    public class FormEditorHandler : IEditHandler
    {
        private MainData _mainData;
        public ColorDialog ColorDialog { get; set; }
        public FontDialog FontDialog { get; set; }

        public FormEditorHandler(ColorDialog colorDialog, FontDialog fontDialog)
        {
            if (colorDialog != null&& fontDialog!=null)
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

        public void SetColor_Click()
        {
            if (_mainData.SelectForm != null)
            {
                ColorDialog.ShowDialog();
                _mainData.SelectForm.SetColor(ColorDialog.Color);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetSize_Scroll(TrackBar trackBar)
        {
            if (_mainData.SelectForm != null)
            {
                _mainData.SelectForm.Resize(trackBar.Value);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetFont_Click()
        {
            if (_mainData.SelectForm != null)
            {
                FontDialog.ShowDialog();
                _mainData.SelectForm.SetFont(FontDialog.Font);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void AddField_Click()
        {
            if (_mainData.SelectForm != null)
            {
                _mainData.SelectForm.AddTextField(Forms.Modules.ModuleType.Field);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void AddMethod_Click()
        {
            if (_mainData.SelectForm != null)
            {
                _mainData.SelectForm.AddTextField(Forms.Modules.ModuleType.Method);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetColorText_Click()
        {
            if (_mainData.SelectForm != null)
            {
                ColorDialog.ShowDialog();
                _mainData.SelectForm.SetColorText(ColorDialog.Color);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetWidthLine(TrackBar trackBar)
        {
            if (_mainData.SelectForm != null)
            {
                _mainData.SelectForm.SetWidthLine(trackBar.Value);
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetBackColor_Click()
        {
            if (_mainData.SelectForm != null)
            {
                ColorDialog.ShowDialog();
                _mainData.SelectForm.BackGroundColor = ColorDialog.Color;
                _mainData.PictureBoxMain.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetArrowType(ComboBox combobox)
        {
            
        }
    }
}
