namespace QUEUE
{
 internal class Q1
 {
  public int ShortestPath(int[,] maze, (int, int) start, (int, int) end)
  {


   int rows = maze.GetLength(0);
   int cols = maze.GetLength(1);

   if (maze[start.Item1, start.Item2] == 1 || maze[end.Item1, end.Item2] == 1)
   {
    return -1;   //If Start Or End OF The Patch Was Block...
   }
   bool[,] visited = new bool[rows, cols];
   int[,] directions = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };




   MyQueue CurrentRow = new MyQueue();
   MyQueue CurrentCol = new MyQueue();
   MyQueue CurrenDist = new MyQueue();
   CurrentRow.init();
   CurrentCol.init();
   CurrenDist.init();


   CurrentRow.Enqueue(start.Item1);
   CurrentCol.Enqueue(start.Item2);
   CurrenDist.Enqueue(0);
   visited[start.Item1, start.Item2] = true;

   while (CurrentRow.Size() > 0)
   {
    var currentRow = CurrentRow.DeQueue();
    var currentCol = CurrentCol.DeQueue();
    var currentDist = CurrenDist.DeQueue();

    if (currentRow == end.Item1 && currentCol == end.Item2)
    {
     return currentDist;
    }

    for (int i = 0; i < directions.GetLength(0); i++)
    {
     int newRow = currentRow + directions[i, 0];
     int newCol = currentCol + directions[i, 1];

     if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols &&
         maze[newRow, newCol] == 0 && !visited[newRow, newCol])
     {

      CurrentRow.Enqueue(newRow);
      CurrentCol.Enqueue(newCol);
      CurrenDist.Enqueue(currentDist + 1);
      visited[newRow, newCol] = true;
     }
    }
   }

   return -1;
  }
 }
}
