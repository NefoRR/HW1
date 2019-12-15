using System;


namespace Ex1
{
    class Program
    {
        public static void Main(String[] args)
        {
            ConsoleHelper validator = new ConsoleHelper();
            Circle circle = new Circle();
            Square square = new Square(); 
            
            Console.Write("Enter radius: ");
            circle.Radius = validator.GetPositiveDouble();
            
            Console.Write("Enter square side: ");
            square.Side = validator.GetPositiveDouble();
            
            Console.WriteLine("Area of a circle: " + String.Format("{0:f}", circle.Area));
            Console.WriteLine("Area of a square: " + String.Format("{0:f}", square.Area));
            Console.WriteLine(validator.ValidateCrosses(circle.Radius, square.Side));
            Console.ReadKey();
        }
    }
}