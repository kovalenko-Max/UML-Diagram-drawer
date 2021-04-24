using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Factory;

namespace UML_Diagram_drawer
{
    public static class Default
    {
        public static class Draw
        {
            private static int _penWidth = 2;
            private static int _penSelectWidth = 3;
            private static Color _color = Color.Black;
            private static Color _colorSelect = Color.Blue;
            private static Pen _penDash = new Pen(_colorSelect, _penSelectWidth);
            public static SolidBrush FillBrush = new SolidBrush(Color.Gray);
            public static Pen Pen = new Pen(_color, _penWidth);
            public static Pen PenSelect = new Pen(_colorSelect, _penSelectWidth);
            public static Pen PenDash { get
                {
                    _penDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    return _penDash;   
                }
                set
                {
                    _penDash = value;
                }
            }
        }

        public static class Text
        {
            private static StringFormat _titleStringFormat = new StringFormat();
            private static StringFormat _methodStringFormat = new StringFormat();
            private static StringFormat _fieldStringFormat = new StringFormat();
            
            public static StringFormat TitleStringFormat
            {
                get
                {
                    _titleStringFormat.Alignment = StringAlignment.Center;
                    _titleStringFormat.LineAlignment = StringAlignment.Center;
                    return _titleStringFormat;
                }
                set
                {
                    _titleStringFormat = value;
                }
            }
            public static StringFormat FieldStringFormat
            {
                get
                {
                    _fieldStringFormat.Alignment = StringAlignment.Near;
                    _fieldStringFormat.LineAlignment = StringAlignment.Center;
                    return _fieldStringFormat;
                }
                set
                {
                    _fieldStringFormat = value;
                }
            }
            public static StringFormat MethodStringFormat
            {
                get
                {
                    _methodStringFormat.Alignment = StringAlignment.Near;
                    _methodStringFormat.LineAlignment = StringAlignment.Center;
                    return _methodStringFormat;
                }
                set
                {
                    _methodStringFormat = value;
                }
            }
            public static SolidBrush Brush = new SolidBrush(Color.Black);
            public static Font Font = new Font("Arial", 14);
            public static string SomeText = "Some text";
            public static string TitleClassText = "Class Name";
            public static string TitleInterfaceText = "<interfase>\nInterfase name";
            public static string FieldText = " + field : type";
            public static string MethodText = " + method()";
        }

        public static class Size
        {
            private static int _defaultFormWidth = 200;
            private static int _defaultFormHeight = 100;
            private static int _defaultModuleFormHeight = 50;

            public static System.Drawing.Size FormSize = new System.Drawing.Size(_defaultFormWidth, _defaultFormHeight);
            public static System.Drawing.Size TextFieldSize = new System.Drawing.Size(_defaultFormWidth, _defaultModuleFormHeight);
            public static System.Drawing.Size ModuleFormSize = new System.Drawing.Size(_defaultFormWidth, _defaultModuleFormHeight);
        }

        public static class Factory
        {
            public static IFormsFactory Form = new ClassFormFactory();
        }
    }
}
