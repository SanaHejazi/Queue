using System;

namespace QUEUE
{
 internal class MyCircularQueue
 {
  int Front;
  int Rear;
  int[] Queue;
  bool oneway = false;

  public void init(int maxsize)
  {
   Front = 0;
   Rear = 0;
   Queue = new int[maxsize];
  }

  public int Max()
  {
   try
   {
    return Queue.Length;
   }
   catch (Exception)
   {

    throw new Exception("You Have To Init Queue First !");
   }

  }

  public int Size()
  {
   return (Max() + (Rear - Front)) % Max();
  }

  public bool IsEmpty()
  {
   return Front == Rear;
  }

  public bool IsFull()
  {
   return (Rear) % Max() == Front;
  }


  public void EnQueue(int data)
  {
   if (IsFull() && oneway)
   {
    Console.WriteLine("Queue Is Full !");
   }
   else
   {
    Queue[Rear] = data;
    if (Rear != Max() - 1)
    {
     Rear = (Rear % (Max())) + 1;
    }
    else
    {
     Rear = Rear % (Max() - 1);
     oneway = true;
    }

   }
  }

  public int DeQueue()
  {
   if (IsEmpty() && oneway == false) { Console.WriteLine("Queue Is Empty !"); }
   else
   {
    int Index = Queue[Front];
    Queue[Front] = 0;
    if (Front != Max() - 1)
    {
     Front = (Front % (Max())) + 1;
    }
    else
    {
     Front = Front % (Max() - 1);
    }
    return Index;
   }
   return -1;
  }

  public Array GetArray() { return Queue; }
 }
}