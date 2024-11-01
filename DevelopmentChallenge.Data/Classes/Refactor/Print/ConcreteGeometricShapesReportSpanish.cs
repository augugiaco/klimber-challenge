namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public sealed class ConcreteGeometricShapesReportSpanish : IGeometricShapesListPrinterCreator
    {
        public override GeometricShapesListPrinter Create()
        {
            return new GeometricShapesListPrinterSpanish();
        }
    }
}
