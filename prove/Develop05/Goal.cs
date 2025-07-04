public abstract class Goal{
  protected string goalDesc;
  protected int pointValue;
  protected bool overallCompleted;

  protected string goalType;

  public Goal(string desc, int points){
    pointValue = points;
    goalDesc = desc;
    overallCompleted = false;
  }
  public virtual string PrintGoal(){
    string tempString = "";
    if(overallCompleted) tempString = "[X] ";
    else tempString = "[ ] ";
    tempString += $"{goalDesc}--{pointValue} points";
    return tempString;
  }
  public virtual string GetSaveString(){
    return $"{goalType}™{goalDesc}™{pointValue}™{overallCompleted}";
  }
  public abstract int Complete();
}