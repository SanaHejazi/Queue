using System;

namespace QUEUE
{
 internal class MyQueue //Impelimenting With Array MaxSize Of 50...
 {
  int Front;
  int Rear;
  int[] Queue;

  public void init()
  {
   Front = 0;
   Rear = 0;
   Queue = new int[50];
  }

  public int Max()
  {
   try
   {
    return Queue.Length;
   }
   catch (Exception e)
   {

    throw new Exception(e.Message);
   }

  }

  public bool IsEmpty()
  {
   return Front == Rear;
  }

  public void Enqueue(int data)
  {
   if (Rear == Max())
   {
    Console.WriteLine("Queue Is Full !");
   }
   else
   {
    Queue[Rear] = data;
    Rear++;
   }
  }

  public int DeQueue()
  {
   if (IsEmpty()) { Console.WriteLine("Queue Is Empty !"); }
   else
   {
    int Index = Queue[Front];
    Queue[Front] = 0;
    Front++;
    return Index;
   }
   return -1;
  }

  public int Size()
  {
   return Rear - Front;
  }
 }
}
