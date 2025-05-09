class Circle{
  private double _radius = 1;
  public void SetRadius(double radius){
    if (radius < 0){
      Console.WriteLine("ERROR: Circle annot have radius of zero.");
      return;
    }
    _radius = radius;
  }
  public double GetRadius(){
    return _radius;
  }

  public double GetArea(){
    return Math.PI * _radius * _radius;
  }
}