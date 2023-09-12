using System;

namespace PriorityQueue
{
    public class PriorityQClass
    {

      internal int[] Pqueue = new int[100];
      internal int Count=-1;

        internal  void Heapify( int i)
        {
           
            int temp;
            int largest = i;
            int left= (2 * i)+1;
            int right = (2 * i )+ 2;
            if (left <= Count  && Pqueue[left] > Pqueue[largest])
                largest = left;
            if (right <= Count && Pqueue[right] > Pqueue[largest])
                largest = right;
            if(largest!=i)
            {
                temp = Pqueue[largest];
                Pqueue[largest] = Pqueue[i];
                Pqueue[i] = temp;
                Heapify(largest);
              
            }

        }
        internal void Enqueue(int data)
        {
           if(Count>99)
           {
                Console.WriteLine("Queue is full");
                return;
           }
            
          Pqueue[++Count] = data;
          for(int i=(Count-1/2);i>=0;i--)
          {
                Heapify(i);
          }
         
        }
        internal void PqPrint()
        {
            if (Count<0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine(" Priority Queue elements:");
            for (int i=0;i<=Count;i++)
            {
                Console.Write("  "+Pqueue[i]); 
            }
            Console.WriteLine();
        }
        internal void Dequeue()
        {
            if (Count<0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            int temp;
            temp = Pqueue[0];
            Pqueue[0] = Pqueue[Count];
            Pqueue[Count] = temp;
            Console.WriteLine("Dequeue element :" + Pqueue[Count]);
            Count--;
           
            Heapify(0);


        }
        internal void PQcenter()
        {
            if (Count < 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("The center of Queue is : "+Pqueue[(Count+1)/2]);
        }
        internal void PQpeek()
        {
            if (Count < 0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("The Peek element is: "+Pqueue[0]);
        }
        internal void PqConrain(int data)
        {
            if(Count<0)
            {
                Console.WriteLine("Empty Priority Queue");
            }
            else
            {
                int f = 0;
                for (int i = 0; i <= Count; i++)
                {
                    if (Pqueue[i] == data) 
                    {
                        f++;
                        break;
                    }
                }
                if(f!=0)
                    Console.WriteLine($"{data} is found ");
                else
                {
                    Console.WriteLine( $"{data} is not found");
                }
            }

        }
        internal void RevPQ()
        {
            if (Count < 0)
            {
                Console.WriteLine("Empty Priority Queue");
            }
            else
            {
                for (int i = 0; i <= Count/2; i++)
                {
                    int temp = Pqueue[i];
                    Pqueue[i] = Pqueue[Count - i];
                    Pqueue[Count - i] = temp;
                }
            }

        }
        
        internal void Size()
        {
            Console.WriteLine("Size of PQ:"+(Count+1));
        }

    }
}
