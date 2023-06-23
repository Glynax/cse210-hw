using System;

class Program
{
    static void Main(string[] args)
    {
         // Creating fractions using different constructors
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(5); // 5/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4
        Fraction fraction4 = new Fraction(1, 3); // 1/3

        // Testing getters and setters
        Console.WriteLine("Fraction 1: {0}/{1}", fraction1.Top, fraction1.Bottom);
        fraction1.Top = 2;
        fraction1.Bottom = 3;
        Console.WriteLine("Fraction 1 (updated): {0}/{1}", fraction1.Top, fraction1.Bottom);

        // Testing string representation and decimal value
        Console.WriteLine("Fraction 3 as string: {0}", fraction3.GetFractionString());
        Console.WriteLine("Fraction 3 as decimal: {0}", fraction3.GetDecimalValue());      

    }
}