using System;


namespace Ex1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter radius: ");
            TakeDataFromKeyboardAndCheck validator = new TakeDataFromKeyboardAndCheck();
            Circle circle = new Circle(validator.GetTakeDataFromKeyboardAndCheck());
            Console.Write("Enter square side: ");
            Square square = new Square(validator.GetTakeDataFromKeyboardAndCheck()); ;
            Console.WriteLine("Area of a circle: " + String.Format("{0:f}", circle.Area()));
            Console.WriteLine("Area of a square: " + String.Format("{0:f}", square.Area()));
            Console.WriteLine(new Validate().ValidateCrosses(circle.getRadius(), square.getSide()));
            Console.ReadKey();


        }


        



    }
}