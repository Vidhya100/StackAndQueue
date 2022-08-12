using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Node
    {
        public int data;
        public Node next;
        //public Node prev;

        public Node(int data)
        {
            //for not taking garbage value
            this.next = null;
           // this.prev = null;
            this.data = data;
        }
    }
}
