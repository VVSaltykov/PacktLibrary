using PacktLibrary.Figures;
using PacktLibrary.Mathematic;

namespace PacktLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello, put your radius value for circle!");
                decimal? radius = Convert.ToDecimal(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine("And three side values for triangle!");
                decimal? firstSide = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Another one:");
                decimal? secondSide = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("And another one:");
                decimal? thirdSide = Convert.ToDecimal(Console.ReadLine());
                Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
                decimal? squareCircle = CircleMath.Square(circle);
                decimal? squareTriangle = TriangleMath.Square(triangle);
                Console.WriteLine($"Circle square: {squareCircle}");
                Console.WriteLine($"Triangle square: {squareTriangle}");
                Console.WriteLine("You want to check the calculation of the area of the shape without knowing the type of shapes?");
                Console.WriteLine("Press 1, if you want!");
                string? condition = Console.ReadLine();
                switch (condition)
                {
                    case "1":
                        Console.WriteLine("Enter your value");
                        Console.WriteLine("If you have entered enough, then in the next step just press Enter");
                        Console.WriteLine("First side or radius:");
                        try
                        {
                            decimal? _firstSide = Convert.ToDecimal(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Second side:");
                                decimal? _secondSide = Convert.ToDecimal(Console.ReadLine());
                                try
                                {
                                    Console.WriteLine("Third side:");
                                    decimal? _thirdSide = Convert.ToDecimal(Console.ReadLine());
                                    try
                                    {
                                        Console.WriteLine("Fourth side");
                                        decimal? _fourthSide = Convert.ToDecimal(Console.ReadLine());
                                        Base _quadrilateral = new Base(_firstSide, _secondSide, _thirdSide, _fourthSide);
                                        decimal? _squareQuadrilateral = BaseMath.SquareQuadrilateral(_quadrilateral);
                                        Console.WriteLine($"Quadrilateral square: {_squareQuadrilateral}");
                                        break;
                                    }
                                    catch
                                    {
                                        Base _triangle = new Base(_firstSide, _secondSide, _thirdSide);
                                        decimal? _squareTriangle = BaseMath.SquareTriangle(_triangle);
                                        Console.WriteLine($"Triangle square: {_squareTriangle}");
                                        break;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("It is not a figure!");
                                    break;
                                }
                            }
                            catch
                            {
                                Base _circle = new Base(_firstSide);
                                decimal? _squareCircle = BaseMath.SquareCircle(_circle);
                                Console.WriteLine($"Circle square: {_squareCircle}");
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("It is not a figure!");
                            break;
                        }
                    default:
                        Console.WriteLine("That's all!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}