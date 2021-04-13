using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    class ClassNameModuleForm : AbstractModuleFormV1
    {
        public ClassNameModuleForm()
        {
            StringFormat = new StringFormat();
            StringFormat.Alignment = StringAlignment.Center;
            StringFormat.LineAlignment = StringAlignment.Center;
            DefaultText = "ClassName";
        }
    }
}
