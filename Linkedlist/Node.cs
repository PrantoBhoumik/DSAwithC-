using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
   public class Node
    {
        internal Node Next;
        internal int Value;
        public Node(int data)
        {
            this.Value = data;
            this.Next = null;
        }

    }
}
