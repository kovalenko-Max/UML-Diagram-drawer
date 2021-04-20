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
        protected List<AbstactModule> _modules;
        protected Rectangle _rectangle;

        public string TitleText { get; set; }
        public ContactPoint[] ContactPoints { get; set; }
        public bool IsSelected { get; set; }
        public Pen Pen { get; set; }
        public SolidBrush Brush { get; set; }
        public FormType Type { get; set; }
        public Size SIze
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

        public AbstractForm(FormType type, bool createFields, bool createMethods, string titleText)
        {
            Type = type;
            TitleText = titleText;
            Pen = Default.Draw.Pen;
            Brush = Default.Draw.FillBrush;
            _modules = new List<AbstactModule>();
            _rectangle = new Rectangle(Location, Default.Size.FormSize);
            SetContactPoint();
            CreateModules(createFields, createMethods);
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
            MainGraphics.Graphics.FillRectangle(Brush, GetRectangle());
            MainGraphics.Graphics.DrawRectangle(Pen, GetRectangle());

            DrawModules();
            SetContactPoint();
        }

        public void Move(int deltaX, int deltaY)
        {
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }

        public void RemoveSelect()
        {
            if (!IsSelected)
            {
                IsSelected = false;
                Pen = Default.Draw.Pen;

                foreach (var item in _modules)
                {
                    item.Pen = Pen;
                }
            }
        }

        public bool Select(Point point)
        {
            if (!IsSelected && _rectangle.Contains(point))
            {
                Pen = Default.Draw.PenSelect;

                foreach (AbstactModule module in _modules)
                {
                    module.Pen = Pen;
                }

                IsSelected = true;
            }

            return IsSelected;
        }

        public bool Contains(Point point)
        {
            return _rectangle.Contains(point);
        }

        public void AddTextField(string text, Type type)
        {
            if (text != null)
            {
                foreach (AbstactModule module in _modules)
                {
                    if (module.GetType() == type)
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
            _modules.Add(new TitleModule() { DefaultText = TitleText });

            if (createFields)
            {
                _modules.Add(new FieldModule() { DefaultText = Default.Text.FieldText });
            }

            if (createMethods)
            {
                _modules.Add(new MethodModule() { DefaultText = Default.Text.MethodText });
            }
        }

        protected void DrawModules()
        {
            int currentLocationY = 0;
            foreach (AbstactModule module in _modules)
            {
                module.Location = new Point(this.Location.X, this.Location.Y + currentLocationY);
                currentLocationY += module.Size.Height;
                module.Draw();
            }
        }

        protected Rectangle GetRectangle()
        {
            int currentSizeY = 0;
            for (int i = 0; i < _modules.Count; i++)
            {
                currentSizeY += _modules[i].Size.Height;
            }

            int addedHeight = currentSizeY == 0 ? Default.Size.ModuleFormSize.Height * 3 : 0;
            _rectangle.Size = new Size(_rectangle.Size.Width, addedHeight + currentSizeY);

            return _rectangle;
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
                ContactPoints[3] = new ContactPoint(location, Side.Down);
            }
        }
    }
}
