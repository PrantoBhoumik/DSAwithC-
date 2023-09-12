using System;

namespace Queue
{
   public class MenuQueue
   {
       public void  QueueMenuMethod()
       {
            int ch = 0;
            QueueClass Queue1 = new QueueClass();
            while (ch != -1)
            {

                Console.WriteLine(" --------:Queue:-------");
                Console.WriteLine("     1.   Enqueue");
                Console.WriteLine("     2.   Dequeue");
                Console.WriteLine("     3.   Print ");
                Console.WriteLine("     4.   Size ");
                Console.WriteLine("     5.   Find Center ");
                Console.WriteLine("     6.   Reverse Queue ");
                Console.WriteLine("     7.   Sort the Queue ");
                Console.WriteLine("     8.   check element Contain or not");
                Console.WriteLine("     9.   Peek ");
                Console.WriteLine("    -1.   Exit ");
                Console.WriteLine(" -----------------------------------");
                Console.Write(" Enter the  choice for queue:");
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
                        Queue1.Enqueue(Num);
                        break;

                        
                    case 2:
                        Queue1.Dequeue();

                        break;
                    case 3:
                        Queue1.PrintQueue();

                        break;
                    case 4:

                        Queue1.QueueSize();
                        break;
                    case 5:
                        Queue1.QueueCenter();
                        break;
                    case 6:
                        Queue1.RevQueue();
                        break;
                    case 7:
                        Queue1.QueueSort();
                        break;
                    case 8:
                        Console.Write(" Enter the Interger Number to Check :");
                        
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                        }
                        Console.WriteLine($"{Num} contain: "+ Queue1.QueueContain(Num)); 
                        break;
                    case 9:
                        Queue1.QueuePeek();
                        break;
                    case -1:
                        Console.WriteLine(" !!! Exit from Queue !!!");
                        break;

                    default:
                        Console.WriteLine("Enter Right Choice");
                        break;
                }
            }
            


            

        }
    }
}
