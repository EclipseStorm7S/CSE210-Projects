class WritingAssignment : Assignment{
  private string title;

  public WritingAssignment(string a, string b, string c) : base(a,b){
    title = c;
  }
  public string GetWritingInfo(){
    return($"{GetSummary()}\n{title} by {GetStudentName()}");
  }
}