public abstract class Shape{
  private string color;
  public string GetColor(){return color;}
  public void setColor(string a){color = a;}

  public Shape(string a){color = a;}

  public abstract float GetArea();
}