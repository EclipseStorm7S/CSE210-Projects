using System;
using System.Collections.Generic;

class Program
{
  static void Main(string[] args)
  {
    List<int> numberList = new List<int>();

    int userNumber = -1;
    while (userNumber != 0) {
      Console.Write("Enter a number, or type 0 to exit: ");
      string userInput = Console.ReadLine();
      userNumber = int.Parse(userInput);

      if (userNumber != 0) {
        numberList.Add(userNumber);
      }
    }

    //sum
    int sum = 0;
    foreach (int x in numberList) {
      sum += x;
    }
    Console.WriteLine($"The sum of those numbers is: {sum}");

    //average
    float avg = ((float)sum) / numberList.Count;
    Console.WriteLine($"The average of those numbers is: {avg}");

    //max
    int max = 0;
    foreach (int number in numberList)
    {
      max = Math.Max(max, number);
    }
    Console.WriteLine($"The maximum of those numbers is: {max}");
  }
}