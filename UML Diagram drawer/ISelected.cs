﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram_drawer
{
    public interface ISelected
    {
        bool IsSelected { get; set; }
        Pen Pen { get; set; }
        Graphics Graphics { get; set; }
        void Draw();

        bool Select(Point point);
        void RemoveSelect();
    }
}
