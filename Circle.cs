using System;
using System.Collections.Generic;
using System.Text;

public class Circle
{
    private double _radius;
    private const double pi = 3.141592653589793238462643;
    private double _area;
    
    public double Area => _area;

    public double Radius
    {
        get => _radius;
        set
        {
            _radius = value;
            _area = _radius * _radius * pi;
        }
    }


};

