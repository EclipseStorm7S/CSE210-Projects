class Chunk{

  protected Vector2 size;
  protected Vector2 focalPoint;
  private string[][] tileArray;
  protected Vector2[] endPoints;

  public Chunk(/*Vector2 inputSize*/){
    //size = inputSize;
    size = new Vector2(10,10);
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
    tileArray[pos.y][pos.x] = type;
  }
  protected string GetTile(Vector2 pos){
    return tileArray[pos.y][pos.x];
  }

  protected virtual void PlaceRoom(){
    return;
  }

  public virtual void PlaceExits(){
    return;
  }

  public virtual void ConnectExits(){
    return;
  }

  public bool HasOpenExits(){
    return false;
  }

  public Vector2[] GetExitPoints(){
    return [new Vector2(1,1)];
  }
}