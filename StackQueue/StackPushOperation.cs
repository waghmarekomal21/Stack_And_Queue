using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class StackPushOperation
    {

        Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }

            while (top != null)
            {
                Console.WriteLine("|" + top.data + "|");
                top = top.next;
            }
        }
    }
}
