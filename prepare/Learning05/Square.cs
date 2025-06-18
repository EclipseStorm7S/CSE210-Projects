public class Square : Shape{
  private float side;

  public Square(string a, float b = 1) : base(a){side = b;}

  public override float GetArea(){
    return side * side;
  }
}