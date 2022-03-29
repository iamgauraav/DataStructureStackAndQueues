using System;
using System.Collections.Generic;
namespace DSStacksandQueues
{
    public class Node<Gtype>
    {
        public Gtype value;
        public Node<Gtype> next;
        public Gtype data;

        public Node(Gtype data)
        {
            this.value = data;
            this.next = null;
        }
    }
}
