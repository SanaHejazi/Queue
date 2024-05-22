using System;

namespace QUEUE
{
 internal class Program
 {
  static void Main(string[] args)
  {
   MyPriorityQueue myPriorityQueue = new MyPriorityQueue();
   myPriorityQueue.init();
   myPriorityQueue.EnQueue(10, 2);
   myPriorityQueue.EnQueue(7, 1);
   myPriorityQueue.EnQueue(9, 4);
   myPriorityQueue.EnQueue(11, 3);
   Console.WriteLine(myPriorityQueue.DeQueue());
   Console.WriteLine(myPriorityQueue.DeQueue());
   Console.WriteLine(myPriorityQueue.DeQueue());
   Console.WriteLine(myPriorityQueue.DeQueue());


   Console.ReadKey();
  }
 }
}
