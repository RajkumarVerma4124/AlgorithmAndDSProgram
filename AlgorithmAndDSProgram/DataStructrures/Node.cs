using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSProgram.DataStructrures
{
    public class Node<G>
    {
        //Creating the node with data and next reference
        public G data;
        public Node<G> next;
        public Node(G data)
        {
            this.data = data;
        }
    }
}
