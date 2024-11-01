namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public sealed class ConcreteGeometricShapesReportEnglish : IGeometricShapesListPrinterCreator
    {
        public override GeometricShapesListPrinter Create()
        {
            return new GeometricFiguresListPrinterEnglish();
        }
    }
}
