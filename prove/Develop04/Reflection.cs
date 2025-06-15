class Reflection : Exercise{

  static string name = "Reflection";
  static string thisDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

  private string[] prompts = ["Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
  private string[] reflections = ["Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"];

  public Reflection(int a = 0) : base(name,thisDescription,a){}

  public void RunExercise(){
    bool running = true;
    Random rand = new Random();
    int x = rand.Next(prompts.Length);
    DisplayWelcome();
    Console.WriteLine($"You will be given various questions relating to a prompt, and have 10 seconds to reflect on each one. Your prompt is:\n\n{prompts[x]}\n");
    while(running){
      Console.WriteLine(reflections[rand.Next(reflections.Length)]);
      running = !MarchTimer(10);
    }
    DisplayEnd();
  }
}