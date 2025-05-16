using System.IO;


class Journal{
  List<JournalEntry> entries = new List<JournalEntry>();

  public void WriteToFile(string filename){
    using (StreamWriter outputFile = new StreamWriter(filename))
    {
      foreach (JournalEntry entry in entries){
        string[] exitry = entry.GetEntry();
        outputFile.WriteLine($"{exitry[0]}{exitry[1]}{exitry[2]}");
      }
      //outputFile.WriteLine("This will be the first line in the file.");
    }
  }

  public void ReadFromFile(string filename){
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string line in lines)
    {
      string[] parts = line.Split("");
      string date = parts[0];
      string prompt = parts[1];
      string entryText = parts[2];

      JournalEntry entry = new JournalEntry();
      entry.CreateEntry(date, prompt, entryText);
      this.AddEntry(entry);
    }
  }

  public void AddEntry(JournalEntry newEntry){
    entries.Add(newEntry);
  }

  public string ReadJournal(){
    string mediary = "";
    foreach (JournalEntry entry in entries){
      string[] exitry = entry.GetEntry();
      mediary += ($"{exitry[0]}\n{exitry[1]}\n{exitry[2]}\n------------\n");
    }
    return(mediary);
  }
}