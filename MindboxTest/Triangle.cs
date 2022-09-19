using System;
using MindboxTest.Abstractions;
using MindboxTest.Interfaces;

namespace MindboxTest
{
    public class Triangle : Figure, IHasArea
    {
        public double[] Sides { get; }

        public Triangle(double[] sides)
        {
            ValidateSides(sides);

            Sides = sides;
        }

        private void ValidateSides(double[] sides)
        {
            if (sides == null)
            {
                throw new ArgumentNullException(nameof(sides));
            }
            if (sides.Length != 3)
            {
                throw new ArgumentException("Массив длин сторон должен состоять из 3-ех элементов", nameof(sides));
            }
            foreach (var side in sides)
            {
                if (side <= 0)
                {
                    throw new ArgumentException("Длины сторон треугольника должны быть больше нуля", nameof(sides));
                }
            }
        }

        public double GetArea()
        {
            var semiperimeter = 0.0;

            for (var i = 0; i < Sides.Length; i++)
            {
                semiperimeter += Sides[i] / 2;
            }

            var area = Math.Sqrt(semiperimeter * (semiperimeter - Sides[0]) * (semiperimeter - Sides[1]) * (semiperimeter - Sides[2]));
            return area;
        }
    }
}
