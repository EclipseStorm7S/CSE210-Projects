class Breathing : Exercise{

  static string name = "Breathing";
  static string thisDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

  public Breathing(int a = 0) : base(name,thisDescription,a){}

  public void RunExercise(){
    bool running = true;
    DisplayWelcome();
    while(running){
      Console.SetCursorPosition(0, Console.CursorTop -1);
      Console.WriteLine("Breath in... ");
      for (int i = 0; i < 50; i++) {
      Thread.Sleep(100);
      Console.Write("█");
      }
      Console.SetCursorPosition(0, Console.CursorTop -1);
      Console.WriteLine("Breath out...");
      Console.SetCursorPosition(50, Console.CursorTop);
      Console.Write("\b ");
      for (int i = 0; i < 49; i++) {
      Thread.Sleep(100);
      Console.Write("\b\b ");
      }
      running = !CheckTimer();
    }
    DisplayEnd();
  }
}