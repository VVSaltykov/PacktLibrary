using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Figures
{
    internal class Triangle
    {
        public decimal? firstSide { get; set; }
        public decimal? secondSide { get; set; }
        public decimal? thirdSide { get; set; }

        public Triangle(decimal? firstSide, decimal? secondSide, decimal? thirdside)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdside;
        }
    }
}
