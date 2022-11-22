using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetTriangleArea()
        {
            double expected = 4.873980757692577;
            double x = 6.1;
            double y = 2;
            double z = 5.1515;

            var circle = new Figures.Triangle(x, y, z);

            double result = circle.GetTriangleArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckIsTriangleNOTRectangular()
        {
            bool expected = false;
            double x = 7;
            double y = 14;
            double z = 7;

            var circle = new Figures.Triangle(x, y, z);

            bool result = circle.IsTriangleRectangular();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckIsTriangleRectangular()
        {
            bool expected = true;
            double x = 1;
            double y = 1;
            double z = 1.4142135623730951;

            var circle = new Figures.Triangle(x, y, z);

            bool result = circle.IsTriangleRectangular();

            Assert.AreEqual(expected, result);
        }
    }
}
