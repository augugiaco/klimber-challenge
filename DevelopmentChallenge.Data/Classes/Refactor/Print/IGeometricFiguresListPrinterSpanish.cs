using DevelopmentChallenge.Data.Classes.Refactor.Language;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class GeometricFiguresListPrinterSpanish : GeometricFiguresListPrinter
    {
        public GeometricFiguresListPrinterSpanish() : base(new SpanishLanguageHelper())
        {

        }
    }
}
