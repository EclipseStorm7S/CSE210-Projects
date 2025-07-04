public class ChecklistGoal : Goal{

  private int goalCount;
  private int compCount;

  public ChecklistGoal(string desc, int points, int count, int comp = 0) : base(desc, points){
    goalCount = count;
    compCount = comp;
    if (compCount >= goalCount) overallCompleted = true;
    goalType = "ChecklistGoal";
  }

  public override string PrintGoal(){
    string tempString = "";
    if(overallCompleted) tempString = "[X] ";
    else tempString = "[ ] ";
    tempString += $"{goalDesc}--{pointValue} points--completed {compCount}/{goalCount} times.";
    return tempString;
  }

  public override string GetSaveString(){
    return $"{goalType}™{goalDesc}™{pointValue}™{goalCount}™{compCount}";
  }

  public override int Complete(){
    compCount += 1;
    if(compCount == goalCount){
      overallCompleted = true;
      int x = pointValue;
      pointValue = 0;
      return x;
    } else {
      return (pointValue / (goalCount * 2));
    }
  }
}