using DevelopmentChallenge.Data.Classes.Refactor.Language;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class GeometricFiguresListPrinterItalian : GeometricShapesListPrinter
    {
        public GeometricFiguresListPrinterItalian() : base(new ItalianLanguageHelper())
        {

        }
    }
}
