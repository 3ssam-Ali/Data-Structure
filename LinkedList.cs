using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    //node class 
    public class Node<generic>
    {
        public generic Data;
        public Node<generic> Next;
        public Node<generic> Prev;
        public Node() { }

        public Node(generic date)
        {
            this.Data = date;
        }
    }

    public class LinkedList<generic>
    {
        public Node<generic> Head;
        public Node<generic> Tail;
        public static int Count = 0;

        
        //public void AddFirst() { } 
        
        //public void insert()   { }

        public void Add(generic item) 
        {
            if (Head == null)
            {
                this.Head = new Node<generic>(item);
                this.Tail = Head;
                Count++;
                
                
            }
            else
            {
                Node<generic> Current = new Node<generic>(item);
                Current.Prev = Tail;
                Tail.Next= Current;
                Tail = Current;
                Count++;
            }
        }

        public Node<generic> Find(generic item)
        {
            Node<generic> current = Head;
            while (current != null)
            {

                if (Equals(item,current.Data)) return current;

                

                current = current.Next;
            }
            //if nothing found, return null
            return null;
        }

        public void Remove(generic data)
        {
            Node<generic> current = Find(data);
            //if it is the head
            if (ReferenceEquals(current, Head))
            {
                Head = current.Next;
            }
            //if it is the tail
            else if (ReferenceEquals(current, Tail))
            {
                Tail = current.Prev;
            }
            else if (current==null)
            {
                Console.WriteLine("Item doesn't exist");
            }
            else
            {
                current.Next.Prev = current.Prev;
                current.Prev.Next = current.Next;
                current = null;
                Count--;
            }
        }
    }
    
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> test = new LinkedList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            DisplayAllNodes(test);
            test.Remove(3);
            Console.WriteLine();
            Console.WriteLine("after removing 3");
            DisplayAllNodes(test);

            Console.ReadLine();
        }

        public static void DisplayAllNodes(LinkedList<int> list)
        {
            Node<int> cursor = list.Head;
            while (cursor != null)
            {
                Console.Write(cursor.Data+" ");
                cursor = cursor.Next;
            }
            Console.WriteLine();
        }
    }
}
