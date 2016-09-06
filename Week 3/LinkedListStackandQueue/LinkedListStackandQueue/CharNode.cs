using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackandQueue
{
    public class CharNode
    {
        public CharNode Next { get; set; }
        public char nodeInfo;

        public CharNode(char nodeInfoToAdd)
        {
            nodeInfo = nodeInfoToAdd;
            Next = null;
        }
    }
}
