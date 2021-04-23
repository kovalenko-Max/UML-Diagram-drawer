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
        public PictureBox Canvas { get; set; }
        public AbstractForm Form { get; set; }
        public AbstactArrow Arrow { get; set; }
        public ColorDialog ColorDialog { get; set; }
        public FontDialog FontDialog { get; set; }

        public FormEditorHandler(AbstractForm form, PictureBox pb, ColorDialog colorDialog, FontDialog fontDialog)
        {
            if (form != null && pb != null && colorDialog != null&& fontDialog!=null)
            {
                Form = form;
                Canvas = pb;
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
            if (Form != null)
            {
                ColorDialog.ShowDialog();
                Form.SetColor(ColorDialog.Color);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetSize_Scroll(TrackBar trackBar)
        {
            if (Form != null)
            {
                Form.Resize(trackBar.Value);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetFont_Click()
        {
            if (Form != null)
            {
                FontDialog.ShowDialog();
                Form.SetFont(FontDialog.Font);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void AddField_Click()
        {
            if (Form != null)
            {
                Form.AddTextField(Forms.Modules.ModuleType.Field);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void AddMethod_Click()
        {
            if (Form != null)
            {
                Form.AddTextField(Forms.Modules.ModuleType.Method);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetColorText_Click()
        {
            if (Form != null)
            {
                ColorDialog.ShowDialog();
                Form.SetColorText(ColorDialog.Color);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetWidthLine(TrackBar trackBar)
        {
            if (Form != null)
            {
                Form.SetWidthLine(trackBar.Value);
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }

        public void SetBackColor_Click()
        {
            if (Form != null)
            {
                ColorDialog.ShowDialog();
                Form.Color = ColorDialog.Color;
                Canvas.Invalidate();
            }
            else
            {
                throw new ArgumentNullException("Object is null");
            }
        }
    }
}
