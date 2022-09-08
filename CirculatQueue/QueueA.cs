namespace CircularQueue
{
    class QueueA
    {
        private int[] queueArray;
        private int front;
        private int rear;


        public QueueA()
        {
            queueArray = new int[10]; ;
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
            return front == -1;
        }
        public bool IsFull()
        {
            return ((front == 0 && rear == queueArray.Length - 1) || (front == rear + 1));
        }
        public void Insert(int x)
        {
            
            if (IsFull())
            {
                Console.WriteLine("Queue overflow");
                return;
            }
            if (front == -1)
                front = 0;
            if (rear == queueArray.Length - 1)
            {
                rear = 0;
            }
            else
            {
                rear = rear + 1;
            }
            queueArray[rear] = x;
        }
    }

}