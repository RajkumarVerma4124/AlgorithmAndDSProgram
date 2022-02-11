using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class UnorderedList<G> where G : IComparable
    {
        public Node<G> head;

        public UnorderedList()
        {
            this.head = null;
        }

        //Method for creating a empty list
        public UnorderedList<G> List()
        {
            UnorderedList<G> list = new UnorderedList<G>();
            return list;
        }

        //Refactored the lastadd method to take element to get in sorted order
        public void AddLast(G data)
        {
            Node<G> node = new Node<G>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<G> temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.Write("{0} is added into linklist \n", node.data);
        }

        //Creating add first method to add the element at first position i.e head
        public void AddFirst(G data)
        {
            Node<G> newNode = new Node<G>(data);
            newNode.next = this.head;
            this.head = newNode;
            Console.WriteLine("{0} is inserted into linklist \n", newNode.data);
        }

        //Creating append method to add the element at last position i.e tail
        public void Append(G data)
        {
           AddLast(data);
        }

        //Inserting the element at particular index
        public void InsertAt(int index, G data)
        {
            Node<G> node = new Node<G>(data);
            if (index < 0)
                Console.WriteLine("Invalid Position");
            else if (this.head == null)
                Console.WriteLine("LinkList Is Empty");
            else if (index == 0)
                AddFirst(data);
            else
            {
                Node<G> temp = this.head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
                Console.WriteLine("Element Is Inserted\n");
            }
        }

        //Deleting the first element
        public G DeleteFirst()
        {
            if (this.head == null)
                Console.WriteLine("LinkList Is Empty");
            G deletedNode = this.head.data;
            this.head = this.head.next;
            return deletedNode;
        }

        //Deleting the last element
        public G DeleteLast()
        {
            Node<G> newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("LinkList Is Empty");
                return default;
            }
            else if (this.head.next == null)
            {
                G deletedNode = this.head.data;
                this.head = null;
                return deletedNode;
            }
            else if (this.head != null && this.head.next != null)
            {
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
            }
            G lastDeletedNode = newNode.next.data;
            newNode.next = null;
            return lastDeletedNode;
        }

        //Search the node element
        public int Search(G data)
        {
            int index = -1;
            Node<G> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(data))
                {
                    index++;
                    return index;
                }
                index++;
                temp = temp.next;
            }
            Console.WriteLine("{0} is not present in the current linklist", data);
            return -1;
        }

        //Deleting the given element from linklist
        public G Delete(G data)
        {
            if (this.head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                int indexDel = Search(data);
                if (indexDel == -1)
                {
                    return default;
                }
                else if (indexDel == 0)
                {
                    this.head = this.head.next;
                    return data;
                }
                else
                {
                    Node<G> temp = this.head;
                    Node<G> newTemp;
                    for (int i = 0; i < indexDel - 1; i++)
                    {
                        temp = temp.next;
                    }
                    newTemp = temp.next;
                    temp.next = newTemp.next;
                    return data;
                }
            }
            return default;
        }

        //Implementing the size of the list
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

        //Method to check if linklist is empty or not
        public bool IsEmpty()
        {
            if (this.head == null)
                return true;
            return false;
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
                Console.Write("The Elements In LinkList Are : ");
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
