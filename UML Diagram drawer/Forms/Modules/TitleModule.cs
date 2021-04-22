using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms.Modules
{
    public class TitleModule : AbstactModule
    {
        public TitleModule()
        {
            StringFormat = Default.Text.TitleStringFormat;
        }
        public TitleModule(ModuleType type, string defaultText, StringFormat stringFormat) : base(type, defaultText, stringFormat)
        {
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is TitleModule)
            {
                TitleModule module = (TitleModule)obj;
                if (Location == module.Location && TextFields.Count == module.TextFields.Count)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
