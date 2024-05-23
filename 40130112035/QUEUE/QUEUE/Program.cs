using System;

namespace QUEUE
{
 internal class Program
 {
  static void Main(string[] args)
  {
   int[,] maze = {
            { 0, 0, 0, 0},
            { 0, 1, 0, 1},
            { 0, 0, 0, 1},
            { 0, 1, 0, 0},

        };

   var start = (0, 0);
   var end = (2, 1);
   Q1 q1 = new Q1();



   int ShortPath = q1.ShortestPath(maze, start, end);
   if (ShortPath != -1)
   {
    Console.WriteLine($"Shortest path length is: {ShortPath}");
   }
   else
   {
    Console.WriteLine("No Path Found Or Size Of Queue Is Not Enouth For This Maze");
    //You Can Increase The Size Of Queue In MyQueue Class...
   }


   Console.ReadKey();
  }
 }
}
