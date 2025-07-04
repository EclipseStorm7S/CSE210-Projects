using System;

class Program
{
  static void Main(string[] args)
  {
    List<Goal> GoalList = new List<Goal>();
    int points = 0;
    //Console.WriteLine("Ayooo!");

    if (File.Exists("SavedGoals.txt")) Load();
    string input = "0";
    while(input != "4"){
      Console.WriteLine($"\nWelcome! you have {points} points! What would you like to do?\n1. View goals\n2. Mark Goal as complete\n3. Add new goal\n4. Exit");
      input = Console.ReadLine();
      switch(input){
        case "1":
          Console.WriteLine("\nGOALS:");
          foreach(Goal i in GoalList){
            Console.WriteLine(i.PrintGoal());
          }
          Console.WriteLine("Press enter to continue.");
          Console.ReadLine();
          break;
        case "2":
          Console.WriteLine("\nGOALS:");
          int j = 1;
          foreach(Goal i in GoalList){
            Console.Write($"{j}. ");
            Console.WriteLine(i.PrintGoal());
            j++;
          }
          Console.WriteLine("Enter the number of the goal you'd like to mark as complete!");
          int compChoice = Int32.Parse(Console.ReadLine());
          int scoreGain = GoalList[compChoice - 1].Complete();
          Console.WriteLine($"You've gained {scoreGain} points!");
          points += scoreGain;
          break;
        case "3":
          NewGoal();
          break;
        case "4":
          Console.WriteLine("Buh bye!");
          break;
        default:
          Console.WriteLine("Enter a number between 1 and 4. You can't just make stuff up.\n");
          break;
      }
    }
    Save();
    Console.WriteLine("Data saved!");


    void NewGoal(){
      Console.WriteLine("Enter the number of the type of goal would you like.\n1. Simple\n2. Checklist\n3. Eternal\n4. Diminishing");
      switch(Console.ReadLine()){
        case "1":
          Console.WriteLine("Describe the goal:");
          string tempDesc = Console.ReadLine();
          Console.WriteLine("How many points should it be worth?");
          int tempScore = Int32.Parse(Console.ReadLine());
          GoalList.Add(new SimpleGoal(tempDesc, tempScore));
          break;
        case "2":
          Console.WriteLine("Describe the goal:");
           tempDesc = Console.ReadLine();
          Console.WriteLine("How many points should it be worth?");
           tempScore = Int32.Parse(Console.ReadLine());
          Console.WriteLine("How many times should it be completed?");
          int tempCount = Int32.Parse(Console.ReadLine());
          GoalList.Add(new ChecklistGoal(tempDesc, tempScore, tempCount));
          break;
        case "3":
          Console.WriteLine("Describe the goal:");
           tempDesc = Console.ReadLine();
          Console.WriteLine("How many points should it be worth?");
           tempScore = Int32.Parse(Console.ReadLine());
          GoalList.Add(new EternalGoal(tempDesc, tempScore));
          break;
        case "4":
          Console.WriteLine("Describe the goal:");
           tempDesc = Console.ReadLine();
          Console.WriteLine("How many points should it be worth upon the first completion? (Point score decreases with each completion)");
           tempScore = Int32.Parse(Console.ReadLine());
          GoalList.Add(new DiminishingGoal(tempDesc, tempScore));
          break;
        default:
          Console.WriteLine("Invalid choice, returning to main menu.");
          break;
      }
    }

    void Save(){
      using (StreamWriter outputFile = new StreamWriter("SavedGoals.txt"))
      {
        outputFile.WriteLine($"{points}");
        foreach (Goal goalData in GoalList){
          outputFile.WriteLine(goalData.GetSaveString());
        }
      }
    }

    void Load(){
      GoalList = new List<Goal>();
      string[] lines = System.IO.File.ReadAllLines("SavedGoals.txt");
      points = Int32.Parse(lines[0]);
      lines = lines[1..];
      foreach(string line in lines){
        string[] splitLine = line.Split("™");
        switch(splitLine[0]){
          case "SimpleGoal":
            GoalList.Add(new SimpleGoal(splitLine[1], Int32.Parse(splitLine[2]), Convert.ToBoolean(splitLine[3])));
            break;
          case "ChecklistGoal":
            GoalList.Add(new ChecklistGoal(splitLine[1], Int32.Parse(splitLine[2]), Int32.Parse(splitLine[3]), Int32.Parse(splitLine[4])));
            break;
          case "EternalGoal":
          GoalList.Add(new EternalGoal(splitLine[1], Int32.Parse(splitLine[2]), Int32.Parse(splitLine[3])));
            break;
          case "DiminishingGoal":
          GoalList.Add(new DiminishingGoal(splitLine[1], Int32.Parse(splitLine[2]), Int32.Parse(splitLine[3])));
            break;
          default:
            Console.WriteLine($"ERROR: Goal type \"{splitLine[0]}\" invalid.");
            break;
        }
      }
    }
  }
}