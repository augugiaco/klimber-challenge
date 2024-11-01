using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public abstract class IGeometricShapesListPrinterCreator
    {
        protected readonly List<GeometricShape> _figuresList;

        public abstract GeometricShapesListPrinter Create();

        public string GetReportContent(List<GeometricShape> shapes) 
        {
            GeometricShapesListPrinter printer = Create();

            return printer.GenerateReport(shapes);
        }
    }
}
