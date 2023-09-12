using System;

namespace HashTable
{
    public class MenuHashTable
    {
        public void HtMenuMethod()
        {
            int ch = 0;
            var ht = new HashTable<int, string>();
            while (ch != -1)
            {
                Console.WriteLine(" --------:Hash Table:-------");
                Console.WriteLine("     1.   Insert");
                Console.WriteLine("     2.   Delete");
                Console.WriteLine("     3.   element Contain Or Not");
                Console.WriteLine("     4.   Get value by key ");
                Console.WriteLine("     5.   Size");
                Console.WriteLine("     6.   Print ");
                Console.WriteLine("     7.   itaretor");
                Console.WriteLine("     -1.  Exit ");
                Console.WriteLine(" ---------------------------");
                Console.Write("Enter the Choice for Hash table: ");
                if (!int.TryParse(Console.ReadLine(), out ch))
                {
                    Console.WriteLine("Plz Select correct Choice with interger input number.\n");
                }
                switch (ch)
                {
                    case 1:
                        here:
                        Console.Write(" Enter the Interger key to  be add :");
                        int Num;
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                            goto here;
                        }
                        String value;
                        Console.WriteLine("Enter the value: ");
                        value = Console.ReadLine();
                        ht.Insert(Num, value);

                        break;
                    case 2:
                        Console.Write(" Enter the Interger key to be Remove:");
                        repeat:
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                            goto repeat; 
                        }
                        Console.WriteLine($"Removing value by key {Num} :{ht[Num]}");
                        ht.Remove(Num);
                        break;
                    case 3:
                        Console.Write(" Enter the Interger key to be found:");
                        level:
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                            goto level;
                        }
                        Console.WriteLine($"Does hashmap contain value by key {Num}: {ht.ContainsKey(Num)}");
                        break;
                    case 4:
                        Console.Write(" Enter the Interger key to be found:");
                        r:
                        if (!int.TryParse(Console.ReadLine(), out Num))
                        {
                            Console.WriteLine("Plz Enter interger input number.\n");
                            goto r;
                        }
                        Console.WriteLine($"Getting value by key {Num}: {ht[Num]}");

                        break;

                    case 5:
                        Console.WriteLine($"Size of HashTable: {ht.Size}");
                        break;
                    case 6:
                        ht.Print();
                        break;
                    case 7:
                        Console.WriteLine("Iterating through key-value pairs:");
                        foreach (var pair in ht)
                        {
                            Console.WriteLine($"{pair.Key}->{pair.Value}");
                        }
                        break;
                    case -1:
                        Console.WriteLine(" ---Exit from Hashtable----");
                        break;
                    default:
                        Console.WriteLine("Enter right Choice");
                        break;
                }
                
            }

        }


    }
}
