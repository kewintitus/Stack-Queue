using System;

namespace StackArray
{
    class StackA
    {
        private int[] stack_Array;
        private int top;

        public StackA()
        {
            stack_Array = new int[10];
            top = -1;
        }

        public StackA(int maxSize)
        {
            stack_Array = new int[maxSize];
            top = -1;
        }
        public int Size()
        {
            return top + 1; 
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            return (stack_Array.Length - 1 == top);
        }

        public void Push(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            top = top + 1;
            stack_Array[top] = x;
        }
        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            x = stack_Array[top];
            top = top - 1;
            return x;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack Underflow");
            }
            int x = stack_Array[top];
            return x;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Stack is : ");
            for(int i = top; i>=0; i--)
            {
                Console.Write(stack_Array[i] + " ");
            }
            Console.WriteLine();
        }
    }

}