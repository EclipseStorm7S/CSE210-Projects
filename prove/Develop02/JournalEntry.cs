class JournalEntry{
  string date = "";
  string prompt = "";
  string entryText = "";

  public JournalEntry(string x,string y, string z){
    date = x;
    prompt = y;
    entryText = z;
  }

  public string[] GetEntry(){
    string[] x = [date,prompt,entryText];
    return(x);
  }
}