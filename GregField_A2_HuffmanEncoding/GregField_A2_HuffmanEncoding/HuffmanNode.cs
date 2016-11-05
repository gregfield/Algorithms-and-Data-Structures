using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_A2_HuffmanEncoding
{
    public class HuffmanNode
    {
        //frequency is the number of times the symbol occurs
        public int Frequency { get; set; }
        //symbol is the symbol of the node
        public String Symbol { get; set; }

        //the left and right nodes for the nodes for the tree
        public HuffmanNode LeftNode { get; set; }
        public HuffmanNode RightNode { get; set; }

        //constructor 
        public HuffmanNode(int frequency, String symbol)
        {
            Frequency = frequency;
            Symbol = symbol;
            LeftNode = null;
            RightNode = null;
        }

        //checks to see if the node is a leaf or not
        public bool IsLeaf()
        {
            if ((LeftNode == null) && (RightNode == null))
                return true;

            return false;
        }
    }
}
