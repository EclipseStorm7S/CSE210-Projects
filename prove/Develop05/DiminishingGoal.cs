public class DiminishingGoal : Goal{

  int completionCount;
  public DiminishingGoal(string desc, int points, int comp = 0) : base(desc, points){
    goalType = "DiminishingGoal";
    completionCount = comp;
  }

  public override string PrintGoal(){
    return $"DIMINISHING: {goalDesc}--{pointValue} points--Completed {completionCount} times.";
  }

  public override string GetSaveString(){
    return $"{goalType}™{goalDesc}™{pointValue}™{completionCount}";
  }

  public override int Complete(){
    completionCount += 1;
    int x = pointValue;
    pointValue = (int)(pointValue * 0.8);
    return x;
  }
}