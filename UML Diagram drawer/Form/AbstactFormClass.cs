using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram_drawer.Form
{
    class AbstactFormClass : ISelectable
    {
        ContactPoint[] ContactPoints;

        public bool IsSelected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Pen Pen { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsMove { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Graphics Graphics { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point StartMovePoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Rectangle[] Rectangles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Point[] Points { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CreateRectangles()
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            throw new NotImplementedException();
        }

        public void Move(int deltaX, int deltaY)
        {
            throw new NotImplementedException();
        }

        public void RemoveSelect()
        {
            throw new NotImplementedException();
        }

        public void Select(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
