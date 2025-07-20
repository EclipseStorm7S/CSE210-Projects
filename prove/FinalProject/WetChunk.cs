abstract class WetChunk : Chunk{
  private string liquid;

  public WetChunk(Vector2 inputSize) : base(inputSize){

  }
  public override void ConnectExits(){

  }
  protected abstract void PlaceLiquids();
}