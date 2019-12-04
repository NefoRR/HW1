using System;

namespace Ex1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter radius: ");
            Circle circle = new Circle(TakeDataFromKeyboardAndCheck());
            Console.Write("Enter square side: ");
            Square square = new Square(TakeDataFromKeyboardAndCheck());
            Console.WriteLine("Area of a circle: " + String.Format("{0:f}", circle.Area()));
            Console.WriteLine("Area of a square: " + String.Format("{0:f}", square.Area()));
            Console.ReadKey();
        }


        

        public static Double TakeDataFromKeyboardAndCheck()
        {
            String enteredData;
            Double num = 0;
            bool isNum = false;

            for (int i = 0; i < 3; i++)
            {
                enteredData = Console.ReadLine();
                isNum = Double.TryParse(enteredData, out num);
                if (isNum)
                {
                    return num;
                }
                else if (i < 2)
                {
                    Console.WriteLine("Incorrest format. Correct format is: 16,38");
                    Console.Write("Try again: ");
                };
            };

            if (!isNum)
            {
                Random rnd = new Random();
                num = rnd.Next(5, 50) / 10.0;
                Console.WriteLine("You entered the wrong data three times, so the random generated everything for you: " + num);
                Console.ReadKey();
                return num;
            }
            return num;

        }
    }
}