using System;
using System.Collections.Generic;
namespace DSStacksandQueues
{/// <summary>
/// Template for testing stack and queue
/// </summary>

    public class My_Queue<Gtype>
    {/// <summary>
     /// UC3 - create a Queue  
     /// </summary

        Node<Gtype> front;
        Node<Gtype> rare;


        public void Enqueue(Gtype data)
        {
            //creating node with given data
            Node<Gtype> node = new Node<Gtype>(data);

            //if the given element is first element
            //front element = rare element
            //we can check anyone either front or rare
            if (rare is null)
            {
                front = node;
                rare = node;
            }
            else
            {
                rare.next = node;
                rare = node;
            }
        }

        public void show()
        {
            //Created a temp variable
            Node<Gtype> temp = front;
            //traverse from front to last element and print element
            if (temp is null) Console.WriteLine("Queue is Empty");
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.value + " ");
                    temp = temp.next;
                }
                //to print the last value
                Console.WriteLine(temp.value);
            }
        }

    }
}
