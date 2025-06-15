class Listing : Exercise{

  static string name = "Listing";
  static string thisDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

  private string[] prompts = ["Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"];

  private int responseCount;

  public Listing(int a = 0) : base(name,thisDescription,a){}

  public void RunExercise(){
    DisplayWelcome();
    Random rand = new Random();
    int x = rand.Next(prompts.Length);
    responseCount = 0;
    Console.WriteLine($"You will be given a prompt, and will write as many answers as you can before time runs out. You will have 5 seconds to think before it starts. Your prompt is:\n\n{prompts[x]}\n");
    bool running = true;
    MarchTimer(5);
    Console.WriteLine("Begin!");
    while(running){
      Console.ReadLine();
      responseCount += 1;
      running = !CheckTimer();
    }
    Console.WriteLine($"Time's up! You managed {responseCount} responses!");
    DisplayEnd();
  }
}