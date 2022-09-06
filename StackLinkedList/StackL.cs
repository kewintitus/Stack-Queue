using System;

namespace StackLinkedList
{
    class StackL
    {
        private Node top;

        public StackL()
        {
            top = null;
        }
        public int Size()
        {
            int s= 0;
            Node p = top;
            while(p != null)
            {
                s++;
                p = p.link;
            }
            return s;
        }
        public bool IsEmpty()
        {
            return (top == null);
        }

        public void Push(int x)
        {
            Node temp = new Node(x);
            temp.link = top;
            top = temp;
        }

        public int Pop()
        {
            int x;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack underflow");
            }
            x = top.info;
            top = top.link;
            return x;
        }
        public int Peek()
        {
            if(IsEmpty())
                throw new System.InvalidOperationException("Stack underflow");
            return top.info;        
        }

        public void Display()
        {
            Node p = top;
            if (IsEmpty())
            {
                throw new System.InvalidOperationException("Stack underflow");
            }
            while (p!=null)
            {
                Console.Write(p.info + " ");
                p = p.link; 
            }
            Console.WriteLine();
        }
    }
}