namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class ConcreteGeometricReportFiguresEnglish : IGeometricFiguresListPrinterCreator
    {
        public override GeometricFiguresListPrinter Create()
        {
            return new GeometricFiguresListPrinterEnglish();
        }
    }
}
