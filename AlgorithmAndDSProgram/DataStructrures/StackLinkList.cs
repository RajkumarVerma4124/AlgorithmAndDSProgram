using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{ 
    public class StackLinkList<G> where G : IComparable
    {
        //Creating the linlist object 
        UnorderedList<G> list = new UnorderedList<G>();

        //Creating add first method to add the element at first position i.e head
        public void Push(G data)
        {
            list.AddFirst(data);
        }

        //Displaying the data from linklist nodes
        public void Display()
        {
            list.Display();
        }
    }
}
