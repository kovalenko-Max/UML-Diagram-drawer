using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer
{
    public static class MainGraphics
    {
        private static Graphics _graphics;
        public static Graphics Graphics
        {
            get
            {
                if (_graphics != null)
                {
                    return _graphics;
                }

                throw new ArgumentNullException("Graphics is null");
            }
            set
            {
                if(value != null)
                {
                    _graphics = value;
                }
                else
                {
                    throw new ArgumentNullException("Value is null");
                }
            }
        }
    }
}
