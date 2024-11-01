using System;

namespace DevelopmentChallenge.Data.Classes.Refactor
{
    public sealed class EquilateralTriangle : GeometricShape
    {
        public EquilateralTriangle(decimal size):base(size) { }

        public override decimal CalculateArea() => ((decimal)Math.Sqrt(3) / 4) * _height * _height;

        public override decimal CalculatePerimiter() => _height * 3;       
    }
}
