using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Stack stack = new Stack();

             stack.Push(stack);
             Console.WriteLine("**************");

             stack.Pop();
             Console.WriteLine("**************");

             stack.clear();*/

             

            StackProgram stack = new StackProgram(5);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);


            stack.Display();

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            stack.clear();

            stack.Display();

            Console.ReadKey();
        }
        
    }
}
