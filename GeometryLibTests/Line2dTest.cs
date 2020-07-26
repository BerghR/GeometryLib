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
        public void Line2dIntersectActual()
        {
            var line1 = new Line2d(new Point2d(0, 0), new Point2d(100, 100));
            var line2 = new Line2d(new Point2d(0, 100), new Point2d(100, 0));

            var intersectionPoint = line1.IntersectWith(line2);

            Assert.AreEqual(50, intersectionPoint.X);
            Assert.AreEqual(50, intersectionPoint.Y);
        }

        [Test]
        public void Line2dIntersectProjected()
        {
            var line1 = new Line2d(new Point2d(0, 0), new Point2d(49, 49));
            var line2 = new Line2d(new Point2d(0, 100), new Point2d(100, 0));

            var intersectionPoint = line1.IntersectWith(line2, false);

            Assert.AreEqual(50, intersectionPoint.X);
            Assert.AreEqual(50, intersectionPoint.Y);

            intersectionPoint = line1.IntersectWith(line2, true);

            Assert.AreEqual(double.NaN, intersectionPoint.X);
            Assert.AreEqual(double.NaN, intersectionPoint.Y);
        }

        [Test]
        public void Line2dLength()
        {
            var line1 = new Line2d(new Point2d(0, 0), new Point2d(0, 100));
            var line2 = new Line2d(new Point2d(0, 0), new Point2d(100, 100));

            double line1Length = line1.Length();
            double line2Length = line2.Length();

            Assert.AreEqual(100, line1Length);
            Assert.AreEqual(141.42135623, Math.Truncate(100000000 * line2Length) / 100000000);

        }

        [Test]
        public void AngleOfLine()
        {
            var line1 = new Line2d(new Point2d(0, 0), new Point2d(100, 0));
            var angle = line1.Angle;

            Assert.AreEqual(90, angle);

            var line2 = new Line2d(new Point2d(0, 0), new Point2d(100, 100));
            angle = line2.Angle;

            Assert.AreEqual(45, angle);

            var line3 = new Line2d(new Point2d(0, 0), new Point2d(0, 100));
            angle = line3.Angle;

            Assert.AreEqual(0, angle);

            var line4 = new Line2d(new Point2d(0, 0), new Point2d(-100, 100));
            angle = line4.Angle;

            Assert.AreEqual(315, angle);

            var line5 = new Line2d(new Point2d(0, 0), new Point2d(-100, 0));
            angle = line5.Angle;

            Assert.AreEqual(270, angle);

            var line6 = new Line2d(new Point2d(0, 0), new Point2d(-100, -100));
            angle = line6.Angle;

            Assert.AreEqual(225, angle);

            var line7 = new Line2d(new Point2d(0, 0), new Point2d(0, -100));
            angle = line7.Angle;

            Assert.AreEqual(180, angle);

        }


        [Test]
        public void IsPointOnLine()
        {
            var line1 = new Line2d(new Point2d(0, 0), new Point2d(100, 100));
            var result = line1.IsPointOnLine(new Point2d(50, 50));
            Assert.True(result);

            var result2 = line1.IsPointOnLine(new Point2d(120, 120));

            Assert.False(result2);

        }
    }
}
