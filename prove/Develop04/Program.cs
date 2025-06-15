using System;

//I made it so that the breathing exercise has a fluctuating progress bar to mimic inhaling and exhaling
class Program
{
  static void Main(string[] args)
  {
    Breathing choice1 = new Breathing();
    Reflection choice2 = new Reflection();
    Listing choice3 = new Listing();
    bool run = true;
    while(run){
      Console.WriteLine("Choose your activty:\n1) Breathing\n2) Reflection\n3) Listing\n4) Exit");
      string answer = Console.ReadLine();
      switch(answer){
        case "1":
          choice1.RunExercise();
          break;
        case "2":
          choice2.RunExercise();
          break;
        case "3":
          choice3.RunExercise();
          break;
        case "4":
          run = false;
          break;
    }
    }
  }
}