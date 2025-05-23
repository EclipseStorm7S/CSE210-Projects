using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionA = new Fraction();
        Fraction fractionB = new Fraction(20);
        Fraction fractionC = new Fraction(360, 361);
        fractionA.SetTop(10);
        fractionA.SetBot(15);
        fractionB.SetBot(13);
        Console.WriteLine(fractionA.GetFractionString());
        Console.WriteLine(fractionB.GetDecimalValue());
        Console.WriteLine(fractionC.GetFractionString());
        Console.WriteLine(fractionC.GetDecimalValue());
    }
}