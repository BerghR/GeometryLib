using GeometryLib.Classes;
using NUnit.Framework;
using System;

namespace GeometryLibTests
{
    [TestFixture]
    class Line2dSetTest
    {
        [Test]
        public void Line2dSetCreation()
        {
            var set = new Line2dSet();

            Assert.IsNotNull(set);
            Assert.AreEqual(0, set.Count);
        }

        [Test]
        public void Line2dSetAdd()
        {
            var set = new Line2dSet();
            set.Add(new Line2d(new Point2d(0, 0), new Point2d(0, 10)));
            Assert.AreEqual(1, set.Count);
        }

        [Test]
        public void Line2dSetRemoveLine()
        {
            var set = new Line2dSet();
            var Line1 = new Line2d(new Point2d(0, 0), new Point2d(10, 10));
            var Line2 = new Line2d(new Point2d(0, 0), new Point2d(0, 10));
            set.Add(Line1);
            set.Add(Line2);
            Assert.AreEqual(2, set.Count);
            set.Remove(Line1);
            Assert.AreEqual(1, set.Count);
        }

        [Test]
        public void Line2dSetRemoveAt()
        {
            var set = new Line2dSet();
            var Line1 = new Line2d(new Point2d(0, 0), new Point2d(10, 10));
            var Line2 = new Line2d(new Point2d(0, 0), new Point2d(0, 10));
            set.Add(Line1);
            set.Add(Line2);
            Assert.AreEqual(2, set.Count);
            set.RemoveAt(1);
            Assert.AreEqual(1, set.Count);
        }

        [Test]
        public void Line2dSetRemoveAtIndexOutOfRange()
        {
            var set = new Line2dSet();
            var Line1 = new Line2d(new Point2d(0, 0), new Point2d(10, 10));
            var Line2 = new Line2d(new Point2d(0, 0), new Point2d(0, 10));
            set.Add(Line1);
            set.Add(Line2);

            Assert.Throws<IndexOutOfRangeException>(() => set.RemoveAt(3));
        }

    }
}
