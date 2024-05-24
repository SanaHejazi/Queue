using System;

namespace QUEUE
{
 internal class Program
 {
  static void Main(string[] args)
  {
   Console.WriteLine("\n" + "Q1");
   Q1 q1 = new Q1();
   Q2 q2 = new Q2();
   Q3 q3 = new Q3();

   int[,] maze = {
   { 0, 1, 0, 0},
   { 0, 1, 0, 1},
   { 0, 0, 0, 1},
   { 0, 1, 0, 0},

   };

   var start = (0, 0);
   var end = (3, 3);

   int shortpath = q1.ShortestPath(maze, start, end);
   if (shortpath != -1)
   {
    Console.WriteLine($"Shortest path length is: {shortpath}");
   }
   else
   {
    Console.WriteLine("No path found");
   }
   //--------------------------------------------------------------------------
   Console.WriteLine("\n" + "Q2");
   Console.WriteLine(q2.Josephus(7, 3));
   //--------------------------------------------------------------------------
   Console.WriteLine("\n" + "Q3");
   q3.EnQueu("ARYAN");
   Console.WriteLine(q3.DeQueue());
   Console.WriteLine(q3.DeQueue());
   q3.Print(); //After Deleting

   Console.ReadKey();
  }
 }
}
