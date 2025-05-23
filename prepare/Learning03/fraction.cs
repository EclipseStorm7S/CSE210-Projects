class Fraction{
  private int _topNumb;
  private int _botNumb;

  public Fraction(){
    _topNumb = 1;
    _botNumb = 1;
  }
  public Fraction(int a){
    _topNumb = a;
    _botNumb = 1;
  }
  public Fraction(int a, int b){
    _topNumb = a;
    _botNumb = b;
  }

  public void SetTop(int a){
    _topNumb = a;
  }
  public int GetTop(){
    return(_topNumb);
  }
  public void SetBot(int a){
    _botNumb = a;
  }
  public int GetBot(){
    return(_botNumb);
  }

  public string GetFractionString(){
    return($"{_topNumb} / {_botNumb}");
  }
  public double GetDecimalValue(){
    return((float)_topNumb / (float)_botNumb);
  }
}