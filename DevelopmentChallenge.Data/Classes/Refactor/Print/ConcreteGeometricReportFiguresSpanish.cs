namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class ConcreteGeometricReportFiguresSpanish : IGeometricFiguresListPrinterCreator
    {
        public override GeometricFiguresListPrinter Create()
        {
            return new GeometricFiguresListPrinterSpanish();
        }
    }
}
