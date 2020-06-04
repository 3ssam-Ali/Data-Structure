using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class MyArrayList<generic> //generic type place holder  that will e replaced  later
    {
        private generic[] arr;
        private int counter;

        private const int default_size = 16;

        public int Count { get { return this.count; } }

        //initialization of the array list as empty array
        public MyArrayList(int capacity = default_size)
        {
            this.arr = new generic[];
            this.counter = 0;
        }

        //grow the array to the double if needed
        private checkIfFull()
        {
            if (this.counter + 1 > this.arr.Length)
            {
                generic[] Temp_arr = new generic[this.arr.Length * 2];
                Array.Copy(this.arr, Temp_arr, this.counter);
                this.arr = Temp_arr;
            }
        }

        public void Add(generic item)
        {
            checkIfFull();
            arr[this.counter++] = item;
        }

        public void AddRange(generic[] range)
        {
            foreach (var item in range)
            {
                Add(item);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int>[] test = new MyArrayList<int>[4];
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            int[] CustomRange = { 6, 7, 8, 9, 10 };
            test.AddRange(CustomRange);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }


        }
    }
}
