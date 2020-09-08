using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    public class Stack
    {

        Stack<int> myList = new Stack<int>();

        public void Push(Object obj)
        {

            myList.Push(1);
            myList.Push(2);
            myList.Push(3);
            myList.Push(4);
            myList.Push(5);

            foreach (var item in myList)
            {
                Console.WriteLine("Stack items are : " + item);

            }
            Console.WriteLine("Totla items are: " + myList.Count);
        }

        public void Pop()
        {
            while (myList.Count > 0)
            {
                Console.WriteLine(myList.Pop());
            }
            Console.WriteLine("Remaining items are: " + myList.Count);
        }

        public void clear()
        {
            myList.Clear();
            Console.WriteLine("Stack is empty");
        }
    }
}
