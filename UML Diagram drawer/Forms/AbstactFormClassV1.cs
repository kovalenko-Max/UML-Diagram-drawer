using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer.Forms
{
    public class AbstactFormClassV1 : Panel, ISelectable
    {
        private int _wightLine = 5;
        private Size _defaultSize = new Size(200, 75);

        //public Point Location { get; set; }
        //public Size Size { get; set; }

        public ContactPoint[] ContactPoints { get; set; }
        public bool IsSelected { get; set; }
        public Pen Pen { get; set; }
        public Rectangle[] Rectangles { get; set; }
        public Point[] Points { get; set; }
        public Size DefaultSize
        {
            get
            {
                return _defaultSize;
            }
            set
            {
                _defaultSize = value;
            }
        }

        #region Module
        public AbstractModuleFormV1 ClassName { get; set; }
        public bool FieldsBool { get; set; }
        public AbstractModuleFormV1 Fields { get; set; }
        public bool MethodsBool { get; set; }
        public AbstractModuleFormV1 Methods { get; set; }
        #endregion

        public AbstactFormClassV1(bool isDrawFields = false, bool isDrawMethods = false)
        {
            ClassName = new ClassNameModuleForm();
            Fields = new FieldsModuleForm();
            Methods = new MethodsModuleForm();
            DoubleBuffered = true;
            Fields.Visible = isDrawFields;
            Methods.Visible = isDrawMethods;
            Size = DefaultSize;

            Rectangles = new Rectangle[1];
            Pen = new Pen(Color.Black, _wightLine);
            base.Size = Size;
            base.BackColor = Color.Transparent;
            
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        public void CreateSelectionBorders()
        {

        }

        public void Draw()
        {
            if (!Location.IsEmpty)
            {
                DrawModuleForm();
                Rectangles[0] = new Rectangle(Location, DefaultSize);
                MainGraphics.Graphics.DrawRectangle(Pen, Rectangles[0]);
                ClassName.Draw();
                Fields.Draw();
                Methods.Draw();
            }
        }

        public void Move(int deltaX, int deltaY)
        {

        }

        public void RemoveSelect()
        {

        }

        public void Select(Point point)
        {

        }

        private void DrawModuleForm()
        {
            ClassName.Location = Location;
            ClassName.Size = Size;

            if (Fields.Visible && !Methods.Visible)
            {
                ClassName.Size = ClassName.DefaultSize;
                Fields.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                Fields.Draw();
            }
            else if (Fields.Visible && Methods.Visible)
            {
                ClassName.Size = ClassName.DefaultSize;

                Fields.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                Fields.Draw();

                Methods.Location = new Point(Fields.Location.X, Fields.Location.Y + Fields.Size.Height);
                Methods.Draw();
            }
            else if (!Fields.Visible && Methods.Visible)
            {
                ClassName.Size = ClassName.DefaultSize;
                
                Methods.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                Methods.Draw();
            }

            ClassName.Draw();
        }
    }
}

