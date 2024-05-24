using System;

namespace QUEUE
{
 internal class MyPriorityQueue
 {
  private int[] MainQueue;
  private int[] Values;
  private int[] priorities;
  private int size;
  int Front;
  int Rear;
  public void init()
  {
   MainQueue = new int[10];
   Values = new int[10];
   priorities = new int[10];
   size = 0;
   Front = 0;
   Rear = 0;
  }

  public bool IsEmpty()
  {
   return size == 0;
  }

  public int Size()
  {
   return size;
  }

  public void EnQueue(int value, int priority)
  {
   if (size == Values.Length)
   {
    Console.WriteLine("Priority Queue is full");
   }

   int i;
   for (i = size - 1; i >= 0; i--)
   {
    if (priorities[i] < priority)
    {
     Values[i + 1] = Values[i];             //Shift Be Rast Mide Ta Bozorgtaring Arzesh Ro Dakhel khone Aval Value Bezare
     priorities[i + 1] = priorities[i];
    }
    else
    {
     break;
    }
   }

   Values[i + 1] = value;
   priorities[i + 1] = priority;
   size++;

   Rear = 0;
   MainQueue[Front] = Values[0];
   for (int j = 0; j < Values.Length; j++)
   {
    if (Values[j] == 0)   //Dont Wasting Time In Puting zERO Value In Main Queue...
    {
     break;
    }
    MainQueue[Rear] = Values[j];
    Rear++;
   }
  }
  public int DeQueue()
  {
   if (IsEmpty())
   {
    Console.WriteLine("Priority Queue is empty");
   }
   else
   {
    int Index = MainQueue[Front];
    MainQueue[Front] = 0;
    Front++;
    size--;
    return Index;
   }

   return -1;
  }

 }
}
