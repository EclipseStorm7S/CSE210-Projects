class Assignment{
  private string studentName;
  private string topic;
  public Assignment(string a, string b){
    studentName = a;
    topic = b;
  }

  public string GetSummary(){
    return($"{studentName}, {topic}");
  }
  public string GetStudentName(){
    return(studentName);
  }
}