using System;
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


class Program{
  static void Main(string[] args){
    Console.WriteLine("Hello World!");

    Circle myCircle = new Circle();
    myCircle.SetRadius(10);
    Console.WriteLine($"The Circle's radius is {myCircle.GetRadius()}");

    myCircle.SetRadius(21);
    Console.WriteLine($"The Circle's radius is now {myCircle.GetRadius()}");
    Console.WriteLine($"The Circle's area is now {myCircle.GetArea()}");
    
  }
}
