using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    //Creating Queue
    public class Queue<G>
    {
        private Node<G> head;
        public Queue()
        {
            this.head = null;
        }

        //Method to insert the value into Queue
        public void Enqueue(G data)
        {
            Node<G> newNode = new Node<G>(data);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node<G> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted into queue ", newNode.data);
        }

        //Method to delete the value from begining in queue
        public void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                this.head = this.head.next;
            }
        }

        //Method to check queue is empty or not
        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            else
               return false; 
        }

        //Method to display the size of the queue
        public int Size()
        {
            int size = 0;
            Node<G> temp = this.head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            return size;
        }

        //Method to display the value in Queue
        public void Display()
        {
            Node<G> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.Write("The elements in queue are : ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
