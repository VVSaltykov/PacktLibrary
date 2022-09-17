using PacktLibrary.Figures;

namespace PacktLibrary.Mathematic
{
    internal class CircleMath
    {
        public static decimal? Square(Circle circle)
        {
            try
            {
                var _circle = new Circle(circle.radius);
                decimal? square = (decimal?)Math.PI * _circle.radius * _circle.radius;
                return square;
            }
            catch (Exception ex)
            {
                return Convert.ToDecimal(ex.Message);
            }
        }
    }
}
