namespace DevelopmentChallenge.Data.Classes.Refactor
{
    public abstract class GeometricShape
    {
        public abstract decimal CalculateArea();

        public abstract decimal CalculatePerimiter();

        protected readonly decimal _height;

        protected readonly decimal _width;

        protected GeometricShape(decimal height)
        {
            _height = height;
        }

        protected GeometricShape(decimal height, decimal width)
        {
            _height = height;
            _width = width;
        }
    }
}
