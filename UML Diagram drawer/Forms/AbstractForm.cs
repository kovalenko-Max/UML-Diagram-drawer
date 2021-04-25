using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Forms.Modules;

namespace UML_Diagram_drawer.Forms
{
    public abstract class AbstractForm : ISelectable, ICloneable
    {
        protected SolidBrush _brush;
        protected Rectangle _rectangle;
        protected Pen _pen;

        public List<AbstactModule> Modules { get; set; }
        public string TitleText { get; set; }
        public bool IsSelected { get; set; }
        public float WidthLine
        {
            get
            {
                if (_pen != null)
                {
                    return _pen.Width;
                }

                throw new ArgumentNullException("Pen is null");
            }
            set
            {
                if (_pen != null)
                {
                    _pen.Width = value;
                }
                else
                {
                    throw new ArgumentNullException("Pen is null");
                }
            }
        }
        public ContactPoint[] ContactPoints { get; set; }
        public Color BackGroundColor
        {
            get
            {
                if (_brush != null)
                {
                    return _brush.Color;
                }

                throw new ArgumentNullException("Brush is null");
            }
            set
            {
                if (_brush != null)
                {
                    _brush.Color = value;
                }
                else
                {
                    throw new ArgumentNullException("Brush is null");
                }
            }
        }
        public Font Font { get; set; }
        public FormType Type { get; set; }
        public Size Size
        {
            get
            {
                return _rectangle.Size;
            }
            set
            {
                _rectangle.Size = value;
            }
        }
        public Point Location
        {
            get
            {
                return _rectangle.Location;
            }
            set
            {
                _rectangle.Location = value;
            }
        }

        public AbstractForm()
        {
        }

        public AbstractForm(FormType type, bool createFields, bool createMethods, string titleText)
        {
            Type = type;
            TitleText = titleText;
            _pen = (Pen)Default.Draw.Pen.Clone();
            _brush = (SolidBrush)Default.Draw.FillBrush.Clone();
            Font = (Font)Default.Text.Font.Clone();
            Modules = new List<AbstactModule>();
            _rectangle = new Rectangle(Location, Default.Size.FormSize);
            SetContactPoint();
            CreateModules(createFields, createMethods);
        }

        public AbstractForm(AbstractForm form)
        {
            Type = form.Type;
            TitleText = form.TitleText;
            _pen = (Pen)form._pen.Clone();
            Font = form.Font;
            _brush = form._brush;
            Size = form.Size;
            Location = form.Location;
            ContactPoints = form.ContactPoints;
            Modules = form.Modules;
        }

        public void Draw()
        {
            ResizeRectangle();
            SetWidthToModule();
            MainGraphics.Graphics.FillRectangle(_brush, _rectangle);
            DrawModules();
            SetContactPoint();
            if (IsSelected)
            {
                DrawSelectRectangle();
            }
        }

        public ContactPoint ConnectArrow(Point point)
        {
            ContactPoint result = ContactPoint.Empty;

            foreach (ContactPoint contactPoint in ContactPoints)
            {
                if (contactPoint.Contains(point))
                {
                    result = contactPoint;
                }
            }

            return result;
        }

        public void Move(int deltaX, int deltaY)
        {
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }

        public void RemoveSelect()
        {
            if (IsSelected)
            {
                IsSelected = false;
            }
        }

        public bool Select(Point point)
        {
            if (!IsSelected && _rectangle.Contains(point))
            {
                IsSelected = true;
            }
            return IsSelected;
        }

        public bool Contains(Point point)
        {
            return _rectangle.Contains(point);
        }

        public void Resize(int value)
        {
            Font = new Font(Font.FontFamily, value);
            foreach (AbstactModule module in Modules)
            {
                module.Resize(value);
            }
        }

        public void SetFont(Font font)
        {
            if (font != null)
            {
                Font = font;
                foreach (AbstactModule module in Modules)
                {
                    module.SetFont(font);
                }
            }
            else
            {
                throw new ArgumentNullException("Font is null");
            }
        }

        public void SetWidthLine(int value)
        {
            foreach (AbstactModule module in Modules)
            {
                module.WidthLine = value;
            }
        }

        public void SetColor(Color color)
        {
            foreach (AbstactModule module in Modules)
            {
                module.Color = color;
            }
        }

        public void SetColorText(Color color)
        {
            foreach (AbstactModule module in Modules)
            {
                module.SetColorText(color);
            }
        }

        public void AddTextField(string text, ModuleType type)
        {
            if (text != null)
            {
                foreach (AbstactModule module in Modules)
                {
                    if (module.Type == type)
                    {
                        module.AddTextField(text);
                    }
                }
            }
            else
            {
                throw new ArgumentException("Text is null");
            }
        }

        public void AddTextField(ModuleType type)
        {
            foreach (AbstactModule module in Modules)
            {
                if (module.Type == type)
                {
                    module.AddTextField();
                }
            }
        }

        //public void ChangeTextField(Point point, string text)
        //{
        //    if (text != null)
        //    {
        //        SelectTextField(point).Text = text;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("Text is null");
        //    }
        //}

        public void RemoveSelectTextFields()
        {
            foreach (AbstactModule module in Modules)
            {
                module.RemoveSelectTextFields();
            }
        }

