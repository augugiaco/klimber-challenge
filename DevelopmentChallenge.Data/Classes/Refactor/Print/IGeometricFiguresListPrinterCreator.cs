using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public abstract class IGeometricFiguresListPrinterCreator
    {
        protected readonly List<GeometricShape> _figuresList;

        public abstract GeometricFiguresListPrinter Create();

        public string GetReportContent(List<GeometricShape> figures) 
        {
            GeometricFiguresListPrinter printer = Create();

            return printer.GenerateReport(figures);
        }
    }
}
