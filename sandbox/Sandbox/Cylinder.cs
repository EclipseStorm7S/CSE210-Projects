
class Cylinder{
  private Circle _circle;
  private double _height;
  public Cylinder(){
    _height = 0;
    _circle = null;
  }
  public Cylinder(Circle c, double h){
    _circle = c;
    _height = h;
  }
  public Cylinder(double r, double h){
    _circle = new Circle(r);
    _height = h;
  }
  public void SetCircle(Circle circle){
    _circle = circle;
  }
  public void SetHeight(double height){
    _height = height;
  }

  public double GetVolume(){
    return _circle.GetArea() * _height;
  }
}