using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class QueueEnqueueOperation
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
                //front=rear=newNode
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
    }
}
