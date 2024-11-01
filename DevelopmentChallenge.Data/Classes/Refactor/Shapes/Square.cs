namespace DevelopmentChallenge.Data.Classes.Refactor
{
    public sealed class Square : GeometricShape
    {
        public Square(decimal size) : base(size) { }
        public override decimal CalculateArea() => _height * _height;

        public override decimal CalculatePerimiter() => _height * 4;
    }
}
