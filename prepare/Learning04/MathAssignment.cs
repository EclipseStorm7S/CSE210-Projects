class MathAssignment : Assignment{
  private string TextbookSection;
  private string problems;

  public MathAssignment(string a, string b, string c, string d) : base(a,b){
    TextbookSection = c;
    problems = d;
  }
  public string GetHomeworkList(){
    return($"{GetSummary()}\n{TextbookSection}, {problems}");
  }
}