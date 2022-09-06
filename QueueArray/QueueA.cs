using System;

namespace QueueArray
{
    class QueueA
    {
        private int[] queueArray;
        private int front;
        private int rear;

        public QueueA()
        {
            queueArray = new int[10];
            front = -1;
            rear = -1;
        }
        public QueueA(int maxSize)
        {
            queueArray = new int[maxSize];
            front = -1;
            rear= -1;
        }
        public bool IsEmpty()
        {
            return (front == -1 || front == rear + 1);
        }

        public bool IsFull()
        {
            return (rear == queueArray.Length -1);    
        }

        public int Size()
        {
            if (IsEmpty())
            {
                return 0;
            }
            else
            {
                return rear - front +1;
            }
        }

    }

}