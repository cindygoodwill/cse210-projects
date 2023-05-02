using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());

        Console.WriteLine(f2.GetTop());

        Console.WriteLine(f3.GetBottom());

        f1.SetTop(33);
        f1.SetBottom(100);
        Console.WriteLine(f1.GetFractionString());

        f1.SetTop(3);
        f1.SetBottom(4);
        Console.WriteLine(f1.GetDecimalValue());

        f1.SetTop(1);
        f1.SetBottom(1);
        Console.WriteLine(f1.GetDecimalValue());

        f1.SetTop(5);
        f1.SetBottom(1);
        Console.WriteLine(f1.GetDecimalValue());

        f1.SetTop(1);
        f1.SetBottom(3);
        Console.WriteLine(f1.GetDecimalValue());

    }
}