﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Forms
{
    public class Form : AbstractForm
    {
        public Form(FormType type, bool createFields, bool createMethods, string titleText) : base(type, createFields, createMethods, titleText) { }

        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is Form)
            {
                Form form = (Form)obj;
                if (Type == form.Type && Location == form.Location && _modules == form._modules)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
