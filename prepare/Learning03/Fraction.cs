using System;

public class Fraction
{
    //Establish attributes
    private int _top;
    private int _bottom;

    //Construct default fraction
    public Fraction()
    {
        //Default with no parameters should be set to 1/1
        _top = 1;
        _bottom = 1;
    }

    //Construct for single parameter
    public Fraction(int wholeNumber)
    {
        //Pass in whole number for numerator
        _top = wholeNumber;
        //Denomiator set to 1 as whole number
        _bottom = 1;
    }

    //Construct when passing in two parameters
    public Fraction(int top, int bottom)
    {
        //Pass in and set new variables
        _top = top;
        _bottom = bottom;
    }
}