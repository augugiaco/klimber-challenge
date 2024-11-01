using DevelopmentChallenge.Data.Classes.Refactor.Language;
using DevelopmentChallenge.Data.Classes.Refactor.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes.Refactor.Print
{
    public abstract class GeometricFiguresListPrinter
    {
        protected const string EmptySpace = " ";

        protected readonly ILanguageHelper _languageHelper;

        protected GeometricFiguresListPrinter(ILanguageHelper languageHelper)
        {
            _languageHelper = languageHelper;
        }

        public string GenerateReport(List<GeometricShape> figures) 
        {
            if (figures.Any() == false) return $"<h1>{_languageHelper.GetReportHeaderEmptyListText()}</h1>";

            StringBuilder reportContentStringBuilder = new StringBuilder();

            reportContentStringBuilder.Append($"<h1>{_languageHelper.GetReportHeaderForNonEmptyListText()}</h1>");

            BuildShapesDetailsAndFooter(figures, reportContentStringBuilder);

            return reportContentStringBuilder.ToString();
        }

        private void BuildShapesDetailsAndFooter(List<GeometricShape> shapes, StringBuilder reportContentStringBuilder)
        {
            var processedShapesByType = shapes.GroupBy(x => x.GetType()).Select(x => new
            {
                Shape = x.First(),
                Count = x.Count(),
                AreaTotal = x.Sum(d => d.CalculateArea()),
                PerimiterTotal = x.Sum(d => d.CalculatePerimiter())
            })
            .ToList();

            processedShapesByType.ForEach(x =>
            {
                var shapeText = GetShapeText(x.Shape, x.Count > 1);

                reportContentStringBuilder.Append(
                $"{x.Count} {shapeText} | " +
                $"{_languageHelper.GetAreaText()} {x.AreaTotal:#.##} | " +
                $"{_languageHelper.GetPerimeterText()} {x.PerimiterTotal:#.##} <br/>");
            });

            reportContentStringBuilder.Append("TOTAL:<br/>");

            var totalShapesCount = processedShapesByType.Sum(x => x.Count);
            reportContentStringBuilder.Append(totalShapesCount + EmptySpace + _languageHelper.GetShapesPluralText() + " ");

            var totalShapesPerimiters = processedShapesByType.Sum(x => x.PerimiterTotal);
            reportContentStringBuilder.Append($"{_languageHelper.GetPerimeterText() + EmptySpace}" + totalShapesPerimiters.ToString("#.##") + EmptySpace);

            var totalShapesAreas = processedShapesByType.Sum(x => x.AreaTotal);
            reportContentStringBuilder.Append($"{_languageHelper.GetAreaText() + EmptySpace}" + totalShapesAreas.ToString("#.##"));
        }

        private string GetShapeText(GeometricShape shape, bool shouldBePluralized) 
        {
            var result = string.Empty;

            switch (shape)
            {
                case Circle circle:
                    result = _languageHelper.GetCircleText();
                    break;
                case EquilateralTriangle triangle:
                    result = _languageHelper.GetTriangleText();
                    break;
                case Square square:
                    result = _languageHelper.GetSquareText();
                    break;
                case Rectangle rectangle:
                    result = _languageHelper.GetRectangleText();
                    break;
                default:
                    throw new NotImplementedException();
            }

            if (shouldBePluralized)
                result += "s";

            return result;
        }
    }
}
