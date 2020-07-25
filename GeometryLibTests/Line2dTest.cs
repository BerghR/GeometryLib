using GeometryLib.Classes;
using NUnit.Framework;
using System;

namespace GeometryLibTests
{

    [TestFixture]
    class Line2dTest
    {

        [Test]
        public void Line2dCreation()
        {
            var start = new Point2d(0, 10);
            var end = new Point2d(100, 200);

            var line = new Line2d(start, end);

            Assert.AreEqual(0, line.Start.X);
            Assert.AreEqual(10, line.Start.Y);
            Assert.AreEqual(100, line.End.X);
            Assert.AreEqual(200, line.End.Y);

        }

        [Test]
        public void Line2dIntersectWith()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Line2dLength()
        {
            throw new NotImplementedException();
        }
    }
}
