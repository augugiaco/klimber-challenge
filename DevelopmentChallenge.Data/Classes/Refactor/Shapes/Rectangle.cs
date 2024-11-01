namespace DevelopmentChallenge.Data.Classes.Refactor.Shapes
{
    public sealed class Rectangle : GeometricShape
    {
        public Rectangle(decimal height, decimal width):base(height, width)
        {
                
        }

        public override decimal CalculateArea()
        {
            return _width * _height;
        }

        public override decimal CalculatePerimiter()
        {
            return (2 * _height) + (2 * _width);
        }
    }
}
