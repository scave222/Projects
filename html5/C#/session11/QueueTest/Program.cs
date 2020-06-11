using System;

namespace QueueTest
{
    class Program
    {
        static void Main(string[] args)
        {
           Stack stack = new Stack();
           stack.Push(54);
           stack.Push(23);
           stack.Push(34);
           stack.Push(78);
           stack.Push(94);
           stack.Push(68);
           

           Console.WriteLine($"Item removed: {stack.Pop()}");
           Console.WriteLine($"Item removed: {stack.Pop()}");
           Console.WriteLine($"Item removed: {stack.Pop()}");
           Console.WriteLine($"Item removed: {stack.Pop()}");        
           Console.WriteLine($"Item removed: {stack.Pop()}");
           Console.WriteLine($"Item removed: {stack.Pop()}");

            try
            {
                Console.WriteLine($"Item removed: {stack.Pop()}");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            // Queue  queue = new Queue();
            // queue.QueueItem(60m);
            // queue.QueueItem(30m);
            // queue.QueueItem(20m);


            // Console.WriteLine($"Item removed: {queue.DeQueueItem()}");
            // Console.WriteLine($"Item removed: {queue.DeQueueItem()}");
            // Console.WriteLine($"Item removed: {queue.DeQueueItem()}");


            // try
            // {
            //     Console.WriteLine($"Item removed: {queue.DeQueueItem()}");
            // }
            // catch (System.Exception ex)
            // {
            //     Console.WriteLine($"{ex.Message}");
            // }
        }
    }
}
