using DevelopmentChallenge.Data.Classes.Refactor.Language;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class GeometricShapesListPrinterSpanish : GeometricShapesListPrinter
    {
        public GeometricShapesListPrinterSpanish() : base(new SpanishLanguageHelper())
        {

        }
    }
}
