using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class QueueNode
    {
        internal QueueNode Next;
        internal int Value;
        public QueueNode(int data)
        {
            this.Value = data;
            this.Next = null;
    
        }

    }
}
