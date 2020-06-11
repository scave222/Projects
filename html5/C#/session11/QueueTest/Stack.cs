namespace QueueTest
{
    public class Stack
    {
        public int[] data;
        private const int DEFAULTSIZE = 20;
        private int head = 0;
        private int tail = 0;
        private int numElements = 0;

        public Stack()
        {
            data = new int[DEFAULTSIZE];
        }

        public void Push(int item)
        {
             if(numElements < data.Length)
            {
                data[head] = item;
                head++;
                head %= data.Length; //head = head % data.Length;
                numElements++;
            }else {
                throw new System.ArgumentOutOfRangeException("Stack is full...");
            }
        }

          public int Pop()
        {
            if(numElements != 0)
            {
                int item = data[head -1];
                head--;
                // tail %= data.Length; //tail = tail % data.Length;
                numElements--;
                return item;
            }else {
                throw new System.ArgumentOutOfRangeException("Stack is empty...");
            }
        }
    }
}