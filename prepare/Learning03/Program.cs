using System;

class Program
{
    static void Main(string[] args)
    {
        //Initialize new fractions
        Fraction f1 = new Fraction();
        Console.WriteLine(f1);

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2);

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3);
    }
}