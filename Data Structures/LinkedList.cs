using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Data_Structures
{
    public class Node<T>
    {
        public Node(T Val)
        {
            this.Val = Val;
        }
        public T Val;
        public Node<T> Next;
    }

    public class LinkedList<T>
    {
        private Node<T> Head;

        //Constructor
        public LinkedList(T HeadValue)
        {
            Head = new Node<T>(HeadValue);
        }

        //Inserts Node at a specific position
        public void InsertAt(int Position, T Value)
        {
            if(Position == 0)
            {
                InsertAtBeginning(Value);
                return;
            }
            var temp = Head;
            int i = 0;
            while(i != Position-1 && temp != null)
            {
                temp = temp.Next;
                i++;
            }

            var tail = temp.Next;
            temp.Next = new Node<T>(Value);
            temp.Next.Next = tail;
        }

        //Insert Node at the Beginning
        public void InsertAtBeginning(T Value)
        {
            Node<T> node = new Node<T>(Value);
            node.Next = Head;
            Head = node;
        }

        //Insert Node at the End
        public void InsertAtEnd(T Value)
        {
            var temp = Head;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = new Node<T>(Value);
        }

        //Clear the content of the LinkedList
        public void ClearLinkedList()
        {
            Head = null;
        }

        //Returns the Size of the List
        public int Size
        {
            get
            {
                int i = 0;
                var temp = Head;
                while(temp != null)
                {
                    temp = temp.Next;
                    i++;
                }
                return i;
            }
        }

        //Display contents of Linked List
        public void Print()
        {
            var temp = Head;
            while(temp != null)
            {
                Console.Write(" | " + temp.Val);
                temp = temp.Next;
            }
            Console.WriteLine();
        }

    }
}
