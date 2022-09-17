using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacktLibrary.Figures;

namespace PacktLibrary.Mathematic
{
    internal class TriangleMath
    {
        public static decimal? Square(Triangle triangle)
        {
            try
            {
                var _triangle = new Triangle(triangle.firstSide, triangle.secondSide, triangle.thirdSide);
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
    }
}
