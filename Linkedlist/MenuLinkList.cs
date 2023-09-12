using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
  public  class MenuLinkList
  {

        public void  LLMenuMethod()
        {
            int ch = 0;

            LinkedList List = new LinkedList();
            while (ch != -1)
            {
                
                Console.WriteLine(" --------:Linked list:-------");
                Console.WriteLine("     1.   Add at Frist Place");
                Console.WriteLine("     2.   Add at Last place");
                Console.WriteLine("     3.   Add at any Position");
                Console.WriteLine("     4.   Delete from any Position");
                Console.WriteLine("     5.   Find Center ");
                Console.WriteLine("     6.   Reverse List ");
                Console.WriteLine("     7.   Sort the list ");
                Console.WriteLine("     8.   check element Contain or not");
                Console.WriteLine("     9.   Print the list ");
                Console.WriteLine("    -1.   Exit ");
                Console.WriteLine(" -----------------------------------");
                Console.Write(" Enter the choice of Linked list:");
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
                        List.AddNodeAtFrist(Num);
                        break;
                    case 2:
                        Console.Write(" Enter the Interger Number to add :");
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                        }
                        List.AddNodeAtLast(Num);

                        break;
                    case 3:
                        Console.Write(" Enter the position of element you want to Add:");
                       
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Enter interger input number.\n");
                        }
                        Console.WriteLine("Enter the Number want to add: ");
                        int num2;
                        if (!int.TryParse(Console.ReadLine(), out num2))
                        {
                            Console.WriteLine("Enter interger input number.\n");
                        }

                        List.AddAnyPos(Num,num2);

                        break;
                    case 4:
                        Console.Write(" Enter the position of element you want to Delete:");

                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Enter interger input number.\n");
                        }
                      

                        List.DeleteAnyPos(Num);

                        break;
                    case 5:
                        List.GetCenter();
                        break;
                    case 6:
                        List.RevList();
                         break;
                    case 7:
                        List.LLSort();
                        break;
                    case 8:
                        Console.Write(" Enter the Number:");

                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Enter interger input number.\n");
                        }
                        bool f=List.LLContain(Num);
                        Console.WriteLine($"{Num} contain:"+f);

                        break;
                    case 9:
                        List.PrintAllNodes();
                        break;
                    case -1:
                        Console.WriteLine(" !!! Exit from LinkedList !!!");
                        break;

                    default:
                        Console.WriteLine("Enter Right Choice");
                        break;
                }
            }

            //List.AddNodeAtFrist(10);
            //List.AddNodeAtFrist(8000);
            //List.AddNodeAtFrist(700);
            //List.AddNodeAtFrist(200);
            //List.PrintAllNodes();
            //List.LLSort();
            //List.PrintAllNodes();

           
            




        }

  }

}
