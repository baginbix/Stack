using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push(13);
            Console.WriteLine(stack.Peek());
            stack.Pop();
            stack.Clear();
        }


        
    }
}
