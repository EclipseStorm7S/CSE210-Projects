using System;

class Program
{
  static void Main(string[] args)
  {
    List<Shape> yowhaddup = new List<Shape>();
    yowhaddup.Add(new Square("Red",3));
    yowhaddup.Add(new Rectangle("Vomit",5.6f));
    yowhaddup.Add(new Circle("Shame",1.2f));
    yowhaddup.Add(new Square("Tardigrade Brown",0.9f));
    foreach (Shape i in yowhaddup) {
      Console.WriteLine($"{i.GetColor()}, {i.GetArea()}");
    }
  }
}