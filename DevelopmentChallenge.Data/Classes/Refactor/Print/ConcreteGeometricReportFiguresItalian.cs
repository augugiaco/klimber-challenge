namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public class ConcreteGeometricReportFiguresItalian : IGeometricFiguresListPrinterCreator
    {
        public override GeometricFiguresListPrinter Create()
        {
            return new GeometricFiguresListPrinterItalian();
        }
    }
}
