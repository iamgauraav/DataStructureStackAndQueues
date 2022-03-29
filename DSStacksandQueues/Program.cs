using System;

namespace DSStacksandQueues
{/// <summary>
/// 
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            My_Stack<int> my_Stack = new My_Stack<int>();

            my_Stack.push(70);
            my_Stack.push(30);
            my_Stack.push(56);
            my_Stack.Show();
            my_Stack.Peak();
            my_Stack.Pop();
            //my_Stack.IsEmpty();
            my_Stack.Show();


        } 
    }
}
