using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.heap
{
    class Control
    {
        private int i = 0;
        private Heap h = new Heap();
        private List<Node> nodes = new List<Node>();
        public Control()
        {

        }
        public void addactivity(object value, int priority)
        {
            i++;
            h.insert(new Node(value, priority), i);


        }
        public Node dequeue()
        {


            try
            {

                var temp = h.minheap(i);
                i--;
                return temp;

            }
            catch (NullReferenceException)
            {
                return null;
            }


        }


    }
}
