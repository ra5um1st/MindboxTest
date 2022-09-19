using System;
using Xunit;

namespace MindboxTest.Tests
{
    public class IHasAreaTests
    {
        [Fact]
        public void Circle_GetArea_ShouldBeCorrect()
        {
            var expected = Math.PI;

            var radius = 1;
            var circle = new Circle(radius);
            var actual = circle.GetArea();

            Assert.Equal(expected, actual);
        }
    }
}
