class Exercise{
  private string exerciseName;
  private string[] welcomeMessage = ["You have selected the "," activity. Please input the amount of time you would like to do this activity for:"];
  private string description;
  private int timeLimit;
  private  DateTime currentTime;
  private  DateTime endTime;

  public Exercise(string a, string b, int c){
    exerciseName = a;
    description = b;
    timeLimit = c;
  }

   public void SetTimeLimit(int a){
     timeLimit = a;
   }

   public int GetTimeLimit(){
     return timeLimit;
   }

  public void DisplayWelcome(){
    Console.WriteLine($"{welcomeMessage[0]}{exerciseName}{welcomeMessage[1]}");
    timeLimit = Int32.Parse(Console.ReadLine());
    Console.Write(description);
    Console.WriteLine(" Press enter to begin.");
    Console.ReadLine();
    currentTime = DateTime.Now;
    endTime = currentTime.AddSeconds(timeLimit);
  }
  public bool MarchTimer(int time){
    Console.Write(time);
    string hoho;
    for(;time >= 0;time--){
      Thread.Sleep(1000);
      hoho = "";
      for(int i = 0 ; i <= $"{time + 1}".Length ; i++){
        hoho += "\b";
      }
      Console.Write($"\b\b\b\b\b{hoho}{time}     ");
    }
    return CheckTimer();
  }//waits for time, displays a countdown

  /*
  public bool MarchTimerNoDisplay(int time){
    timer += time
  }//increments timer without waiting.  no countdown is displayed.
  */

  public bool CheckTimer(){
    if(DateTime.Now >= endTime){
      return true;
    } else return false;
  } //checks if the overall time limit has been reached

  public void DisplayEnd(){
    Console.WriteLine($"Good Job! you have completed the {exerciseName} exercise! I encourage you to complete all exercises at least once!\n");
  }
}