using PacktLibrary.Figures;

namespace PacktLibrary.Mathematic
{
    internal class BaseMath
    {
        public static decimal? SquareCircle(Base baseFigure)
        {
            try
            {
                var _circle = new Base(baseFigure.radius);
                decimal? square = (decimal?)Math.PI * _circle.radius * _circle.radius;
                return square;
            }
            catch (Exception ex)
            {
                return Convert.ToDecimal(ex.Message);
            }
        }
        public static decimal? SquareTriangle(Base baseFigure)
        {
            try
            {
                var _triangle = new Base(baseFigure.firstSide, baseFigure.secondSide, baseFigure.thirdSide);
                if ((double?)_triangle.thirdSide == Math.Sqrt(Convert.ToDouble(_triangle.secondSide * _triangle.secondSide + _triangle.firstSide * _triangle.firstSide)))
                {
                    Console.WriteLine("This tiangle is rectangular");
                }
                else if ((double?)_triangle.secondSide == Math.Sqrt(Convert.ToDouble(_triangle.firstSide * _triangle.firstSide + _triangle.thirdSide * _triangle.thirdSide)))
                {
                    Console.WriteLine("This tiangle is rectangular");
                }
                else if ((double?)_triangle.thirdSide == Math.Sqrt(Convert.ToDouble(_triangle.secondSide * _triangle.secondSide + _triangle.thirdSide * _triangle.thirdSide)))
                {
                    Console.WriteLine("This tiangle is rectangular");
                }
                decimal? halfMeter = (_triangle.thirdSide + _triangle.secondSide + _triangle.thirdSide) / 2;
                decimal? square = (decimal?)Math.Sqrt(Convert.ToDouble(halfMeter * (halfMeter - _triangle.thirdSide) * (halfMeter - _triangle.secondSide) * (halfMeter - _triangle.thirdSide)));
                return square;
            }
            catch (Exception ex)
            {
                return Convert.ToDecimal(ex.Message);
            }
        }
        public static decimal? SquareQuadrilateral(Base baseFigure)
        {
            try
            {
                var _quadrilateral = new Base(baseFigure.firstSide, baseFigure.secondSide, baseFigure.thirdSide, baseFigure.fourthSide);
                if ((_quadrilateral.firstSide == _quadrilateral.thirdSide) && (_quadrilateral.secondSide == _quadrilateral.fourthSide))
                {
                    decimal? square = _quadrilateral.firstSide * _quadrilateral.secondSide;
                    return square;
                }
                else if ((_quadrilateral.firstSide == _quadrilateral.secondSide) && (_quadrilateral.secondSide == _quadrilateral.thirdSide) && (_quadrilateral.thirdSide == _quadrilateral.fourthSide))
                {
                    decimal? square = _quadrilateral.firstSide * _quadrilateral.firstSide;
                    return square;
                }
                else if (!(_quadrilateral.firstSide == _quadrilateral.thirdSide) && (_quadrilateral.secondSide == _quadrilateral.fourthSide))
                {
                    decimal? height = (decimal?)Math.Sqrt(Convert.ToDouble(_quadrilateral.firstSide * _quadrilateral.firstSide - (_quadrilateral.fourthSide - _quadrilateral.secondSide) * (_quadrilateral.fourthSide - _quadrilateral.secondSide)));
                    decimal? square = (decimal?)0.5 * height * (_quadrilateral.secondSide - _quadrilateral.fourthSide);
                    return square;
                }
                return Convert.ToDecimal("Unfortunately I can't calculate the other quadrilaterals");
            }
            catch (Exception ex)
            {
                return Convert.ToDecimal(ex.Message);
            }
        }
    }
}
