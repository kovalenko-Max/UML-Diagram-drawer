using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Diagram_drawer.Forms;

namespace UML_Diagram_drawer.Factory
{
    public class InterfaceFormFactory : IFormsFactory
    {
        public AbstractForm GetForm()
        {
            return new Form(FormType.Interfase, createFields: true, createMethods: true, Default.Text.TitleInterfaceText);
        }
    }
}
