using DevelopmentChallenge.Data.Classes.Refactor.Language;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class GeometricFiguresListPrinterEnglish : GeometricShapesListPrinter
    {
        public GeometricFiguresListPrinterEnglish():base(new EnglishLanguageHelper())
        {
                
        }
    }
}
