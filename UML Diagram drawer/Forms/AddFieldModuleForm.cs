using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    class AddFieldModuleForm : AbstractModuleFormV1
    {
        public AddFieldModuleForm()
        {
            StringFormat = new StringFormat();
            StringFormat.LineAlignment = StringAlignment.Center;
            StringFormat.Alignment = StringAlignment.Center;
            DefaultText = " Add field ";
        }
    }
}