        public TextField GetTextField(Point point)
        {
            TextField result = null;
            if (Contains(point))
            {
                foreach (AbstactModule module in Modules)
                {
                    if (module.Contains(point))
                    {
                        result = module.GetTextField(point);
                    }
                }
            }

            return result;
        }

        public void RemoveTextField(Point point)
        {
            foreach (AbstactModule module in Modules)
            {
                module.RemoveTextField(point);
            }
        }

        public abstract override bool Equals(object obj);

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(Location);

            return result.ToString();
        }

        private void SetWidthToModule()
        {
            int maxWidth = 0;
            foreach (AbstactModule module in Modules)
            {
                int value = module.GetMaximumWidth();
                if (maxWidth < value)
                {
                    maxWidth = value;
                }
            }

            foreach (AbstactModule module in Modules)
            {
                module.SetWidth(maxWidth);
            }
        }

        private void DrawSelectRectangle()
        {
            Rectangle selectRectangle = new Rectangle();
            selectRectangle.Size = new Size(Size.Width + 40, Size.Height + 40);
            selectRectangle.Location = new Point(Location.X - 20, Location.Y - 20);
            MainGraphics.Graphics.DrawRectangle(Default.Draw.PenDash, selectRectangle);
        }

        //private TextField SelectTextField(Point point)
        //{
        //    if (Contains(point))
        //    {
        //        TextField result = null;
        //        foreach (AbstactModule module in Modules)
        //        {
        //            if (module.Contains(point))
        //            {
        //                result = module.GetTextField(point);
        //            }
        //        }

        //        return result;
        //    }

        //    throw new Exception("Point out of range");
        //}

        private void CreateModules(bool createFields = true, bool createMethods = true)
        {
            Modules.Add(new TitleModule(ModuleType.Title, TitleText, Default.Text.TitleStringFormat));

            if (createFields)
            {
                Modules.Add(new FieldModule(ModuleType.Field, Default.Text.FieldText, Default.Text.FieldStringFormat));
            }

            if (createMethods)
            {
                Modules.Add(new MethodModule(ModuleType.Method, Default.Text.MethodText, Default.Text.MethodStringFormat));
            }
        }

        private void DrawModules()
        {
            int currentLocationY = 0;
            foreach (AbstactModule module in Modules)
            {
                module.Location = new Point(this.Location.X, this.Location.Y + currentLocationY);
                module.Size = new Size(Size.Width, module.GetDesiredSize().Height);
                currentLocationY += module.Size.Height;
                module.Draw();
            }
        }

        private Size GetDesiredSize()
        {
            Size desiredSize = Size.Empty;
            for (int i = 0; i < Modules.Count; i++)
            {
                if (desiredSize.Width < Modules[i].GetDesiredSize().Width)
                {
                    desiredSize.Width = Modules[i].GetDesiredSize().Width;
                }
                desiredSize.Height += Modules[i].GetDesiredSize().Height;
            }

            return desiredSize;
        }

        private void ResizeRectangle()
        {
            int addedWidth = GetDesiredSize().Width == 0 ? Default.Size.ModuleFormSize.Width : 0;
            int addedHeight = GetDesiredSize().Height == 0 ? Default.Size.ModuleFormSize.Height * Modules.Count : 0;
            Size = new Size(addedWidth + GetDesiredSize().Width, addedHeight + GetDesiredSize().Height);
        }

        private void SetContactPoint()
        {
            if (ContactPoints != null && ContactPoints.Length > 0)
            {
                ContactPoints[0].Location = new Point(Location.X + _rectangle.Width / 2, Location.Y); ;
                ContactPoints[1].Location = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height / 2); ;
                ContactPoints[2].Location = new Point(Location.X, Location.Y + _rectangle.Height / 2); ;
                ContactPoints[3].Location = new Point(Location.X + _rectangle.Width / 2, Location.Y + _rectangle.Height); ;
            }
            else
            {
                ContactPoints = new ContactPoint[4];
                Point location = new Point(Location.X + _rectangle.Width / 2, Location.Y);
                ContactPoints[0] = new ContactPoint(location, Side.Up);
                location = new Point(Location.X + _rectangle.Width, Location.Y + _rectangle.Height / 2);
                ContactPoints[1] = new ContactPoint(location, Side.Right);
                location = new Point(Location.X, Location.Y + _rectangle.Height / 2);
                ContactPoints[2] = new ContactPoint(location, Side.Left);
                location = new Point(Location.X + _rectangle.Width / 2, Location.Y + _rectangle.Height);
                ContactPoints[3] = new ContactPoint(location, Side.Bottom);
            }
        }

        public object Clone()
        {
            AbstractForm cloneForm = (AbstractForm)this.MemberwiseClone();

            cloneForm.Modules = CloneModulesList(Modules);
            cloneForm.Location = this.Location;
            cloneForm.Color = this.Color;
            return cloneForm;
        }

        private static List<AbstactModule> CloneModulesList(List<AbstactModule> listForClone)
        {
            List<AbstactModule> newList = new List<AbstactModule>(listForClone.Count);

            listForClone.ForEach((item) =>
            {
                newList.Add((AbstactModule)item.Clone());
            });

            return newList;
        }
    }
}
