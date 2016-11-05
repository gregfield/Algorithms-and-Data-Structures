using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_A2_HuffmanEncoding
{
    public class BinaryTree : IComparable
    {
        //The root node of the tree
        public HuffmanNode RootNode { get; set; }

        //============================================================
        //Constructors
        //============================================================
        public BinaryTree()
        {
            RootNode = null;
        }

        public BinaryTree(int frequency, String symbol)
        {
            RootNode = new HuffmanNode(frequency, symbol);
        }

         
        public BinaryTree(int frequency, String symbol, BinaryTree leftSubTree, BinaryTree rightSubTree)
        {
	        RootNode = new HuffmanNode(frequency, symbol);
	        HuffmanNode leftRoot = leftSubTree.RootNode;
	        HuffmanNode rightRoot = rightSubTree.RootNode;

            RootNode.LeftNode = leftRoot;
            RootNode.RightNode = rightRoot;
        }

        //============================================================
        //Draw Tree Methods
        //============================================================

        //Calls the recursive method to draw the tree
        public void DrawTree(Graphics canvas, Pen pen, Brush brush, Font font,
            int startX, int startY, int widthHeight, int xAdjust, int xyCircleAdjust, int stringYAdjust)
        {
            canvas.Clear(SystemColors.Control);
            RecursiveDrawTree(canvas, pen, brush, font, RootNode, startX, startY
                , widthHeight, xAdjust, xyCircleAdjust, stringYAdjust);
        }

        //Recursive draws the tree using a Preorder traversal
        public void RecursiveDrawTree(Graphics canvas, Pen pen, Brush brush, Font font, 
            HuffmanNode rootNode, int x, int y, int widthHeight, int xAdjust, int xyCircleAdjust, int stringYAdjust)
        {
            //if the node is not null it can be drawn
            if (rootNode != null)
            {
                //makes a string to draw using the sybol and the frequency of the node
                String nodeString = rootNode.Symbol + "\n" + rootNode.Frequency;
                //draws an ellipse to represent the node then draws the string inside it
                canvas.DrawEllipse(pen, x, y, widthHeight, widthHeight);
                canvas.DrawString(nodeString, font, brush, x + xAdjust, y + (widthHeight / stringYAdjust));

                //recurses left and then right drawing out the nodes as it goes
                RecursiveDrawTree(canvas, pen, brush, font, rootNode.LeftNode, x - xyCircleAdjust, y + xyCircleAdjust,
                    widthHeight, xAdjust, xyCircleAdjust, stringYAdjust);

                RecursiveDrawTree(canvas, pen, brush, font, rootNode.RightNode, x + xyCircleAdjust, y + xyCircleAdjust,
                    widthHeight, xAdjust, xyCircleAdjust, stringYAdjust);
            }
        }


        //Compares two nodes to see which has the bigger frequency for sorting
        public int CompareTo(object obj)
        {
            BinaryTree secondNode = obj as BinaryTree;
            return this.RootNode.Frequency.CompareTo(secondNode.RootNode.Frequency);
        }
    }
}
