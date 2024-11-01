using DevelopmentChallenge.Data.Classes.Refactor;
using DevelopmentChallenge.Data.Classes.Refactor.Shapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.Shapes
{
    [TestFixture]
    public class GeometricShapeTests
    {
        [TestCase]
        public void Constructor_WhenHeightIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { var shape = new Circle(-5m); });
        }

        [TestCase]
        public void Constructor_WhenWidthIsNegative_ShouldThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { var shape = new Rectangle(5, -2m); });
        }

        [TestCase]
        public void Constructor_WhenHeightIsPositive_ShouldNotThrowException()
        {

            Assert.DoesNotThrow(() => { var shape = new Circle(5m); });
        }

        [TestCase]
        public void Constructor_WhenHeightIsPositive_ShouldCreateInstanceWithValues()
        {
            var shape = new Circle(5m);

            Assert.That(shape, Is.Not.Null);
            Assert.That(shape.Height == 5m);
        }

        [TestCase]
        public void Constructor_WhenWidthIsPositive_ShouldCreateInstanceWithValues()
        {
            var shape = new Rectangle(5m, 10m);

            Assert.That(shape, Is.Not.Null);
            Assert.That(shape.Height == 5m);
            Assert.That(shape.Width == 10m);
        }

        [TestCaseSource("ShapesWithCalculatedAreas")]
        public void CalculateArea_WhenIsCalledWithValidValues_ShouldReturnTheCalculatedArea(GeometricShape shape, decimal expectedValue)
        {
            Assert.That(Math.Round(shape.CalculateArea(),2) == expectedValue);
        }

        [TestCaseSource("ShapesWithCalculatedPerimeters")]
        public void CalculatePerimiter_WhenIsCalledWithValidValues_ShouldReturnTheCalculatedPerimeter(GeometricShape shape, decimal expectedValue)
        {
            Assert.That(Math.Round(shape.CalculatePerimiter(), 2) == expectedValue);
        }

        public static IEnumerable<TestCaseData> ShapesWithCalculatedAreas
        {
            get
            {
                yield return new TestCaseData(new Square(5m), 25m);
                yield return new TestCaseData(new Circle(3), 7.07m);
                yield return new TestCaseData(new Rectangle(5.5m, 2.2m), 12.1m);
                yield return new TestCaseData(new EquilateralTriangle(4m), 6.93m);
            }
        }

        public static IEnumerable<TestCaseData> ShapesWithCalculatedPerimeters
        {
            get
            {
                yield return new TestCaseData(new Square(5m), 20m);
                yield return new TestCaseData(new Circle(3m), 9.42m);
                yield return new TestCaseData(new Rectangle(5.5m, 2.2m), 15.4m);
                yield return new TestCaseData(new EquilateralTriangle(4m), 12m);
            }
        }
    }
}
