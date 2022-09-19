using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MindboxTest.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CircleCtor_ShouldInitialize()
        {
            var radius = 1;
            var figure = new Circle(radius);

            Assert.Equal(radius, figure.Radius);
        }

        [Fact]
        public void CircleCtor_ShouldThrowEx_NullNumber()
        {
            var radius = 0;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void CircleCtor_ShouldThrowEx_NegativeNumber()
        {
            var radius = -1;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
