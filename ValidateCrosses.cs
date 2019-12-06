using System;
using System.Collections.Generic;
using System.Text;

public class Validate
{
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