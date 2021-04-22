using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms.Modules
{
    class FieldModule : AbstactModule
    {
        public FieldModule()
        {
            StringFormat = Default.Text.FieldStringFormat;
        }
        public FieldModule(ModuleType type,string defaultText, StringFormat stringFormat) : base(type,defaultText, stringFormat)
        {
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is FieldModule)
            {
                FieldModule module = (FieldModule)obj;
                if (Location == module.Location && TextFields.Count == module.TextFields.Count)
                {
                    result = true;
                }
            }
            
            return result;
        }
    }
}
