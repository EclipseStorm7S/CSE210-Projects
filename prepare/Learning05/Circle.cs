public class Circle : Shape{
  private float radius;

  public Circle(string a, float b = 1) : base(a){radius = b;}

  public override float GetArea(){
    return 3.14159265358979323f * radius * radius;
  }
}