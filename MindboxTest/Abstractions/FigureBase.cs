using MindboxTest.Interfaces;

namespace MindboxTest.Abstractions
{
    public abstract class FigureBase : Figure, IHasArea
    {
        public abstract double GetArea();
    }
}
