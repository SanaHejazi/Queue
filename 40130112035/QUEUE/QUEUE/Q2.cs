namespace QUEUE
{
 internal class Q2
 {

  public bool OneElement(MyCircularQueue queue)
  {
   int count = 0;
   for (int m = 0; m < queue.Size(); m++)
   {
    if (queue.DeQueue() != 0)
    {
     count++;
    }

   }
   if (count == 1)
   {
    return true;
   }
   else { return false; }

  }
  public int Josephus(int n, int k)
  {
   MyCircularQueue JosephQue = new MyCircularQueue();
   JosephQue.init(n + 1);
   for (int i = 0; i < n; i++)
   {
    JosephQue.EnQueue(i + 1);
   }

   //------------------------------

   while (JosephQue.Size() > 1)
   {

    for (int i = 0; i < k - 1; i++) //Dobare To List Mirizim Vali K omin Ro Nemirizim(Hazf Mishe)...
    {
     JosephQue.EnQueue(JosephQue.DeQueue());
    }
    JosephQue.DeQueue();  //Hazf k omin Value...
   }

   return JosephQue.DeQueue();
  }
 }
}
