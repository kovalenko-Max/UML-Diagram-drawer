using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Forms.Modules;

namespace UML_Diagram_drawer.Forms
{
    public abstract class AbstractForm : ISelectable
    {
        public List<AbstactModule> _modules;
        protected Rectangle _rectangle;
        protected Pen _pen;
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
        public Color Color { get; set; }
          
        
        public SolidBrush Brush { get; set; }
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
            _pen = Default.Draw.Pen;
            Color = _pen.Color;
            Brush = Default.Draw.FillBrush;
            Font = Default.Text.Font;
            _modules = new List<AbstactModule>();
            _rectangle = new Rectangle(Location, Default.Size.FormSize);
            SetContactPoint();
            CreateModules(createFields, createMethods);
        }

        public AbstractForm(AbstractForm form)
        {
            Type = form.Type;
            TitleText = form.TitleText;
            _pen = new Pen(form.Color, form.WidthLine);
            Font = form.Font;
            Brush = form.Brush;
            Size = form.Size;
            Location = form.Location;
            ContactPoints = form.ContactPoints;
            _modules = form._modules;
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

        public void Draw()
        {
            ResizeRectangle();
            SetWidthToModule();
            MainGraphics.Graphics.FillRectangle(Brush, _rectangle);
            DrawModules();
            SetContactPoint();
            if (IsSelected)
            {
                DrawSelectRectangle();
            }
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
            foreach (AbstactModule module in _modules)
            {
                module.Resize(value);
            }
        }

        public void SetFont(Font font)
        {
            if (font != null)
            {
                Font = font;
                foreach (AbstactModule module in _modules)
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
            foreach (AbstactModule module in _modules)
            {
                module.WidthLine = value;
            }
        }

        public void SetColor(Color color)
        {
            foreach (AbstactModule module in _modules)
            {
                module.Color = color;
            }
        }

        public void SetColorText(Color color)
        {
            foreach (AbstactModule module in _modules)
            {
                module.SetColorText(color);
            }
        }

        public void AddTextField(string text, ModuleType type)
        {
            if (text != null)
            {
                foreach (AbstactModule module in _modules)
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
            foreach (AbstactModule module in _modules)
            {
                if (module.Type == type)
                {
                    module.AddTextField();
                }
            }
        }

        public void ChangeTextField(Point point, string text)
        {
            if (text != null)
            {
                SelectTextField(point).Text = text;
            }
            else
            {
                throw new ArgumentException("Text is null");
            }
        }

        public void RemoveTextField(Point point)
        {
            foreach (AbstactModule module in _modules)
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
            foreach (AbstactModule module in _modules)
            {
                int value = module.GetMaximumWidth();
                if (maxWidth < value)
                {
                    maxWidth = value;
                }
            }

            foreach (AbstactModule module in _modules)
            {
                module.SetWidth(maxWidth);
            }
        }

        private void DrawSelectRectangle()
        {
            Rectangle selectRectangle = new Rectangle();
            selectRectangle.Size = new Size(Size.Width + 40, Size.Height + 40);
            selectRectangle.Location = new Point(Location.X - 20, Location.Y - 20);
            MainGraphics.Graphics.DrawRectangle(Default.Draw.PenSelect, selectRectangle);
        }

        protected TextField SelectTextField(Point point)
        {
            if (Contains(point))
            {
                TextField result = null;
                foreach (AbstactModule module in _modules)
                {
                    if (module.Contains(point))
                    {
                        result = module.SelectTextField(point);
                    }
                }

                return result;
            }

            throw new Exception("Point out of range");
        }

        protected void CreateModules(bool createFields = true, bool createMethods = true)
        {
            _modules.Add(new TitleModule(ModuleType.Title, TitleText, Default.Text.TitleStringFormat));

            if (createFields)
            {
                _modules.Add(new FieldModule(ModuleType.Field, Default.Text.FieldText, Default.Text.FieldStringFormat));
            }

            if (createMethods)
            {
                _modules.Add(new MethodModule(ModuleType.Method, Default.Text.MethodText, Default.Text.MethodStringFormat));
            }
        }

        protected void DrawModules()
        {
            int currentLocationY = 0;
            foreach (AbstactModule module in _modules)
            {
                module.Location = new Point(this.Location.X, this.Location.Y + currentLocationY);
                module.Size = new Size(Size.Width, module.GetDesiredSize().Height);
                currentLocationY += module.Size.Height;
                module.Draw();
            }
        }

        protected Size GetDesiredSize()
        {
            Size desiredSize = Size.Empty;
            for (int i = 0; i < _modules.Count; i++)
            {
                if (desiredSize.Width < _modules[i].GetDesiredSize().Width)
                {
                    desiredSize.Width = _modules[i].GetDesiredSize().Width;
                }
                desiredSize.Height += _modules[i].GetDesiredSize().Height;
            }

            return desiredSize;
        }

        protected void ResizeRectangle()
        {
            int addedWidth = GetDesiredSize().Width == 0 ? Default.Size.ModuleFormSize.Width : 0;
            int addedHeight = GetDesiredSize().Height == 0 ? Default.Size.ModuleFormSize.Height * _modules.Count : 0;
            Size = new Size(addedWidth + GetDesiredSize().Width, addedHeight + GetDesiredSize().Height);
        }

        protected void SetContactPoint()
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
    }
}
