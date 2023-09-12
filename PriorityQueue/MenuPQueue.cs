using System;

namespace PriorityQueue
{
   public class MenuPQueue
   {
        public void PQMenuMethod()
        {
            int ch = 0;
            PriorityQClass PQ = new PriorityQClass();
            while (ch != -1)
            {

                Console.WriteLine(" --------:Priority Queue :-------");
                Console.WriteLine("     1.   Enqueue");
                Console.WriteLine("     2.   Dqueue");
                Console.WriteLine("     3.   Peek ");
                Console.WriteLine("     4.   Print ");
                Console.WriteLine("     5.   Size ");
                Console.WriteLine("     6.   Find Center ");
                Console.WriteLine("     7.   Reverse Priority Queue ");
                Console.WriteLine("     8.   check element Contain or not");
                Console.WriteLine("    -1.   Exit ");
                Console.WriteLine(" -----------------------------------");
                Console.Write(" Enter the  choice of Priority Queue:");
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Plz Select correct Choice with interger input number.\n");
                }
                switch (ch)
                {
                    case 1:
                        Console.Write(" Enter the Interger Number to add :");
                        int Num;
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                        }
                        PQ.Enqueue(Num);
                        break;
                    case 2:
                        PQ.Dequeue();
                        break;
                    case 3:
                        PQ.PQpeek();
                        break;
                    case 4:
                        PQ.PqPrint();

                        break;
                    case 5:
                        PQ.Size();

                        break;
                    case 6:
                        PQ.PQcenter();
                        break;
                    case 7:
                        PQ.RevPQ();
                        break;
                   
                    case 8:
                        Console.Write(" Enter the Interger Number to add :");
                        
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                        }
                        PQ.PqConrain(Num);
                        break;
                    case -1:
                        Console.WriteLine(" !!! Exit from Priority Queue !!!");
                        break;

                    default:
                        Console.WriteLine("Enter Right Choice");
                        break;
                }
            }
          
            

        }
        
   }
}
