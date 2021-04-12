using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    class MethodsModuleForm :AbstractModuleForm
    {
        public MethodsModuleForm()
        {
            StringFormat = new StringFormat();
            StringFormat.LineAlignment = StringAlignment.Center;
            DefaultText = " + method() ";
        }
    }
}
