using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction tuki = new Fraction(1);
        Console.WriteLine(tuki.GetFractionString());
        Console.WriteLine(tuki.GetDecimalValue());
        Fraction tuki2 = new Fraction(5);
        Console.WriteLine(tuki2.GetFractionString());
        Console.WriteLine(tuki2.GetDecimalValue());
        Fraction tuki3 = new Fraction(3,4);
        Console.WriteLine(tuki3.GetFractionString());
        Console.WriteLine(tuki3.GetDecimalValue());
        Fraction tuki4 = new Fraction(1,3);
        Console.WriteLine(tuki4.GetFractionString());
        Console.WriteLine(tuki4.GetDecimalValue());
    }
}