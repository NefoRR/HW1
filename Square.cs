using System;
using System.Collections.Generic;
using System.Text;

public class Square
{
    private double _side;
    private double _area;

    public double Side
    {
        get => _side;
        set
        {
            _side = value;
            _area = _side * _side;
        }
    }
    
    public double Area => _area;
}
