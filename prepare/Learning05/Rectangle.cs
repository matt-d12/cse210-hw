using System;

public class Rectangle : Shape
{
    //Establish attributes
    private double _length;
    private double _width;

    //Constructor method
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    //Override method for abstract Area class
    public override double GetArea()
    {
        return _length * _width;
    }
}