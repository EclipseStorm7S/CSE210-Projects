using System;

class Program
{
    static void Main(string[] args)
    {
      List<Scripture> masteryList = new List<Scripture>();
      int removalCount = 3;

      Reference tempRef = new Reference("John",6,26);
      masteryList.Add(new Scripture(tempRef, "Jesus answered them and said, Verily, verily, I say unto you, Ye seek me, not because ye saw the miracles, but because ye did eat of the loaves, and were filled."));
      tempRef = new Reference("1st Nephi",3,7);
      masteryList.Add(new Scripture(tempRef, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
      tempRef = new Reference("D&C",6,34,36);
      masteryList.Add(new Scripture(tempRef, "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail.\n\nBehold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you.\n\nLook unto me in every thought; doubt not, fear not."));

      while(true){
        Console.Clear();
        Console.WriteLine("Welcome! Please choose a scipture:");
        for(int i = 1; i < masteryList.Count + 1; i++){
          Console.WriteLine($"{i}. {masteryList[i - 1].GetRef()}");
        }
        Console.WriteLine($"{masteryList.Count + 1}. Exit");
        int choice = Int32.Parse(Console.ReadLine()) - 1;
        if(choice == masteryList.Count) break;

        Console.WriteLine("How many words would you like to replace with each step?:");
        removalCount = Int32.Parse(Console.ReadLine());
        bool running = true;
        while(running){
          Console.Clear();
          Console.WriteLine(masteryList[choice].GetRef());
          Console.WriteLine(masteryList[choice].GetText());
          Console.WriteLine("Press enter to replace words, or type 'quit' to exit.");
          if(Console.ReadLine() == "quit")break;
          running = masteryList[choice].RemoveWords(removalCount);
        }
        masteryList[choice].ResetAll();
      }
    }
}