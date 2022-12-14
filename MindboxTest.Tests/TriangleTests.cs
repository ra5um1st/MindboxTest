using System;
using Xunit;

namespace MindboxTest.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void TriangleCtor_ShouldInitialize()
        {
            var sides = new double[] { 5, 5, 5 };
            var figure = new Triangle(sides);

            Assert.Equal(sides, figure.Sides);
        }

        [Fact]
        public void Triangle_IsRightAngled_ShouldReturnTrue()
        {
            var sides = new double[] { 26, 10, 24 };
            var figure = new Triangle(sides);

            Assert.True(figure.IsRightAngled());
        }

        [Fact]
        public void Triangle_IsRightAngled_ShouldReturnFalse()
        {
            var sides = new double[] { 26, 10, 25 };
            var figure = new Triangle(sides);

            Assert.False(figure.IsRightAngled());
        }

        [Fact]
        public void TriangleCtor_ShouldThrowEx_PassNullArray()
        {
            Assert.Throws<ArgumentNullException>(() => new Triangle(null));
        }

        [Fact]
        public void TriangleCtor_ShouldThrowEx_PassEmptyArray()
        {
            var sides = Array.Empty<double>();

            Assert.Throws<ArgumentException>(() => new Triangle(sides));
        }

        [Fact]
        public void TriangleCtor_ShouldThrowEx_PassFiveSides()
        {
            var sides = new double[] { 1, 2, 3, 4, 5 };

            Assert.Throws<ArgumentException>(() => new Triangle(sides));
        }

        [Fact]
        public void TriangleCtor_ShouldThrowEx_PassNegativeSide()
        {
            var sides = new double[] { -5, 5, 5 };

            Assert.Throws<ArgumentException>(() => new Triangle(sides));
        }
    }
}
