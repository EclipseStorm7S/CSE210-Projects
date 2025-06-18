public class Rectangle : Shape{
  private float sideA;
  private float sideB;

  public Rectangle(string a, float b = 1, float c = 2) : base(a){
    sideA = b;
    sideB = c;
  }

  public override float GetArea(){
    return sideA * sideB;
  }
}