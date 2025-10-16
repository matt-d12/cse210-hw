using System;

class Program
{
    static void Main(string[] args)
    {
        //Establish list for shapes
        List<Shape> shapes = new List<Shape>();
        //Create Square instance and test methods for color and area
        Square shape1 = new Square("Blue", 2);
        shapes.Add(shape1);

        //Create Circle instance and test
        Rectangle shape2 = new Rectangle("Red", 3, 2);
        shapes.Add(shape2);

        //Create Rectangle instance and test
        Circle shape3 = new Circle("Pink", 3);
        shapes.Add(shape3);

        foreach (Shape shape in shapes)
        {
            //Call methods to calculate 
            string color = shape.GetColor();
            double area = shape.GetArea();

            //Display
            Console.WriteLine($"Color = {color} | Area = {area}");
        }
    }
}