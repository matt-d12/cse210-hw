using System;

public class Circle : Shape
{
    //Establish attributes
    private double _radius;

    //Constructor method
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //Override method for abstract Area class
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}