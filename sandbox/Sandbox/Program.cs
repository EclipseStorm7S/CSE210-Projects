using System;

class Program{
  static void Main(string[] args){
    Console.WriteLine("Hello World!");

    Circle myCircle = new Circle(10);
    Console.WriteLine($"The circle's radius is {myCircle.GetRadius()}");

    myCircle.SetRadius(21);
    Console.WriteLine($"The circle's radius is now {myCircle.GetRadius()}");
    Console.WriteLine($"The circle's area is now {myCircle.GetArea()}");

    Cylinder myCylinder = new Cylinder(myCircle,3.5);
    myCylinder.SetCircle(myCircle);
    myCylinder.SetHeight(3.5);
    Console.WriteLine($"The cylinder's volume is {myCylinder.GetVolume()}");

  }
}
