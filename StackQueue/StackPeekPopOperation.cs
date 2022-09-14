using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    internal class StackPeekPopOperation
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

        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is on the top of the stack", this.top.data); ;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is deleted from the stack ", top.data);
            top = top.next;
        }

        public void IsEmpty()
        {
            while (this.top != null)
            {

                Peek();
                Console.WriteLine();
                Pop();
                Console.WriteLine();

            }
            Display();
        }
    }
}
