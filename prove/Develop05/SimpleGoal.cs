public class SimpleGoal : Goal{

  public SimpleGoal(string desc, int points, bool comp = false) : base(desc, points){
    goalType = "SimpleGoal";
    overallCompleted = comp;
  }
  //Might be unnescesary
  /*
  public SimpleGoal(string saveString){
    stringArray = saveString.Split("™");
    goalType = stringArray[0];
    goalDesc = stringArray[1];
    pointValue = stringArray[2];
    overallCompleted = stringArray[3];
  }
  */
  public override int Complete(){
    overallCompleted = true;
    int x = pointValue;
    pointValue = 0;
    return x;
  }
}