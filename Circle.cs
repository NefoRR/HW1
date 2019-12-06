using System;
using System.Collections.Generic;
using System.Text;

public class Circle
{
    private Double radius;
    private const double pi = 3.141592653589793238462643;

    public Circle(Double radius)
    {

        this.radius = radius;
    }

    public Double getRadius() {
        return radius;
    }

    public Double Area()
    {
        Double area = radius * radius * pi;

        return area;
    }
};

