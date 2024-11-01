using DevelopmentChallenge.Data.Classes.Refactor.Language;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class GeometricFiguresListPrinterEnglish : GeometricFiguresListPrinter
    {
        public GeometricFiguresListPrinterEnglish():base(new EnglishLanguageHelper())
        {
                
        }
    }
}
