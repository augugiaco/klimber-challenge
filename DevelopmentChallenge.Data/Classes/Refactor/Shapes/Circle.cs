using System;

namespace DevelopmentChallenge.Data.Classes.Refactor
{
    public sealed class Circle : GeometricShape
    {
        public Circle(decimal size) : base(size) { }
        public override decimal CalculateArea() => (decimal)Math.PI * (_height / 2) * (_height / 2);

        public override decimal CalculatePerimiter() => (decimal)Math.PI * _height;
    }
}
