using System;
using System.Collections.Generic;
using System.Text;

public class Square
{
    private Double side;

    public Square(Double side)
    {
        this.side = side;
    }

    public Double getSide()
    {
        return side;
    }

    public Double Area()
    {
        Double area = side * side;

        return area;
    }
}
