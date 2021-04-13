using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    public static class Default
    {
        public static class Draw
        {
            private static int _penWidth = 5;
            private static Color _color = Color.Black;

            public static Pen Pen = new Pen(_color, _penWidth);
        }

        public static class Text
        {
            public static StringFormat TitleStringFormat = new StringFormat();
            public static Font Font = new Font("Arial", 14);
        }

        public static class Size
        {
            private static int _defaultFormWidth = 200;
            private static int _defaultFormHeight = 50;
            private static int _defaultModuleFormHeight = 50;

            public static System.Drawing.Size FormSize = new System.Drawing.Size(_defaultFormWidth, _defaultFormHeight);
            public static System.Drawing.Size TextFieldSize = new System.Drawing.Size(_defaultFormWidth, _defaultModuleFormHeight);
            public static System.Drawing.Size ModuleFormSize = new System.Drawing.Size(_defaultFormWidth, _defaultModuleFormHeight);
        }
    }
}
