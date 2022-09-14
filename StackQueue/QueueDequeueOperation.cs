using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class QueueDequeueOperation
    {
        Node front;
        Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (rear == null)
            {
                rear = newNode;
                front = rear;
            }
            else
            {
                rear.next = newNode;
                rear = newNode;
            }
        }

        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (front != null)
            {
                Console.Write(front.data + "  ");
                front = front.next;
            }
        }

        public void Dequeue()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine("{0} is deleted from the queue", front.data);
            front = front.next;
        }

        public void IsEmpty()
        {
            while (front != null)
            {
                Dequeue();
                Console.WriteLine();
            }
        }
    }
}
