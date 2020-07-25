using GeometryLib.Classes;
using NUnit.Framework;

namespace GeometryLibTests
{
    [TestFixture]
    class Point2dTest
    {
        [Test]
        public void PointCreation()
        {
            var point = new Point2d(0, 0);

            Assert.AreEqual(0, point.X);
            Assert.AreEqual(0, point.Y);

            point = new Point2d();

            Assert.AreEqual(double.NaN, point.X);
            Assert.AreEqual(double.NaN, point.Y);
        }
    }
}
