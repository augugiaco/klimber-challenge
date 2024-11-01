using System;

namespace DevelopmentChallenge.Data.Classes.Refactor
{
    public abstract class GeometricShape
    {
        public abstract decimal CalculateArea();
        public abstract decimal CalculatePerimiter();

        protected readonly decimal _height;

        protected readonly decimal _width;

        public decimal Width 
        { 
            get 
            { 
                return _width; 
            } 
        }

        public decimal Height
        {
            get
            {
                return _height;
            }
        }

        protected GeometricShape(decimal height)
        {
            if(height < 0) throw new ArgumentOutOfRangeException("Height must be positive");

            _height = height;
        }

        protected GeometricShape(decimal height, decimal width):this(height)
        {
            if (width < 0) throw new ArgumentOutOfRangeException("Width must be positive");

            _width = width;
        }
    }
}
