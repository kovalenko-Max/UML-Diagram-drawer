using NUnit.Framework;
using System.Collections;
using UML_Diagram_drawer.Forms;
using System.Drawing;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(typeof(IsItSelected))]
        public void Selected_WhenPointNotNull_ShouldReturnBool(Form form, Point point, bool expected)
        {
            bool actual = form.Select(point);
            Assert.AreEqual(expected, actual);
        }

        public class IsItSelected : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new UML_Diagram_drawer.Forms.Form() {Location = new Point(0,0) },
                    new Point(50,50),
                    true
                };
            }
        }

            
    }
}