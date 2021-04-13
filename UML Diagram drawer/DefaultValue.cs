using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    public static class DefaultValue
    {
        private static StringFormat _stringFormat = new StringFormat();
        private static Font _font = new Font("Arial", 14);
        //private static int _defaultFormWidth = 200;
        //private static int _defaultFormHeight = 50;
        private static Size _formSize = new Size(200, 50);
        private static Size _textFieldSize = new Size(200, 25);
        private static Size _moduleFormSize = new Size(200, 25);
        public static Font Font
        {
            get
            {
                if (_font != null)
                {
                    return _font;
                }

                throw new ArgumentNullException("Default Font is null");
            }
            private set
            {
                if (value != null)
                {
                    _font = value;
                }
                else
                {
                    throw new ArgumentNullException("Value is null");
                }
            }
        }
        public static StringFormat TitleStringFormat
        {
            get
            {
                if (_stringFormat != null)
                {
                    _stringFormat.Alignment = StringAlignment.Center;
                    _stringFormat.LineAlignment = StringAlignment.Center;
                    return _stringFormat;
                }

                throw new ArgumentNullException("Default StringFormat is null");
            }
            private set
            {
                if (value != null)
                {
                    _stringFormat = value;
                }
                else
                {
                    throw new ArgumentNullException("Value is null");
                }
            }

        }
        public static Size FormSize
        {
            get
            {
                if (_formSize != null)
                {
                    return _formSize;
                }

                throw new ArgumentNullException("Default form size is null");
            }
            set
            {
                if(value != null)
                {
                    _formSize = value;
                }
                else
                {
                    throw new ArgumentNullException("Value is null");
                }
            }
        }
        public static Size TextFieldSize
        {
            get
            {
                if (_textFieldSize != null)
                {
                    return _textFieldSize;
                }

                throw new ArgumentNullException("Default form size is null");
            }
            set
            {
                if (value != null)
                {
                    _textFieldSize = value;
                }
                else
                {
                    throw new ArgumentNullException("Value is null");
                }
            }
        }
        public static Size ModuleFormSize
        {
            get
            {
                if (_moduleFormSize != null)
                {
                    return _moduleFormSize;
                }

                throw new ArgumentNullException("Default module form size is null");
            }
            set
            {
                if (value != null)
                {
                    _moduleFormSize = value;
                }
                else
                {
                    throw new ArgumentNullException("Value is null");
                }
            }
        }

        //public static int DefaultFormWidth
        //{
        //    get
        //    {
        //        return _defaultFormWidth;
        //    }
        //    private set
        //    {
        //        _defaultFormWidth = value >= 0 ? value : 0;
        //    }
        //}
        //public static int DefaultFormHeight
        //{
        //    get
        //    {
        //        return _defaultFormHeight;
        //    }
        //    private set
        //    {
        //        _defaultFormHeight = value >= 0 ? value : 0;
        //    }
        //}
    }
}
