class Vector2{
  public int x;
  public int y;

  public Vector2(){
    x = 0;
    y = 0;
  }
  public Vector2(int horiz, int vert){
    x = horiz;
    y = vert;
  }
  public Vector2 MarchTowardsX(int dest, int step = 1){
    if (x > dest) step = -step;
    Vector2 returnVal = new Vector2(x + step, y);
    return returnVal;
  }
  public Vector2 MarchTowardsY(int dest, int step = 1){
    if(y == dest) return new Vector2(x, y);
    if (y > dest) step = -step;
    Vector2 returnVal = new Vector2(x, y + step);
    return returnVal;
  }
  public Vector2 Clone()
   {
     return new Vector2(x,y);
   }
}