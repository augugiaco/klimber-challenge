using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Refactor;
using DevelopmentChallenge.Data.Classes.Refactor.Print;
using DevelopmentChallenge.Data.Classes.Refactor.Shapes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void GetReportContent_WhenListIsEmptyInSpanish_ShouldReturnEmptyTextInSpanish()
        {
            //Arrange
            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Spanish);

            //Act & Assert
            Assert.That("<h1>Lista vacía de formas!</h1>" ==
                reportGenerator.GetReportContent(new List<GeometricShape>()));
        }

        [TestCase]
        public void GetReportContent_WhenListIsEmptyInEnglish_ShouldReturnEmptyTextInEnglish()
        {
            //Arrange
            var reportGenerator = GetCreatorByLanguage(LanguageEnum.English);

            //Act & Assert
            Assert.That("<h1>Empty list of shapes!</h1>" ==
                reportGenerator.GetReportContent(new List<GeometricShape>()));
        }

        [TestCase]
        public void GetReportContent_WhenListHasOnlyOneSquareInSpanish_ShouldReturnOneSquareDetailsInSpanish()
        {
            //Arrange
            var shapes = new List<GeometricShape> { new Square(5) };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Spanish);

            //Act
            var resumen = reportGenerator.GetReportContent(shapes);

            //Assert
            Assert.That("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25" == resumen);
        }

        [TestCase]
        public void GetReportContent_WhenListHasMoreSquaresInEnglish_ShouldReturnFullReportInEnglish()
        {
            //Arrange
            var cuadrados = new List<GeometricShape>
            {
                new Square(5),
                new Square(1),
                new Square(3),
            };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.English);

            //Act
            var reportContent = reportGenerator.GetReportContent(cuadrados);

            //Assert
            Assert.That("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35" == reportContent);
        }

        [TestCase]
        public void GetReportContent_WhenListHasMoreTypesInEnglish_ShouldReturnFullReportInEnglish()
        {
            //Arrange
            var formas = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.English);

            //Act
            var reportContent = reportGenerator.GetReportContent(formas);

            //Assert
            Assert.That(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 " +
                "<br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65" ==
                reportContent);
        }

        [TestCase]
        public void GetReportContent_WhenListHasMoreTypesInSpanish_ShouldReturnFullReportInSpanish()
        {
            //Arrange
            var shapes = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Spanish);

            //Act
            var reportcontent = reportGenerator.GetReportContent(shapes);

            //Assert
            Assert.That(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>" +
                "3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65" ==
                reportcontent);
        }

        [TestCase]
        public void GetReportContent_WhenIsEmptyListInItalian_ShouldReturnItalianEmptyText()
        {
            //Arrange
            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Italian);

            //Act & Assert
            Assert.That("<h1>Elenco vuoto di forme!</h1>" ==
                reportGenerator.GetReportContent(new List<GeometricShape>()));
        }

        [TestCase]
        public void GetReportContent_WhenTheListHasRectangles_ShouldReturnTheRectanglesDetails()
        {
            var formas = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m),
                new Rectangle(4, 2),
                new Rectangle(5.5m, 2.2m)
            };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Spanish);

            var resumen = reportGenerator.GetReportContent(formas);

            Assert.That(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>" +
                "3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Rectángulos | Area 20,1 | Perimetro 27,4 <br/>TOTAL:<br/>9 formas Perimetro 125,06 Area 111,75" ==
                resumen);
        }

        [TestCase]
        public void GetReportContent_WhenTheListHasAllShapesAndItalianLanguage_ShouldReturnFullDetailsInItalian()
        {
            var formas = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m),
                new Rectangle(4, 2),
                new Rectangle(5.5m, 2.2m)
            };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Italian);

            var resumen = reportGenerator.GetReportContent(formas);

            Assert.That(
                "<h1>Rapporto sui Moduli</h1>2 Piazzas | Zona 29 | Perimetro 28 <br/>2 Cerchios | Zona 13,01 | Perimetro 18,06 <br/>" +
                "3 Triangolos | Zona 49,64 | Perimetro 51,6 <br/>2 Rettangolos | Zona 20,1 | Perimetro 27,4 <br/>TOTAL:<br/>9 formas Perimetro 125,06 Zona 111,75" ==
                resumen);
        }

        [TestCase]
        public void GetReportContent_WhenTheListHasOnlyOneShapePerTypeAndItalianLanguage_ShouldReturnFullDetailsInItalian()
        {
            var formas = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Rectangle(5.5m, 2.2m)
            };

            var reportGenerator = GetCreatorByLanguage(LanguageEnum.Italian);

            var resumen = reportGenerator.GetReportContent(formas);

            Assert.That(
                "<h1>Rapporto sui Moduli</h1>1 Piazza | Zona 25 | Perimetro 20 <br/>1 Cerchio | Zona 7,07 | Perimetro 9,42 <br/>" +
                "1 Triangolo | Zona 6,93 | Perimetro 12 <br/>1 Rettangolo | Zona 12,1 | Perimetro 15,4 <br/>TOTAL:<br/>4 formas Perimetro 56,82 Zona 51,1" ==
                resumen);
        }

        #region Auxiliary Methods

        private IGeometricFiguresListPrinterCreator GetCreatorByLanguage(LanguageEnum language)
        {
            switch (language)
            {
                case LanguageEnum.Spanish:
                    return new ConcreteGeometricReportFiguresSpanish();
                case LanguageEnum.English:
                    return new ConcreteGeometricReportFiguresEnglish();
                case LanguageEnum.Italian:
                    return new ConcreteGeometricReportFiguresItalian();
                default:
                    throw new NotImplementedException();
            }
        }

        #endregion
    }

}


