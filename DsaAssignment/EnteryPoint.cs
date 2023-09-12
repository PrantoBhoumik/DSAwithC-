using System;
using Stack;
using Linkedlist;
using Queue;
using PriorityQueue;
using HashTable;
namespace DsaAssignment
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int ch = 0;
            while (ch != -1)
            {

                Console.WriteLine(" --------:DSA Assignment Menu:-------");
                Console.WriteLine("     1.   LinkedList");
                Console.WriteLine("     2.   Stack");
                Console.WriteLine("     3.   Queue");
                Console.WriteLine("     4.   Priority Queue");
                Console.WriteLine("     5.   Hash Table ");
                Console.WriteLine("    -1.   Exit ");
                Console.WriteLine(" -----------------------------------");
                Console.Write(" Enter your Choice of Exercise: ");

                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Plz Select correct item.\n");
                }
                switch(ch)
                {
                    case 1:
                        MenuLinkList obj1 = new MenuLinkList();
                        obj1.LLMenuMethod();
                        break;
                    case 2:
                        MenuStack obj2 = new MenuStack();
                        obj2.StackMenuMethod();
                        break;
                    case 3:
                        MenuQueue obj3 = new MenuQueue();
                        obj3.QueueMenuMethod();
                        break;
                    case 4:
                        MenuPQueue obj4 = new MenuPQueue();
                        obj4.PQMenuMethod();
                        break;
                    case 5:
                        MenuHashTable obj5 = new MenuHashTable();
                        obj5.HtMenuMethod();
                        break;
                    case -1:
                        Console.WriteLine(" !!! -------Thanks------- !!!");
                        break;

                    default:
                        Console.WriteLine("Enter Right Choice");
                        break;
                }
            }
        }
    }
}
