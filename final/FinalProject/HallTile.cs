class HallTile : Chunk{

  public HallTile(Vector2 inputSize) : base(inputSize){
    Random rnd = new Random();
    focalPoint = new Vector2(rnd.Next(size.x), rnd.Next(size.y));
  }
}