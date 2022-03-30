using System;

namespace DSStacksandQueues
{/// <summary>
/// 
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            My_Queue<int> my_Queue = new My_Queue<int>();

            my_Queue.Enqueue(56);
            my_Queue.Enqueue(30);
            my_Queue.Enqueue(70);
            my_Queue.show();
            my_Queue.Dequeue();
            my_Queue.show();
            my_Queue.ISEmpty();
            my_Queue.show();




        } 
    }
}
