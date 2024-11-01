namespace DevelopmentChallenge.Data.Classes.Refactor.Language
{
    public class ItalianLanguageHelper : ILanguageHelper
    {
        public string GetAreaText()
        {
            return "Zona";
        }

        public string GetCirclePluralText()
        {
           return GetCircleText() + "s";
        }

        public string GetCircleText()
        {
            return "Cerchio";
        }

        public string GetPerimeterText()
        {
            return "Perimetro";
        }

        public string GetSquarePluralText()
        {
            return GetSquareText() + "s";   
        }

        public string GetSquareText()
        {
            return "Piazza";
        }

        public string GetTrianglePluralText()
        {
            return GetTriangleText() + "s"; 
        }

        public string GetTriangleText()
        {
            return "Triangolo";
        }

        public string GetShapesPluralText()
        {
            return GetShapesText() + "s";
        }

        public string GetShapesText()
        {
            return "forma";
        }

        public string GetReportHeaderEmptyListText()
        {
            return "Elenco vuoto di forme!";
        }

        public string GetReportHeaderForNonEmptyListText()
        {
            return "Rapporto sui Moduli";
        }

        public string GetRectangleText()
        {
            return "Rettangolo";
        }

        public string GetRectanglePluralText()
        {
            return GetRectangleText() + "s";
        }
    }
}
