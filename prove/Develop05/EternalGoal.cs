public class EternalGoal : Goal{

  int completionCount;
  public EternalGoal(string desc, int points, int comp = 0) : base(desc, points){
    goalType = "EternalGoal";
    completionCount = comp;
  }

  public override string PrintGoal(){
    return $"ETERNAL: {goalDesc}--{pointValue} points--Completed {completionCount} times.";
  }

  public override string GetSaveString(){
    return $"{goalType}™{goalDesc}™{pointValue}™{completionCount}";
  }

  public override int Complete(){
    completionCount += 1;
    return pointValue;
  }
}