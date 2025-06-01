class Reference{
  private string refBook = "";
  private int refChapter = 0;
  private int startVerse = 0;
  private int endVerse = 0;

  public Reference(string a, int b, int c, int d = 0){
    refBook = a;
    refChapter = b;
    startVerse = c;
    endVerse = d;
  }

  public string GetText(){
    if (endVerse==0) return ($"{refBook} {refChapter}:{startVerse}");
    else return ($"{refBook} {refChapter}:{startVerse}-{endVerse}");
  }
}