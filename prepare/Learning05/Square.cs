using System;

public class Square : Shape
{
    //Establish attributes
    private double _side;

    //Constructor method
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Method to override abstract Area from parent
    public override double GetArea()
    {
        return _side * _side;
    }
}