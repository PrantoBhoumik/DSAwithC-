using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class MenuStack
    {
        public  void StackMenuMethod()
        {
            int ch= 0;
            StackClass sc = new StackClass();
            while (ch != -1)
            {

                Console.WriteLine(" --------:Stack:-------");
                Console.WriteLine("     1.   Push");
                Console.WriteLine("     2.   Pop");
                Console.WriteLine("     3.   print The Stack");
                Console.WriteLine("     4.   Size ");
                Console.WriteLine("     5.   Find Center ");
                Console.WriteLine("     6.   Reverse Stack ");
                Console.WriteLine("     7.   Sort the Stack ");
                Console.WriteLine("     8.   check element Contain or not");
                Console.WriteLine("     9.   Peek");
                Console.WriteLine("    -1.   Exit ");
                Console.WriteLine(" -----------------------------------");
                Console.Write(" Enter the Stack choice:");
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
                        sc.Push(Num);

                        break;
                    case 2:
                        sc.Pop();
                        break;
                    case 3:
                        sc.PrintStack();
                        break;
                    case 4:
                        sc.StackSize();
                        break;
                    case 5:
                        sc.StackCenter();
                        break;
                    case 6:
                        sc.RevStack();
                        break;
                    case 7:
                        sc.StackSort();
                        break;
                    case 8:
                        Console.Write(" Enter the Interger to be found:");
                       
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                        }
                        Console.WriteLine($"{Num} Contain :"+ sc.StacKContain(Num)); 
                        break;
                    case 9:
                        sc.Peek();
                        break;
                    case -1:
                        Console.WriteLine(" !!! Exit from Stack !!!");
                        break;

                    default:
                        Console.WriteLine("Enter Right Choice");
                        break;
                }
            }


          
        }
    }
}
