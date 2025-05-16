using System;

class Program
{
  static void Main(string[] args)
  {
    Console.Write("What is your grade in percentage (no decimals)? ");
    string userInput = Console.ReadLine();
    int gradePercent = int.Parse(userInput);
    string gradeLetter = "F";
    if(gradePercent > 90){
      gradeLetter = "A";
    } else if(gradePercent >= 80) {
      gradeLetter = "B";
    } else if(gradePercent >= 70) {
      gradeLetter = "C";
    } else if(gradePercent >= 60) {
      gradeLetter = "D";
    }
    Console.WriteLine("Your grade is a " + gradeLetter);

    if (gradePercent >= 70) {
        Console.WriteLine("You passed!");
    } else {
        Console.WriteLine("Study harder!");
    }
  }
}