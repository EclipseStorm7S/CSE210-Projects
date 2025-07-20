class SimpleRoom : Chunk{
  private Vector2 roomSize;

  public SimpleRoom(Vector2 inputSize) : base(inputSize){
    PlaceRoom();
  }

  protected override void PlaceRoom(){
    Random rnd = new Random();
    roomSize = new Vector2(rnd.Next(size.x / 3, size.x),rnd.Next(size.y / 3, size.y));
    Vector2 rStart = new Vector2(rnd.Next(size.x - roomSize.x), rnd.Next(size.y - roomSize.y));
    Vector2 rEnd  = new Vector2(rStart.x + roomSize.x, rStart.y + roomSize.y); //REND THE HEAVENS
    focalPoint = new Vector2(rnd.Next(rStart.x, rEnd.x), rnd.Next(rStart.y, rEnd.y));
    FillBlock(rStart,rEnd);
  }
}