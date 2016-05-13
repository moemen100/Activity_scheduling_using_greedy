using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.heap
{
    class Node
    {

        public object value { get; set; }
        public int priority { get; set; }
        public Node()
        { }
        public Node(object value, int priority)
        {
            this.value = value;
            this.priority = priority;

        }


    }
}
