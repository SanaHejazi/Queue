using System;
using System.Text;

namespace QUEUE
{
 internal class Q3
 {
  Char[] Char;
  Char[] Queue;
  byte[] Value;
  int Front = 0;
  int Rear = 0;
  int index = 0;
  int size = 0;
  int Max;


  public void EnQueu(String Word)
  {
   Char = Word.ToCharArray();
   Value = Encoding.ASCII.GetBytes(Word);
   Queue = new Char[Char.Length];

   while (Char.Length != size)
   {
    Max = 0;
    for (int i = 0; i < Char.Length; i++)
    {
     if (Value[i] > Max)
     {
      Max = Value[i];
      index = i;
     }
    }

    Queue[Rear] = Char[index];
    Rear++;
    Value[index] = 0;
    size++;
   }




  }

  public Char DeQueue()
  {
   Char Index = Queue[Front];
   Queue[Front] = new char();
   Front++;
   return Index;
  }

  public bool IsEmpty()
  {
   return Front == Rear;
  }

  public int SIZE() { return size; }

  public void Print()
  {
   while (!IsEmpty())
   {
    Console.Write(Queue[Front] + " ");
    Front++;
   }

  }
 }
}

