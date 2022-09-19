using System;
using MindboxTest.Abstractions;
using MindboxTest.Interfaces;

namespace MindboxTest
{
    public class Circle : Figure, IHasArea
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус окружности должен быть больше нуля", nameof(radius));
            }
            
            Radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
