using System;

public class ConsoleHelper
{
    public double GetPositiveDouble()
    {
        String enteredData;
        Double num = 0;
        bool isNum = false;
        int maxAttempts = 3;
        int attemptsCount = 0;

        while (attemptsCount < maxAttempts)
        {
            enteredData = Console.ReadLine();
            isNum = Double.TryParse(enteredData, out num);
            if (isNum && num > 0)
            {
                return num;
            }
            Console.WriteLine("Incorrest format. Correct format is: 16,38");
            attemptsCount++;
        }
        
        Random rnd = new Random();
        num = rnd.Next(5, 51) / 10.0;
        Console.WriteLine("You entered the wrong data three times, so the random generated everything for you: " + num);
        return num;
    }
    
    public String ValidateCrosses(Double radius, Double side)
    {
        if (side >= 2 * radius)
        {
            return "Circle in square";
        }
        else if (radius >= side / Math.Sqrt(2))
        {
            return "Square in circle";
        }
        else
        {
            return "Square crosses circle";
        }
    }
}
