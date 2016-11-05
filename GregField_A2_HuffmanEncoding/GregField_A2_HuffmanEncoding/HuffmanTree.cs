using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregField_A2_HuffmanEncoding
{
    public class HuffmanTree : BinaryTree
    {
        //============================================================
        //Constructor
        //============================================================

        public HuffmanTree(int[] frequencies, String[] symbols)
        {
            //creates the full tree then set the huffman tree root node to the global tree node
            BinaryTree globalTree = BuildHuffmanTree(CreateHuffmanTreeArray(frequencies, symbols));
            RootNode = globalTree.RootNode;     
        }


        //============================================================
        //Building the tree methods
        //============================================================

        //Creates an array of Huffman trees so that the global tree can be made
        public BinaryTree[] CreateHuffmanTreeArray(int[] frequencies, String[] symbols)
        {
            BinaryTree[] newArray = new BinaryTree[symbols.Length];

            //calculates the number of bits so that Fixed length count can be calculated
            //Math.Ceiling is to make it round up
            int logBase = 2;
            int numOfBits = (int)Math.Ceiling(Math.Log(newArray.Length, logBase));

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = new BinaryTree(frequencies[i], symbols[i]);
                //for fixed length bit size
                //FixedLengthCodeCount += (frequencies[i] * numOfBits);
            }

            return newArray;
        }

        //Builds the Huffman Tree
        public BinaryTree BuildHuffmanTree(BinaryTree[] startTreeArray)
        {
            //needs to be length -1 so that it does not try and get a tree that is not there
            for (int i = 0; i < startTreeArray.Length - 1; i++)
            {
                //Sorts the array so that the 2 lowest frequency value trees can be used easily
                Array.Sort(startTreeArray);
                //gets the symbol nad frequencies from the two lowest trees and adds them together
                //for the symbol and frequency of the new node
                //need to use i for the where to start in the array because Array.Sort puts nulls first
                int newFreq = startTreeArray[i].RootNode.Frequency + startTreeArray[i + 1].RootNode.Frequency;
                String newSymbol = startTreeArray[i].RootNode.Symbol + startTreeArray[i + 1].RootNode.Symbol;
                //creates the new tree using the new frequencies
                //adds the 2 lowest trees to the new node
                BinaryTree newTree = new BinaryTree(newFreq, newSymbol, startTreeArray[i], startTreeArray[i + 1]);

                //removes those two trees from the array by replacing one of them with the new tree
                //and setting the other to null
                startTreeArray[0] = newTree;
                startTreeArray[i + 1] = null;
            }
            //sets the global tree to the final tree that was made
            return startTreeArray[0];
        }


        //============================================================
        //Get Codes For Each Symbol Methods
        //============================================================

        //Calls the method to get the codes for each of the symbols
        public void GetCodes(ListBox listBox)
        {
            listBox.Items.Clear();
            String startCode = "";
            int startCodeCount = 0;
            RecursiveGetCodes(RootNode, startCode, listBox, startCodeCount);
        }

        //Uses a Preorder traversal to get the codes for the symbols
        public void RecursiveGetCodes(HuffmanNode rootNode, String codeString, ListBox listBox, int codeCount)
        {
            //if it is a root node the code string gets printed
            if (rootNode.IsLeaf())
            {
                listBox.Items.Add(rootNode.Symbol + ": " + codeString);
            }
            else
            {
                //else it recurses left and right adding a 0 and 1 to the code string
                //for which ever way it goes
                RecursiveGetCodes(rootNode.LeftNode, codeString + "1", listBox, codeCount + 1);
                RecursiveGetCodes(rootNode.RightNode, codeString + "0", listBox, codeCount + 1);
            }
        }


        //============================================================
        //Decodes an input string using the huffman tree
        //============================================================

        public String DecodeString(String inputText)
        {
            //text position is for where in the input string it is trying to decode
            int textPosition = 0;
            String decodedString = "";
            //it calls the recursive method until the text position is equal to the 
            //length of the input string so that it decodes the whole string
            while (textPosition != inputText.Length)
            {
                //gets the symbol and text position from the recursicve method
                String symbol = RecursiveDecode(RootNode, inputText, textPosition);
                //adds the new char to the decoded string
                decodedString += symbol[0];
                //converts the rest of the string to an int because that is then the
                //text position for how far through the string has been decoded
                textPosition = Convert.ToInt32(symbol.Substring(1));
            }

            return decodedString;
        }

        //Recursively runs through each character in the input string till it gets to a
        //leaf node then returns the char located in it
        public String RecursiveDecode(HuffmanNode rootNode, String input, int textPosition)
        {
            //if the node is a leaf it returns the root node symbol 
            //and the text position so that place in the string is not lost
            if(rootNode.IsLeaf())
            {
                return rootNode.Symbol + textPosition;
            }
            //if it is not a leaf node it recurses
            else
            {
                //if the string character is a 1 it recurses left and increases the position in the text
                //else it recurses to the right
                if(input[textPosition].Equals('1'))
                {
                    return RecursiveDecode(rootNode.LeftNode, input, textPosition + 1);
                }
                else
                {
                    return RecursiveDecode(rootNode.RightNode, input, textPosition + 1);
                }
            }
        }

        //============================================================
        //Calculate Huffman Code Value Methods
        //============================================================

        //Calls the method to get calculate the huffman code values
        public int GetHuffmanValues()
        {
            int startCodeCount = 0;
            return RecursiveCalculateHuffmanValue(RootNode, startCodeCount);
        }

        //Uses a Preorder traversal to get the codes for the symbols
        public int RecursiveCalculateHuffmanValue(HuffmanNode rootNode, int codeCount)
        {
            //if it is a root node the code value gets returned
            if (rootNode.IsLeaf())
            {
                return rootNode.Frequency * codeCount;
            }
            else
            {
                //else it recurses left and right adding a 0 and 1 to the code string
                //for which ever way it goes
                int huffmanCount = 0;

                huffmanCount += RecursiveCalculateHuffmanValue(rootNode.LeftNode, codeCount + 1);
                huffmanCount += RecursiveCalculateHuffmanValue(rootNode.RightNode, codeCount + 1);

                return huffmanCount;
            }
        }
    }
}
