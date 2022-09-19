using System;
using MindboxTest.Interfaces;
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
            IHasArea figure = new Circle(radius);
            var actual = figure.GetArea();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Triangle_GetArea_ShouldBeCorrect()
        {
            var expected = 10.83;

            var sides = new double[] { 5, 5, 5 };
            IHasArea figure = new Triangle(sides);
            var actual = Math.Round(figure.GetArea(), 2);

            Assert.Equal(expected, actual);
        }
    }
}
