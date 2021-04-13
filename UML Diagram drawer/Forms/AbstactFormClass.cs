using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer.Forms
{
    class AbstactFormClass :Panel, ISelectable
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
        public AbstractModuleForm ClassName { get; set; }
        public bool FieldsBool { get; set; }
        public AbstractModuleForm Fields { get; set; }
        public bool MethodsBool { get; set; }
        public AbstractModuleForm Methods { get; set; }
        #endregion
        public AbstactFormClass(bool isDrawFields = false, bool isDrawMethods = false)
        {
            DoubleBuffered = true;
            FieldsBool = isDrawFields;
            MethodsBool = isDrawMethods;
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
                Rectangles[0]= new Rectangle(Location, DefaultSize);
                MainGraphics.Graphics.DrawRectangle(Pen, Rectangles[0]);
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
            ClassName = new ClassNameModuleForm();
            ClassName.Location = Location;
            ClassName.Size = Size;

            if (FieldsBool && !MethodsBool)
            {
                ClassName.Size = ClassName.DefaultSize;
                Fields = new FieldsModuleForm();
                Fields.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                Fields.Draw();

                AddMethodModuleForm emptyMetod = new AddMethodModuleForm();
                emptyMetod.Location = new Point(Fields.Location.X, Fields.Location.Y + Fields.Size.Height);
                emptyMetod.Draw();
            }
            else if (FieldsBool && MethodsBool)
            {
                ClassName.Size = ClassName.DefaultSize;

                Fields = new FieldsModuleForm();
                Fields.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                Fields.Draw();

                Methods = new MethodsModuleForm();
                Methods.Location = new Point(Fields.Location.X, Fields.Location.Y + Fields.Size.Height);
                Methods.Draw();
            }
            else if (!FieldsBool && MethodsBool)
            {
                ClassName.Size = ClassName.DefaultSize;
                AddFieldModuleForm emptyField = new AddFieldModuleForm();
                emptyField.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                emptyField.Draw(); 

                Methods = new MethodsModuleForm();
                Methods.Location = new Point(emptyField.Location.X, emptyField.Location.Y + emptyField.Size.Height);
                Methods.Draw();
            }
            else if(!FieldsBool && !MethodsBool)
            {
                ClassName.Size = ClassName.DefaultSize;
                AddFieldModuleForm emptyField = new AddFieldModuleForm();
                emptyField.Location = new Point(ClassName.Location.X, ClassName.Location.Y + ClassName.Size.Height);
                emptyField.Draw();

                AddMethodModuleForm emptyMetod = new AddMethodModuleForm();
                emptyMetod.Location = new Point(emptyField.Location.X, emptyField.Location.Y + emptyField.Size.Height);
                emptyMetod.Draw();
            }
            ClassName.Draw();
        }
    }
}

