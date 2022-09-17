namespace PacktLibrary.Figures
{
    internal class Base
    {
        public decimal? radius { get; set; }
        public decimal? firstSide { get; set; }
        public decimal? secondSide { get; set; }
        public decimal? thirdSide { get; set; }
        public decimal? fourthSide { get; set; }

        public Base(decimal? radius)
        {
            this.radius = radius;
        }
        public Base(decimal? firstSide, decimal? secondSide, decimal? thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }
        public Base(decimal? firstSide, decimal? secondSide, decimal? thirdSide, decimal? fourthSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
            this.fourthSide = fourthSide;
        }
    }
}
