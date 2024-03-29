﻿using DataStructures.Algorithms.DataStructures;
using DataStructures.Data_Structures;
using System;

namespace DataStructures.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Stack usage with integer
            //Stack<int> stack = new Stack<int>();
            //stack.Push(2);
            //stack.Push(3);
            //for(int i = 0; i< 100; i++)
            //{
            //    stack.Push(i);
            //}
            //stack.Pop();
            //stack.Print();
            //Console.WriteLine(stack.Size);

            ////Queue usage with integer
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(2);
            //queue.Enqueue(23);
            //queue.Enqueue(223);
            //queue.Print();
            //queue.Dequeue();
            //queue.Print();
            //Console.WriteLine(queue.Size);

            //Linked List usage
            LinkedList<int> linkedList = new LinkedList<int>(2);
            linkedList.InsertAtEnd(5);
            Console.WriteLine(linkedList.Size);
            linkedList.InsertAt(0, 3);
            linkedList.InsertAt(0, 8);
            linkedList.Print();
            Console.WriteLine(linkedList.Size);

        }
    }
}
