using System;

namespace Queue
{
    public class QueueClass
    {
        internal QueueNode Front;
        internal QueueNode Rear;
        internal int Count;
        public QueueClass()
        {
            Front = new QueueNode(-1);
            Rear = new QueueNode(-1);
          

        }
        internal void Enqueue(int data)
        {
            QueueNode newNode = new QueueNode(data);
            if(IsEmptyQueue())
            {
                Front.Next= newNode;
                Rear.Next= newNode;
                Count++;
            }
            else
            {
                newNode.Next = Rear.Next;
                Rear.Next = newNode;
                Count++;
            }
        }
        internal void Dequeue()
        {
            if (IsEmptyQueue())
            {
                Console.WriteLine("The Queue is empty");
            }
         
            else
            {
                QueueNode temp = Rear.Next;
                if(Count==1)
                {
                    Console.WriteLine("Dequeue element is:"+temp.Value);
                    Front.Next = null;
                    Rear.Next = null;
                    Count--;
                }
                else
                {

                    while (temp.Next != Front.Next)
                    {
                        temp = temp.Next;
                    }

                    Console.WriteLine("Dequeue element is:" + Front.Next.Value);
                    Front.Next = temp;
                    temp.Next = null;


                    Count--;
                }
            }
        }
        internal bool IsEmptyQueue()
        {
            if (Rear.Next== null && Front.Next==null)
                return true;
            else
                return false;
        }
        public int QueuePeek()
        {
            int n;
            if (IsEmptyQueue())
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            else
            {
                n = Front.Next.Value;
                Console.WriteLine("peek element:" + n);
                return n;
            }


        }
        internal void QueueCenter()
        {
          
            
            
                int str;
                QueueNode temp = Rear.Next;
                if (IsEmptyQueue())
                {
                    Console.WriteLine("the Queue is empty");
                    str = -1;
                }
                   
                else if (Count == 1)
                    str = Front.Next.Value;
                else
                {
                    for(int i=1;i<=Count/2;i++)
                    {
                        temp = temp.Next;
                    }
                    str = temp.Value;
                }

                Console.WriteLine("Current Stack Center is " + str);
            
        }
        internal void PrintQueue()
        {
            if (IsEmptyQueue())
            {
                Console.WriteLine("the Queue is empty");
                
            }
            else
            {
                QueueNode curr = Rear;
                Console.Write("queue values are:\nRear-");
                while (curr.Next != Front.Next)
                {
                    curr = curr.Next;
                    Console.Write(curr.Value + "  ");

                }
                Console.WriteLine(curr.Next.Value + "-Front");
            }
         
        }
        internal void RevQueue()
        {
            QueueNode temp = Rear.Next;
            QueueNode Previous = null;
            QueueNode Cur = Rear.Next;
            QueueNode Tnext = null;
            while (Cur != null)
            {
                Tnext = Cur.Next;
                Cur.Next = Previous;
                Previous = Cur;
                Cur = Tnext;
            }
            Rear.Next = Previous;

            Front.Next = temp;
        }
        internal void QueueSort()
        {



            QueueNode current = Rear;
            QueueNode index = null;
            int temp;
            if (IsEmptyQueue())
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            else
            {


                while (current != null)
                {
                    index = current.Next;
                    while (index != null)
                    {
                        if (current.Value > index.Value)
                        {
                            temp = current.Value;
                            current.Value = index.Value;
                            index.Value = temp;
                        }

                        index = index.Next;
                    }
                    current = current.Next;
                }
            }

        }
        internal bool QueueContain(int key)
        {
            if (IsEmptyQueue())
                return false;
            else
            {
                QueueNode temp =Rear.Next;
                while (temp != null)
                {
                    if (temp.Value == key)
                        return true;
                    temp = temp.Next;

                }
                return false;

            }

        }
        internal void QueueSize()
        {
            Console.WriteLine("the Current queue Size :" + Count);
        }


    }


}
