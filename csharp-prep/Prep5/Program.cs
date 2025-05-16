using System;

class Program
{
  static void Main(string[] args)
  {
    DisplayWelcome();

    string userName = PromptUserName();
    int userNumber = PromptUserNumber();
    int squaredNumber = SquareNumber(userNumber);
    DisplayResult(userName, squaredNumber);
  }

  static void DisplayWelcome() {
    Console.WriteLine("Welcome to the program!");
  }

  static string PromptUserName() {
    Console.WriteLine("What's your name?");
    string name = Console.ReadLine();
    return name;
  }

  static int PromptUserNumber() {
    Console.WriteLine("What's your favorite number?");
    int x = int.Parse(Console.ReadLine());
    return x;
  }

  static int SquareNumber(int x) {
    int y = x * x;
    return y;
  }

  static void DisplayResult(string name, int square) {
    Console.WriteLine($"{name}, the square of your favorite number is {square}");
  }
}