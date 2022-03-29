using System;
using System.Collections.Generic;
namespace DSStacksandQueues
{/// <summary>
/// Template for testing stack and queue
/// </summary>

    public class My_Stack<Gtype>
    {/// <summary>
    /// UC2 - Create a stack, peak, pop, till stack is empty
    /// </summary

        //variable
        Node<Gtype> top;

        //using Constructor
        public My_Stack()
        {
            this.top = null;
        }

        public void push(Gtype data)
        {
            //Created node
            Node<Gtype> node = new Node<Gtype>(data);
            //If top is null mark it as node,there is no linking
            if (top is null)
            {
                top = node;
            }
            else //make new node--> link with top---> mark it top
            {
                node.next = top;
                top = node;
            }
        }

        public void Show()
        {
            //start from top and traverse upto top
            Node<Gtype> temp_top = top;

            while (temp_top.next != null)
            {
                Console.Write(temp_top.value + " ");
                temp_top = temp_top.next;
            }
            Console.WriteLine(temp_top.value);
        }

        public Gtype Peak()
        {
            return top.value;  
        }

        public Gtype Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return default(Gtype);
            }
            //stack has one element  --> remove the element
            else if (top.next is null)
            {

                top = null;

            }
            else // remove top and assign top as  next element 
            {

                top = top.next;

            }
            return default(Gtype);
        }

        public bool IsEmpty()
        {
            if (top is null) return true;
            else return false;
        }
    }
}
