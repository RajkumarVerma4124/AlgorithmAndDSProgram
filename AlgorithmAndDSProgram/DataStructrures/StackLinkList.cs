using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{ 
    public class StackLinkList<G> where G : IComparable
    {
        public Node<G> head;

        public StackLinkList()
        {
            this.head = null;
        }

        //Creating add first method to add the element at first position i.e head
        public void AddFirst(G data)
        {
            Node<G> newNode = new Node<G>(data);
            newNode.next = this.head;
            this.head = newNode;
        }

        //Displaying the data from linklist nodes
        public void Display()
        {
            //Storing the head to temp node
            Node<G> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkList Is Empty");
                Console.ReadLine();
            }
            else
            {
                Console.Write("The Elements In Stack Are : ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.ReadLine();
            }
        }
    }
}
