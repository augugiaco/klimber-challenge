namespace DevelopmentChallenge.Data.Classes.Refactor.Language
{
    public class SpanishLanguageHelper : ILanguageHelper
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
            return "Círculo";
        }

        public string GetReportHeaderEmptyListText()
        {
            return "Lista vacía de formas!";
        }

        public string GetPerimeterText()
        {
            return "Perimetro";
        }

        public string GetShapesPluralText()
        {
            return GetShapesText() + "s";   
        }

        public string GetShapesText()
        {
            return "forma";
        }

        public string GetSquarePluralText()
        {
            return GetSquareText() + "s";   
        }

        public string GetSquareText()
        {
            return "Cuadrado";
        }

        public string GetTrianglePluralText()
        {
            return GetTriangleText() + "s"; 
        }

        public string GetTriangleText()
        {
            return "Triángulo";
        }

        public string GetReportHeaderForNonEmptyListText()
        {
            return "Reporte de Formas";
        }

        public string GetRectangleText()
        {
            return "Rectángulo";
        }

        public string GetRectanglePluralText()
        {
            return GetRectangleText() + "s";
        }
    }
}
