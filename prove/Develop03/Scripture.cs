class Scripture{
  private Reference scripRef = null;
  private Word[] scripText = null;
  private int wordsHidden = 0;

  public Scripture(Reference reference, string words){ //naming it "ref" actually did cause problems :D
    scripRef = reference;
    scripText = StringToWordArray(words);
  }

  private Word[] StringToWordArray(string wordyBoi){
    List<Word> returnList = [];
    foreach (string oneWord in wordyBoi.Split(' '))
    {
      returnList.Add(new Word(oneWord));
    }
    return returnList.ToArray();
  }

  public bool RemoveWords(int removalCount){
    Random rand = new Random();
    removalCount = Math.Min(scripText.Length - wordsHidden,removalCount);
    if(removalCount == 0) return false;
    wordsHidden += removalCount;
    for (int i = 0; i < removalCount;) {
       if (scripText[rand.Next(scripText.Length)].ReplaceWithChar()) i++;
    }
    return true;
  }

  public string GetRef(){
    return scripRef.GetText();
  }

  public string GetText(){
    string temp = "";
    foreach (Word i in scripText) temp += " " + i.GetText();
    return ($"{temp}");
  }

  public void ResetAll(){
    foreach (Word i in scripText) i.Reset();
  }
}