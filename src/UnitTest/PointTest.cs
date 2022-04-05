using FluentAssertions;
using NUnit.Framework;


namespace MarsRovers.UnitTest
{
     class PointTest
    {
        [Test]
        public void PointShouldBeSame()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 2);
            Assert.AreEqual(p1, p2);
        }

    }
}
