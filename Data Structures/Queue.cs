using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms.DataStructures
{
    public class Queue<T>
    {
        //Variables accessible to class only
        private List<T> queue = new List<T>();
        private int size = 0;

        //Property that returns size
        public int Size
        {
            get
            {
                return size;
            }
        }

        //Method to push items to the stack
        public void Enqueue(T item)
        {
            queue.Add(item);
            size++;
        }

        //Method to pop items from the stack
        public object Dequeue()
        {
            if (size > 0)
            {
                T retVal = queue[0];
                queue.RemoveAt(0);
                size--;
                return retVal;
            }
            return null;

        }

        public void Print()
        {
            Console.WriteLine(String.Join(" | ", queue));
        }

        //Method to clear items from the stack
        public void Clear()
        {
            queue.Clear();
            size = 0;
        }

    }
}
