using System;

public abstract class Shape
{
    //Establish attributes
    private string _color;

    //Constructor method
    public Shape(string color)
    {
        _color = color;
    }

    //Getter method
    public string GetColor()
    {
        return _color;
    }

    //Setter method
    public void SetColor(string color)
    {
        _color = color;
    }

    //Virtual method for the area
    public abstract double GetArea();
}