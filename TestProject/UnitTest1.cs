using NUnit.Framework;
using System.Collections;
using UML_Diagram_drawer.Forms;
using System.Drawing;
using UML_Diagram_drawer.Factory;
using UML_Diagram_drawer;
using UML_Diagram_drawer.Forms.Modules;

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

        [TestCaseSource(typeof(IsContactArrow))]
        public void ContactArrow_WhenPointNotNull_ShouldReturnContactPoint(Form form, Point point, ContactPoint expected)
        {
            ContactPoint actual = form.ConnectArrow(point);
            Assert.AreEqual(expected, actual);
        }

        public class IsItSelected : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(50,50),
                    true
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(150,99),
                    true
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(199,99),
                    true
                };
            }
        }

        public class IsContactArrow : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(100,50),
                    new ContactPoint(new Point(0,0))
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(50,99),
                    new ContactPoint(new Point(0,0))
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(202,100),
                    new ContactPoint(new Point(0,0))
                };
            }
        }

        [TestCaseSource(typeof(IsItMove))]
        public void Move_WhenPointNotNull_ShouldLocation(Form form, int deltaX, int deltaY, Point expected)
        {
            form.Move(deltaX, deltaY);
            Point actual =  form.Location;
            Assert.AreEqual(expected, actual);
        }

        public class IsItMove : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    (int)50,
                    (int)50,
                    new Point(50,50)
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    (int)150,
                    (int)99,
                    new Point(150,99)
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    (int)199,
                    (int)99,
                    new Point(199,99)
                };
            }
        }

        [TestCaseSource(typeof(IsRemoveSelect))]
        public void RemoveSelect_WhenPointNotNulln(Form form, Pen expected)
        {
            form.RemoveSelect();
            Pen actual = form.Pen;
            Assert.AreEqual(expected, actual);
        }

        public class IsRemoveSelect : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    Default.Draw.Pen
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    Default.Draw.Pen
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    Default.Draw.Pen
                };
            }
        }

        [TestCaseSource(typeof(IsContains))]
        public void Contains_WhenPointNotNulln_ShouldReturnBool(Form form, Point point, bool expected)
        {
            bool actual = form.Contains(point);
            Assert.AreEqual(expected, actual);
        }

        public class IsContains : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(50,50),
                    true
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(100,50),
                    true
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    new Point(200,99),
                    false
                };
            }
        }

        //[TestCaseSource(typeof(IsAddTextField))]
        //public void AddTextField_WhenStringTextTypeType(Form form, string text, ModuleType type, TextField expected)
        //{
        //    form.AddTextField(text, type);
        //    TextField acual = Text.FieldText;
        //    Assert.AreEqual(expected, actual);
        //}

        //public class IsAddTextField : IEnumerable
        //{
        //    public IEnumerator GetEnumerator()
        //    {
        //        yield return new object[]{
        //            new ClassFormFactory().GetForm(),
        //            new Point(50,50),
        //            true
        //        };
        //        yield return new object[]{
        //            new ClassFormFactory().GetForm(),
        //            new Point(100,50),
        //            true
        //        };
        //        yield return new object[]{
        //            new ClassFormFactory().GetForm(),
        //            new Point(200,99),
        //            false
        //        };
        //    }
        //}

        [TestCaseSource(typeof(IsToString))]
        public void IsItToString(Form form, string expected)
        {
            string actual = form.ToString();
            Assert.AreEqual(expected, actual);
        }

        public class IsToString : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    "{X=0,Y=0}"
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    "{X=0,Y=0}"
                };
                yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    "{X=0,Y=0}"
                };
            }

            [TestCaseSource(typeof(IsString))]
            public void IsItString(Form form, string expected)
            {
                string actual = form.ToString();
                Assert.AreEqual(expected, actual);
            }

            public class IsString : IEnumerable
            {
                public IEnumerator GetEnumerator()
                {
                    yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    "{X=0,Y=0}"
                };
                    yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    "{X=0,Y=0}"
                };
                    yield return new object[]{
                    new ClassFormFactory().GetForm(),
                    "{X=0,Y=0}"
                };
                }
            }
        }

    }
}