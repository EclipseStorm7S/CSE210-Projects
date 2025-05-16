using System;

class Program
{
  static void Main(string[] args)
  {
    Random rng = new Random();
    int secretNumb = rng.Next(1, 101);
    int score = 0;
    int guess = -1;

    while (guess != secretNumb)
    {
      score += 1;
      Console.Write("Guess my number! ");
      guess = int.Parse(Console.ReadLine());

      if (secretNumb > guess) {
        Console.WriteLine("Too low!");
      } else if (secretNumb < guess) {
        Console.WriteLine("Too High!");
      } else {
        Console.WriteLine($"Correct! It took you {score} tries!");
      }
    }
  }
}