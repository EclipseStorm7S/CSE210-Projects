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


    //int SleepTime = 200;
    DateTime currentTime = DateTime.Now;
    DateTime endTime = currentTime.AddSeconds(10);
    Random rand = new Random();

    while (DateTime.Now < endTime){
      Console.Write("\b\b\bO_O");
      int x = rand.Next(5);
      Thread.Sleep(500 * x);
      Console.Write("\b\b\b-_-");
      Thread.Sleep(100);
      Console.Write("\b\b\bO_O");
      Thread.Sleep(500 * (5 - x));
      Console.Write("\b\b\b-_-");
      Thread.Sleep(100);
    }
  }
}
