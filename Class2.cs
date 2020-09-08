using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
    class StackProgram
    {
        private int[] _element;
        private int _top;
        private int _max;

        public StackProgram(int size)
        {
            _element = new int[size];
            _max = size;
            _top = -1;
        }

        public void Push(Object obj)
        {
            if (_top == _max - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            else
            {
                _element[_top = _top + 1] = (int)obj;
            }
        }

        public int Pop()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Popped element is:" + _element[_top]);
                return _element[_top--];
            }
        }

        public void clear()
        {
            Array.Clear(_element, 1, 2);
            Console.WriteLine("Stack is empty");
        }

        public void Display()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for (int i = 0; i <= _top; i++)
                {
                    Console.WriteLine("Stack elements are: " + _element[i]);
                }
            }
        }


    }
}
