using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
   public class StackNode
    {
        internal StackNode Next;
        internal int Value;
        public StackNode(int data)
        {
            this.Value = data;
            this.Next = null;
        }


    }
}
