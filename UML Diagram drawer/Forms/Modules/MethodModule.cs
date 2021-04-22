using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms.Modules
{
    class MethodModule : AbstactModule
    {
        public MethodModule()
        {
            StringFormat = Default.Text.MethodStringFormat;
        }

        public MethodModule(ModuleType type, string defaultText, StringFormat stringFormat) : base(type, defaultText, stringFormat)
        {
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is MethodModule)
            {
                MethodModule module = (MethodModule)obj;
                if (Location == module.Location && TextFields.Count == module.TextFields.Count)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
