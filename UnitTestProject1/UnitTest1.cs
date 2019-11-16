using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*------Circl------*/

        //Area
        [TestMethod]
        public void AreaCircl_IsTrue()
        {
            float radius = 10;
            float expect = 314.15927f;
            float actual = Calculator.AreaOfCircl(radius);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AreaCircl_IsFalse()
        {
            float radius = 2;
            float expect = 314.1593f;

            float actual = Calculator.AreaOfCircl(radius);

            Assert.AreNotEqual(expect, actual);
        }

        //Perimetr
        [TestMethod]
        public void PerimetrOfCircl_IsTrue()
        {
            float radius = 10;
            float expect = 62.831856f;
            float actual = Calculator.PerimeterOfCircl(radius);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PerimetrOfCircl_IsFalse()
        {
            float radius = 2;
            float expect = 62.831856f;
            float actual = Calculator.PerimeterOfCircl(radius);

            Assert.AreNotEqual(expect, actual);
        }

        /*------Triangle------*/

        //Area
        [TestMethod]
        public void AreaTriangle_IsTrue()
        {
            float a = 3f, b = 4f, c = 5f;
            float expect = 6f;

            float actual = Calculator.AreaOfTriangle(a, b, c);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AreaTriangle_IsFalse()
        {
            float a = 3f, b = 4f, c = 5f;
            float expect = 1f;

            float actual = Calculator.AreaOfTriangle(a, b, c);

            Assert.AreNotEqual(expect, actual);
        }

        //Perimetr
        [TestMethod]
        public void PerimetrOfTriangle_IsTrue()
        {
            float a = 3f, b = 4f, c = 5f;
            float expect = 12f;

            float actual = Calculator.PerimetrOfTriangle(a, b, c);

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void PerimetrOfTriangle_IsFalse()
        {
            float a = 3f, b = 4f, c = 5f;
            float expect = 1f;

            float actual = Calculator.PerimetrOfTriangle(a, b, c);

            Assert.AreNotEqual(expect, actual);
        }

        //IsRectangular
        [TestMethod]
        public void TriangleIsRectangular_IsTrue()
        {
            float a = 3f, b = 4f, c = 5f;

            bool actual = Calculator.TriangleIsRectangular(a, b, c);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TriangleIsRectangular_IsFalse()
        {
            float a = 3f, b = 3f, c = 3f;

            bool actual = Calculator.TriangleIsRectangular(a, b, c);

            Assert.IsFalse(actual);
        }

        //IsEquilateral
        public void TriangleIsEquilateral_IsTrue()
        {
            float a = 3f, b = 3f, c = 3f;

            bool actual = Calculator.TriangleIsEquilateral(a, b, c);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TriangleIsEquilateral_IsFalse()
        {
            float a = 3f, b = 3f, c = 2f;

            bool actual = Calculator.TriangleIsEquilateral(a, b, c);

            Assert.IsFalse(actual);
        }

        //Exeption
        [TestMethod]
        public void IsExeption()
        {
            float a = 10, b = 123, c = 1;

            try
            {
                Calculator.AreaOfTriangle(a, b, c);
            }
            catch(Exception ex)
            {
                Assert.IsNotNull(ex);
            }

            
        }

    }
}
