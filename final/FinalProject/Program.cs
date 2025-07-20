class Program
{
  public static void Main(string[] args)
  {

    Vector2 chunkCount = new Vector2(6,6);
    Vector2 chunkSize = new Vector2(8,7);
    Random rnd = new Random();

    Console.WriteLine("Welcome to my map generator! UI is lacking due to time constraints :/ If you want to change the values you'll have to do it manually in the code.\n");
    Console.WriteLine($"Generating map...\nparameters:\nChunk placement: {chunkCount.x}x{chunkCount.y}\nChunk Size: {chunkSize.x}x{chunkSize.y}\n");

    Chunk[][] mapFloor = new Chunk[chunkCount.y][];
    for (int i = 0; i < mapFloor.Length; i++) {
      mapFloor[i] = new Chunk[chunkCount.x];
      for (int j = 0; j < mapFloor[i].Length; j++) {
        if (rnd.Next(2) == 0){
          mapFloor[i][j] = new SimpleRoom(chunkSize);
        } else {
          mapFloor[i][j] = new HallTile(chunkSize);
        }

        string[] exitPoints = ["top","right","bottom","left"];
        if (i == 0) exitPoints[0] = "";
        if (i == mapFloor.Length - 1) exitPoints[2] = "";
        if (j == 0) exitPoints[3] = "";
        if (j == mapFloor[i].Length - 1) exitPoints[1] = "";
        //Console.WriteLine($"Exits placed with string {exitPoints[0]} {exitPoints[1]} {exitPoints[2]} {exitPoints[3]}");
        mapFloor[i][j].PlaceExits(exitPoints);
        //Console.WriteLine($"Exit at {mapFloor[i][j].GetExitPoints()[0].x}");
      }
    }

    for (int i = 0; i < mapFloor.Length; i++) {
      for (int j = 0; j < mapFloor[i].Length; j++) {
        if(i > 0) mapFloor[i][j].AlignExits("up",mapFloor[i-1][j]);
        if(j > 0) mapFloor[i][j].AlignExits("left",mapFloor[i][j-1]);
        mapFloor[i][j].ConnectExits();
        //Console.WriteLine($"Exits Aligned at chunk {i}, {j}");
      }
    }


    string outputString = "██";
    string border = "████";
    for (int i = 0; i < chunkSize.x * chunkCount.x ; i++) {
      border += "██";
    }
    Console.WriteLine(border);
    //Console.WriteLine(chunkCount.y);
    for (int i = 0; i < chunkCount.y; i++) {
      //Console.WriteLine(i);
      int row = 0;
      int j = 0;
      //Console.WriteLine();
      while(row < chunkSize.y) {
        //outputString += " ";
        outputString += mapFloor[i][j].GetTileRow(row);
        j++;
        if(j >= chunkCount.x){
          j = 0;
          row++;
          Console.WriteLine(outputString + "██");
          outputString = "██";
        }
      }
      //outputString += "/n";
    }
    Console.WriteLine(border);
  }
}