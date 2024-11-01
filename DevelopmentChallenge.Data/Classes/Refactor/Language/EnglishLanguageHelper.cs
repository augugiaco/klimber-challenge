namespace DevelopmentChallenge.Data.Classes.Refactor.Language
{
    public class EnglishLanguageHelper : ILanguageHelper
    {
        public string GetAreaText()
        {
            return "Area";
        }

        public string GetCirclePluralText()
        {
           return GetCircleText() + "s";
        }

        public string GetCircleText()
        {
            return "Circle";
        }

        public string GetPerimeterText()
        {
            return "Perimeter";
        }

        public string GetSquarePluralText()
        {
            return GetSquareText() + "s";   
        }

        public string GetSquareText()
        {
            return "Square";
        }

        public string GetTrianglePluralText()
        {
            return GetTriangleText() + "s"; 
        }

        public string GetTriangleText()
        {
            return "Triangle";
        }

        public string GetShapesPluralText()
        {
            return GetShapesText() + "s";
        }

        public string GetShapesText()
        {
            return "shape";
        }

        public string GetReportHeaderEmptyListText()
        {
            return "Empty list of shapes!";
        }

        public string GetReportHeaderForNonEmptyListText()
        {
            return "Shapes report";
        }

        public string GetRectangleText()
        {
            return "Rectangle";
        }

        public string GetRectanglePluralText()
        {
            return GetRectangleText() + "s";
        }
    }
}
