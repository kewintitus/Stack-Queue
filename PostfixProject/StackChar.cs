using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostfixEvaluate
{
    internal class StackChar
    {
        private char[] stackArray;
        private int top;

        public StackChar()
        {
            stackArray = new char[10];
            top = -1;

        }
        public StackChar(int maxSize)
        {
            stackArray = new char[maxSize];
            top = -1;
        }
        public int  Size()
        {
            return top + 1;
        }
        public bool IsEmpty()
        {
            return (top == -1);
        }
        public bool IsFull()
        {
            return (stackArray.Length - 1 == top);
        }
        public void Push(char x) 
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            top=top + 1;
            stackArray[top] = x;
        }
        public char Pop()
        {
            char x;
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow\n");
                throw new System.InvalidOperationException();
            }
            x = stackArray[top];
            top = top - 1;
            return x;
        }
        public char Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow\n");
                throw new System.InvalidOperationException();
            }
            return stackArray[top];
        }
        public void Display()
        {
            int i;
            Console.WriteLine("top= " + top);

            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Stack is : ");
            for (i = top; i >= 0; i--)
                Console.WriteLine(stackArray[i] + " ");
            Console.WriteLine();
        }
    }
}
