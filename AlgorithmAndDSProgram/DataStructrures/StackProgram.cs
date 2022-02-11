using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class StackProgram<G>
    {
        private Node<G> top;
        public StackProgram()
        {
            this.top = null;
        }

        //Creating a push method in stack to add values at top(UC1)
        public void Push(G data)
        {
            Node<G> newNode = new Node<G>(data);
            if (this.top != null)
            {
                newNode.next = this.top;
                top = newNode;
            }
            this.top = newNode;
            Console.WriteLine("{0} is added to the top in stack", newNode.data);
        }

        //Creating a display method in stack to view values(UC1)
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node<G> temp = this.top;
                while (temp != null)
                {
                    Console.WriteLine("Stack contain value : {0}", temp.data);
                    temp = temp.next;
                }
            }
        }

        //Method to display the size of the queue
        public int Size()
        {
            int size = 0;
            Node<G> temp = this.top;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

        //Method to show the top value in stack(UC2)
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is top value in stack", this.top.data);
        }

        //Method to delete the top element from the stack(UC2)
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Top value {0} is deleted", this.top.data);
            this.top = this.top.next;
        }

        //Method to find and delete the top value until stack is empty(UC2)
        public bool IsEmpty()
        {
            if (this.top == null)
                return true;
            else
                return false;
        }
    }
}
