using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2.heap
{
    class Heap
    {        
        private Node[] nodes;      
        public Heap()
        {                      
        }
        public  Node minheap(int i)//i is the index of  last item it i passed to avoid a loop for deleting last element
        { Node temp;
            Node max;
            int count;
            count = i;
            int j = 1;
            if (nodes == null || count == 0)
            {
                return null;
            }
            if (nodes[1] == null)
                return null;
            temp = nodes[1];
             // delete last node                
                if (i <= 0)
                    return null;
            if (i == 1)
                return temp;
            count++;//instead of using j<=count
            nodes[1] = nodes[i];
            nodes[i] = null;
            while (j < count)
            {
                max = nodes[j];
                i = j;
                if (2 * i < count)
                { if (nodes[2 * i] != null)// if node it have left child
                    {
                        if (nodes[2 * i].priority <= nodes[i].priority) //compare left node with parent
                        {
                            if (2 * i + 1 < count)
                            {
                                if (nodes[2 * i + 1] != null)
                                {
                                    if (nodes[2 * i].priority <= nodes[2 * i + 1].priority)
                                    {
                                        max = nodes[2 * i];
                                        nodes[2 * i] = nodes[i];

                                        nodes[i] = max;
                                        j = 2 * i;


                                    }
                                    else

                                    {

                                        max = nodes[2 * i + 1];
                                        nodes[2 * i + 1] = nodes[i];
                                        nodes[i] = max;
                                        j = 2 * i + 1;

                                    }


                                }
                            }
                            else
                            {
                                max = nodes[2 * i];
                                nodes[2 * i] = nodes[i];
                                nodes[i] = max;
                                j = 2 * i;

                            }
                            
                        }

                    }


                }

                if (2 * i + 1 < count)
                {
                    if (nodes[2 * i + 1] != null)
                    {
                        if (i==j)
                        {                                                           
                                    if (nodes[2 * i + 1].priority <= nodes[i].priority)
                                    {
                                        max = nodes[2 * i + 1];
                                        nodes[2 * i + 1] = nodes[i];
                                        nodes[i] = max;
                                        j = 2 * i + 1;
                                    }                                                            
                        }
                    }                    
                }

                if (i == j)
                    j = count;

            }                      
            return temp;
        }
        public void insert(Node n, int i)
        {

            if (nodes == null || nodes.Length == 0)
            {
                nodes = new Node[2];
                nodes[1] = n;
                return;
            }
            if (i >= nodes.Length)
            {
                Node[] newnodes  = new Node[i * 2];
                nodes.CopyTo(newnodes, 0);
                nodes = newnodes;
            }
            nodes[i] = n;    
            Node temp;
            while (i > 1)
            {
                
                if (i % 2 == 0)
                {
                   
                    if (nodes[i].priority < nodes[i / 2].priority) //check if the parent had per >left child
                    {
                        temp = nodes[i / 2];
                        nodes[i / 2] = nodes[i];
                        nodes[i] = temp;
                        i = i / 2;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else
                {
                    
                    if (nodes[i].priority < nodes[(i-1) / 2].priority) //check if the parent has per >right child per
                    {
                        temp = nodes[i / 2];
                        nodes[i / 2] = nodes[i];
                        nodes[i] = temp;
                        i = (i - 1) / 2;
                    }
                    else
                    {
                        i = 0;
                    }                    
                }
            }                              
        }
    }
}
