class Chunk{

  protected Vector2 size;
  protected Vector2 focalPoint = new Vector2(-1,-1);
  private string[][] tileArray;
  protected List<Vector2> endPoints = new List<Vector2>();

  public Vector2 GetSize(){
    return size;
  }

  public Chunk(Vector2 inputSize){
    size = inputSize;
    // size = new Vector2(10,10);
    tileArray = new string[size.y][];
    for (int i = 0; i < tileArray.Length; i++) {
      tileArray[i] = new string[size.x];
      for (int j = 0; j < tileArray[i].Length; j++) {
        tileArray[i][j] = "██";
      }
    }
  }

  public string GetTileRow(int y){
    string tempString = "";
    foreach(string i in tileArray[y]){
      tempString += i;
    }
    return tempString;
  }

  protected void SetTile(Vector2 pos, string type = "  "){
    try{
      tileArray[pos.y][pos.x] = type;
      return;
    } catch (Exception) {
      return;
    }
  }

  protected void FillBlock(Vector2 posStart, Vector2 posEnd, string type = "  "){
    Vector2 i = posStart.Clone();
    Vector2 j = posStart.Clone();
    SetTile(posStart, type);
    while(i.x != posEnd.x){
      while(j.y != posEnd.y){
        j = j.MarchTowardsY(posEnd.y);
        SetTile(j, type);
      }
      i = i.MarchTowardsX(posEnd.x);
      SetTile(i, type);
      j = i.Clone();
    }
  }

  protected string GetTile(Vector2 pos){
    return tileArray[pos.y][pos.x];
  }

  protected virtual void PlaceRoom(){
    return;
  }

  public virtual void PlaceExits(string[] roomSides/* = ["top","right","bottom","left"] Not a compile-time constant???*/){
    Random rnd = new Random();
    foreach (string i in roomSides) {
      Vector2 newExit = new Vector2();
      switch(i){
        case "top":
          newExit = new Vector2(rnd.Next(size.x),0);
          endPoints.Add(newExit);
          break;
        case "right":
          newExit = new Vector2(size.x - 1, rnd.Next(size.y));
          endPoints.Add(newExit);
          break;
        case "bottom":
          newExit = new Vector2(rnd.Next(size.x),size.y - 1);
          endPoints.Add(newExit);
          break;
        case "left":
          newExit = new Vector2(size.x, rnd.Next(size.y));
          endPoints.Add(newExit);
          break;
      }
      //SetTile(newExit, "FF");
    }
    return;
  }

  public virtual void AlignExits(string side, Chunk alignment){
    //Console.WriteLine("eeby");
    foreach (Vector2 i in endPoints) {
      //Console.WriteLine(alignment.GetExitPoints()[0].x);
      foreach (Vector2 j in alignment.GetExitPoints()) {
        //Console.WriteLine("AAAAA");
        if(side == "left"){
          if (i.x == 0 && j.x == alignment.GetSize().x - 1) i.y = j.y;
          //Console.WriteLine("HeyHEy");
        }else if (side == "up") {
          if (i.y == 0 && j.y == alignment.GetSize().y - 1) i.x = j.x;
          //Console.WriteLine("Hey00");
        }else if (side == "right") {
          if (i.x == size.x - 1 && j.x == 0) i.y = j.y;
          //Console.WriteLine("Huuh");
        }else if (side == "down") {
          if (i.y == size.y - 1 && j.y == 0) i.x = j.x;
          //Console.WriteLine("what");
        }
      }
    }
  }

  public virtual void ConnectExits(){
    if (focalPoint.x + focalPoint.y == -2) return;
    Vector2 i = focalPoint.Clone();
    //SetTile(i , "FP");
    for(int b = 0; b < endPoints.Count(); b++){
      //i = focalPoint.Clone();
      i = focalPoint.Clone();
      Vector2 j = endPoints[b];
      Random rnd = new Random();
      SetTile(i);
      while ((i.x != j.x) || (i.y != j.y)){
        if (rnd.Next(2) == 0){
          i = i.MarchTowardsY(j.y);
        } else{
          i = i.MarchTowardsX(j.x);
        }
        SetTile(i);
      }
      SetTile(j);
      //endPoints.RemoveAt(0);
    }
    return;
  }

  public bool HasOpenExits(){
    if (endPoints.Count() > 0) return true;
    return false;
  }

  public List<Vector2> GetExitPoints(){
    return endPoints;
  }
}