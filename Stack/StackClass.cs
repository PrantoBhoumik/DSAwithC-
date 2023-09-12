using System;

namespace Stack
{
    public class StackClass
    {
        internal StackNode Top;
        internal int Count;
        public StackClass()
        {
            Top = new StackNode(-1);
          
        }
       internal void Push(int data)
       {
            StackNode newNode = new StackNode(data);
            newNode.Next = Top.Next;
            Top.Next = newNode;
            Count++;
       }
        internal void Pop()
        {
            if(IsEmptyStack())
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                int data = Top.Next.Value;
                Console.WriteLine("Pop element:"+data);
                Top.Next = Top.Next.Next;
                Count--;
            }
        }
        internal bool IsEmptyStack()
        {
            if (Top.Next == null)
                return true;
            else
                return false;
        }
        public int Peek()
        {
            int n;
            if (IsEmptyStack())
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            else
            {
                n = Top.Next.Value;
                Console.WriteLine("peek element:"+n);
                return n;
            }


        }
        internal void StackCenter()
        {
            if(IsEmptyStack())
            {
                Console.WriteLine("the stack is empty");
                return;
            }
            else
            {
                int str;
                StackNode temp1 = Top.Next;
                StackNode temp2 = Top.Next;
                while (temp2 != null && temp2.Next != null)
                {
                    temp1 = temp1.Next;
                    temp2 = temp2.Next.Next;
                }
                str = temp1.Value;
                Console.WriteLine("Current Stack Center is: " + str);
            }
        }
        internal void PrintStack()
        {
            StackNode curr = Top;
            Console.WriteLine("Stack values are:");
            Console.Write("Top->");
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value+"   ");
               
            }
            Console.WriteLine(" ");
           
        }
        internal void RevStack()
        {
            if (IsEmptyStack())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            StackNode Previous = null;
            StackNode Cur = Top.Next;
            StackNode Tnext = null;
            while (Cur != null)
            {
                Tnext = Cur.Next;
                Cur.Next = Previous;
                Previous = Cur;
                Cur = Tnext;
            }
            Top.Next = Previous;
        }
        internal bool StacKContain(int key)
        {
            if ( IsEmptyStack())
                return false;
            else
            {
                StackNode temp = Top.Next;
                while(temp!=null)
                {
                    if (temp.Value == key)
                        return true;
                    temp = temp.Next;
                        
                }
                return false;

            }

        }
        internal void StackSort()
        {
            StackNode current = Top;
            StackNode index = null;
            int temp;
            if (IsEmptyStack())
            {
                Console.WriteLine("Stack is empty");
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
        internal void StackSize()
        {
            Console.WriteLine("the Current Stack Size :"+Count);
        }

    }
}
