using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class queueImp<generic>
    {
        private int capacity= 10000, start = 0, last = 0;
        private generic[] queue;
        public queueImp()
        {
            queue = new generic[10000];
           
        }

        public queueImp(int capacity)
        {
            queue = new generic[capacity];
            this.capacity = capacity;
        }
        public void Add(generic item)
        {
            //will resize if exceeded the capacity
            if (last>=capacity)
            {

                if (capacity>=int.MaxValue)
                {
                    Console.WriteLine("Queue limit reached");
                    return ;
                }
                
                generic[] temp = new generic[capacity*2];
                Array.Copy(queue, temp,capacity );
                queue = temp;

            }
            
            queue[last] = item;
            last++;
            Console.WriteLine("Added item : " + item);

        }

        public void Remove()
        {
            if (start==last)
            {
                Console.WriteLine("no items to remove");
                return;
            }
            Console.WriteLine("Removed : " +queue[this.start++]);


        }
        public generic Show()
        {
            return queue[start];
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            queueImp<string> test = new queueImp<string>();
            test.Add("Essam");
            test.Add("Ali");
            test.Add("Elshereif");
            Console.WriteLine(test.Show());
            test.Remove();
            Console.WriteLine(test.Show());
            test.Remove();
            test.Add("test");
            Console.WriteLine(test.Show());
            Console.ReadLine();
        }
    }
}
