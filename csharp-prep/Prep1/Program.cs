using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is you first name? ");
      string fName = Console.ReadLine();
      Console.Write("What is you last name? ");
      string lName = Console.ReadLine();
      Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
    }
}