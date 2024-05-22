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
    throw new InvalidOperationException("Priority Queue is full");
   }

   int i;
   for (i = size - 1; i >= 0; i--)
   {
    if (priorities[i] > priority)
    {
     Values[i + 1] = Values[i];
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
    if (Values[j] == 0)
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
    throw new InvalidOperationException("Priority Queue is empty");
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
