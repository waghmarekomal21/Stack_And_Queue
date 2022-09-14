namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option\n 1 . Push operation on the stack\n 2. Peek and Pop operation on the stack\n 3. Enqueue operation on queue\n 4. Dequeue operation on queue");
            Console.WriteLine();
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
       
            switch (option)
            {
                case 1:
                    StackPushOperation stack1 = new StackPushOperation();
                    stack1.Push(70);
                    stack1.Push(30);
                    stack1.Push(56);
                    stack1.Display();
                    break;
                case 2:
                    StackPeekPopOperation stack2 = new StackPeekPopOperation();
                    stack2.Push(70);
                    stack2.Push(30);
                    stack2.Push(56);

                    stack2.IsEmpty();

                    stack2.Display();
                    break;
                case 3:
                    QueueEnqueueOperation queue1 = new QueueEnqueueOperation();
                    queue1.Enqueue(56);
                    queue1.Enqueue(30);
                    queue1.Enqueue(70);
                    queue1.Display();
                    break;
                case 4:
                    QueueDequeueOperation queue2 = new QueueDequeueOperation();
                    queue2.Enqueue(56);
                    queue2.Enqueue(30);
                    queue2.Enqueue(70);
                    queue2.IsEmpty();
                    queue2.Display();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}