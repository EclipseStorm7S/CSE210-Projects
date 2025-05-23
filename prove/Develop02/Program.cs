using System;

class Program
{
  static Journal mainJournal = new Journal();
  static string[] prompts = ["Why?","What was the most interesting thing today?","What was the most mundane thing today?","What's something you're grateful happened today?","How many people did you want to punch today and why?","What's new Mcgew?","Did you wear pants today? What would have happened if you had or hadn't?","What is 301 x 14?","If you had to change one perrson's name to Michael today, who and why?","Did you pick your nose? If so, where? If not, did you want to?"];
    static void Main(string[] args)
    {
      string input = "0";
      while(input != "5"){
        Console.WriteLine("1. Write new entry\n2. Display journal\n3. Save journal to file\n4. Load jounal from file\n5. Exit");
        input = Console.ReadLine();
        switch(input){
          case "1":
            NewEntry();
            break;
          case "2":
            Console.WriteLine("\n" + mainJournal.ReadJournal());
            break;
          case "3":
            Console.WriteLine("Enter a File Name, or leave blank to use your most recent one: ");
            string inputFileName = Console.ReadLine();
            mainJournal.WriteToFile(inputFileName);
            break;
          case "4":
            Console.WriteLine("Enter a File Name, or leave blank to use your most recent one: ");
            inputFileName = Console.ReadLine();
            mainJournal.ReadFromFile(inputFileName);
            break;
          case "5":
            Console.WriteLine("Buh bye!");
            break;
          default:
            Console.WriteLine("Enter a number between 1 and 5, idiot.\n");
            break;
        }
      }
    }
    static void NewEntry(){
      Random rng = new Random();
      int ayooo = rng.Next(0,prompts.Length);
      Console.WriteLine(prompts[ayooo]);
      string entryInput = Console.ReadLine();
      JournalEntry newGuy = new JournalEntry(DateTime.Now.ToShortDateString(),prompts[ayooo],entryInput);
      mainJournal.AddEntry(newGuy);
    }

}