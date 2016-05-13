using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.heap;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Control p = new Control();
            int[] time = new int[20];
            Node j;
            int last = 0;
            // add loop here for adding activity 
            p.addactivity(1, 8);
            p.addactivity(1, 2);
            p.addactivity(2, 3);
            p.addactivity(4, 8);
            p.addactivity(5, 9);
            p.addactivity(6, 9);
            p.addactivity(8, 9);
            p.addactivity(9, 10);
            p.addactivity(5, 9);

            while (last>=0 )// n times at most it will break if no more element in the heap 
            {
                try {
                    j = p.dequeue(); // (logn)
                    if ((int)j.value < time[last])//if this start time <end time of last atcivity don't care 
                    { }
                    else
                    {
                        // this node with me;
                        last++;
                        time[last] = j.priority;  
                        System.Diagnostics.Debug.WriteLine("from: "+j.value + " to: "+j.priority);

                    }
                }
                catch (NullReferenceException)
                {
                    break;
                        }
            }
        }
    }
}
