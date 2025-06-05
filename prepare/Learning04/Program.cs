using System;

class Program
{
    static void Main(string[] args)
    {
      Assignment item1 = new Assignment("Timbo Burton","The Griddy");
      Console.WriteLine(item1.GetSummary());
      MathAssignment item2 = new MathAssignment("Craig Gregg","How to bish bash bosh","Section 7.3", "Problems 8-19");
      Console.WriteLine(item2.GetHomeworkList());
      WritingAssignment item3 = new WritingAssignment("Callie Marie","American History","Where Did my Shoes Go? A Disertation");
      Console.WriteLine(item3.GetWritingInfo());
    }
}