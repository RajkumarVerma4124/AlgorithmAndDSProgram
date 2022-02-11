using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class HashSlots<T>
    {
        //Linked list to store values of slots
        private readonly int size;
        private readonly LinkedList<T>[] items;
        public HashSlots(int size)
        {
            this.size = size;
            this.items = new LinkedList<T>[size];
        }

        //Method to get the index number
        protected int GetArrayPosition(T data)
        {
            int position = data.GetHashCode() % size;
            return Math.Abs(position);
        }

        //Method to get the array position i.e 0,1 etc and linkedlist 
        public LinkedList<T> GetLinkedList(int position)
        {
            LinkedList<T> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<T>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        //Method to add data in linklist at particular node
        public void AddData(T data)
        {
            int position = GetArrayPosition(data);
            LinkedList<T> linkedList = GetLinkedList(position);
            linkedList.AddLast(data);
        }

        //Method to display element in each slot
        public string Display()
        {
            string resStr = string.Empty;
            for (int i = 0; i < size; i++)
            {
                LinkedList<T> linkedList = items[i];
                if (linkedList != null)
                {
                    int count = 1;
                    foreach (var value in linkedList)
                    {
                        Console.WriteLine("Element {0} of index {1} in Hash Table is: {2}", count, i, value);
                        resStr = value+" "+resStr;
                        count++;   
                    }
                }
            }
            return resStr;
        }

        //Method to remove existing value 
        public void Remove(T data)
        {
            int position = GetArrayPosition(data);
            LinkedList<T> linkedList = GetLinkedList(position);
            bool itemFound = false;
            T foundItem = default;
            foreach (var item in linkedList)
            {
                if (item.Equals(data))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        //Method to search the values in linklist
        public bool Search(T value)
        {
            int position = GetArrayPosition(value);
            LinkedList<T> linkedList = GetLinkedList(position);
            if (linkedList == null)
                return false;
            else
            {
                bool found = false;
                foreach (var item in linkedList)
                {
                    if (item.Equals(value))
                        found = true;
                }
                return found;
            }
        }
    }
}
