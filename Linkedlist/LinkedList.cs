using System;

namespace Linkedlist
{
    public class LinkedList
    {
        public Node Head;
        internal Node Current;
        public int Count = 0;
        public LinkedList()
        {
            Head = new Node(-1);
            Current = Head;
        }
        internal void AddNodeAtFrist(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = Head.Next;
            Head.Next = newNode;
            Count++;

        }
        internal void AddNodeAtLast(int data)
        {
            Node newNode = new Node(data);
            Node temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            newNode.Next = null;
            temp.Next = newNode;
            Count++;
        }
        internal void PrintAllNodes()
        {
            Console.Write("Head ->");
            Node curr = Head;
            while (curr.Next != null)
            {


                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write(" ->");
            }
            Console.WriteLine("NULL");
        }
        internal void AddAnyPos(int pos, int data)
        {
            Node temp = Head;
            int i = 0;
            if (pos > Count + 1 || pos < 1)
            {
                Console.WriteLine($"Please Enter value between 1-{Count + 1} beacuse current total number of  node  is {Count} ");
            }
            else
            {
                while (i < pos - 1)
                {
                    temp = temp.Next;
                    i++;
                }
                Node newNode = new Node(data);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                Count++;

            }
        }
        internal void DeleteAnyPos(int pos)
        {
            Node temp = Head;
            int i = 0;
            if (Count <= 0)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
          else if (pos > Count + 1 || pos < 1)
          {
                Console.WriteLine($"Please Enter value between 1-{Count} beacuse current total  number of node  is {Count} ");
          }
            
            else
            {
                while (i < pos - 1)
                {
                    temp = temp.Next;
                    i++;
                }
                temp.Next = temp.Next.Next;
                Count--;

            }



        }
        internal void GetCenter()
        {
            if (IsEmptyLL())
            {
                Console.WriteLine("The Linkedlist is empty");
                return;
            }

            Node temp1 = Head.Next;
            Node temp2 = Head.Next;
            while (temp2 != null && temp2.Next != null)
            {
                temp1 = temp1.Next;
                temp2 = temp2.Next.Next;
            }
            Console.WriteLine("Center :"+temp1.Value);
            
        }
        internal void RevList()
        {
            if(IsEmptyLL())
            {
                Console.WriteLine("The Linkedlist is empty");
                return;
            }
            Node Previous = null;
            Node Cur = Head.Next;
            Node Tnext = null;
            while (Cur != null)
            {
                Tnext = Cur.Next;
                Cur.Next = Previous;
                Previous = Cur;
                Cur = Tnext;
            }
            Head.Next = Previous;

        }
        internal bool LLContain(int key)
        {
            if (IsEmptyLL())
                return false;
            else
            {
                Node temp = Head.Next;
                while (temp != null)
                {
                    if (temp.Value == key)
                        return true;
                    temp = temp.Next;

                }
                return false;

            }
        }

        internal bool IsEmptyLL()
        {
            if (Head.Next == null)
                return true;
            else
               return false;
        }
        internal void LLsize()
        {
            Console.WriteLine("Size of LL: "+Count); 
        }

        public void LLSort()
        {
            Node current = Head;
            Node index = null;
            int temp;
            if (IsEmptyLL())
            {
                Console.WriteLine("List is empty");
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





    }
}
