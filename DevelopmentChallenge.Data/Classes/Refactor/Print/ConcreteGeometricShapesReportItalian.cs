namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public sealed class ConcreteGeometricShapesReportItalian : IGeometricShapesListPrinterCreator
    {
        public override GeometricShapesListPrinter Create()
        {
            return new GeometricFiguresListPrinterItalian();
        }
    }
}
