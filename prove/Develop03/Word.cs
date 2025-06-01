class Word{
  private string text = "";
  private bool deleted = false;

  public Word(string yoWhaddup){
    text = yoWhaddup;
  }

  public string GetText(string replacement = "_"){
    if(deleted == true){
      string temp = "";
      for (int i = 0; i < text.Length; i++) {
        temp += replacement;
      }
      return temp;
    }
    return text;
  }
  public bool ReplaceWithChar(){
    if(deleted == true) return false;
    deleted = true;
    return true; //Whether or not it succeeds
  }
  public void Reset(){
    deleted = false;
  }
  /*
  public bool ReplaceWithChar(string replacement = "_"){
    if(deleted == true) return false;
    string temp = "";
    for (int i = 0; i < text.Length; i++) {
      temp += replacement;
    }
    text = temp;
    deleted = true;
    return true; //Whether or not it succeeds
  }
  */
}