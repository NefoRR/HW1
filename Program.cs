using System;

namespace Ex1
{
    class Program
    {
        public static void Main(String[] args)
        {
            Circle circle = new Circle();
            Square square = new Square();
            Console.WriteLine("Area of a circle: " + circle.Area());
            Console.WriteLine("Area of a square: " + square.Area());
            Console.ReadKey();
        }

        public class Circle
        {
            private Double radius;
            private const double pi = 3.141592653589793238462643;

            public Circle()
            {
                Console.Write("Enter radius: ");
                this.radius = TakeDataFromKeyboardAndCheck();
            }

            public String Area()
            {
                Double area = radius * radius * pi;
                String result = String.Format("{0:f}", area);
                return result;
            }
        };

        public class Square
        {
            private Double side;

            public Square()
            {
                Console.Write("Enter square side: ");
                this.side = TakeDataFromKeyboardAndCheck();
            }

            public String Area()
            {
                Double area = side * side;
                String result = String.Format("{0:f}", area);
                return result;
            }
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