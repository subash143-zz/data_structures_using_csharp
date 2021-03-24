using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithms.DataStructures
{
    public class Stack<T>
    {
        //Variables accessible to class only
        private List<T> stack = new List<T>();
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
        public void Push(T item)
        {
            stack.Add(item);
            size++;
        }

        //Method to pop items from the stack
        public object Pop()
        {
            if (size > 0)
            {
                T retVal = stack[size - 1];
                stack.RemoveAt(size - 1);
                size--;
                return retVal;
            }
            return null;

        }

        public void Print()
        {
            Console.WriteLine(String.Join(" | ", stack));
        }

        //Method to clear items from the stack
        public void Clear()
        {
            stack.Clear();
            size = 0;
        }

    }
}
