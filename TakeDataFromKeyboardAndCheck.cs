using System;

public class TakeDataFromKeyboardAndCheck
{
    public double GetTakeDataFromKeyboardAndCheck()
    {
        String enteredData;
        Double num = 0;
        bool isNum = false;

        for (int i = 0; i < 3; i++)
        {
            enteredData = Console.ReadLine();
            isNum = Double.TryParse(enteredData, out num);
            if (isNum && num > 0)
            {
                return num;
            }
            if (i < 2)
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
