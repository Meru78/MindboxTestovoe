using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetCircleArea_Radius6()
        {
            double expected = 113.09733552923255;
            double radius = 6;

            var circle = new Figures.Circle(radius);

            double result = circle.Get—ircleArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCircleArea_Radius2()
        {
            double expected = 12.566370614359172;
            double radius = 2;

            var circle = new Figures.Circle(radius);

            double result = circle.Get—ircleArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCircleArea_Radius1_05()
        {
            double expected = 3.463605900582747;
            double radius = 1.05;

            var circle = new Figures.Circle(radius);

            double result = circle.Get—ircleArea();

            Assert.AreEqual(expected, result);
        }
    }
}
