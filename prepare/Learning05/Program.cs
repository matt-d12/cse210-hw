using System;

class Program
{
    static void Main(string[] args)
    {
        //Create Square instance and test methods for color and area
        Square square = new Square("Blue", 2);

        string color = square.GetColor();
        double area = square.GetArea();

        //Display
        Console.WriteLine($"Color = {color} | Area = {area}");
    }
}