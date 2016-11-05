using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregField_A2_HuffmanEncoding
{
    public class Worker
    {
        //Properties for drawing
        private Graphics canvas;
        private Pen pen;
        private Brush brush;
        private Font font;
        private String[] symbols;
        private int[] frequencies;
        private int startX;
        private int startY;
        private int widthHeight;
        private int xAdjust;
        private int xyCircleAdjust;
        private int stringYAdjust;

        //Huffman tree with all 
        private HuffmanTree huffmanTree;

        //Constructor
        public Worker(Graphics canvas, Pen pen, Brush brush, Font font)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.brush = brush;
            this.font = font;
            startX = 1050;
            startY = 78;
            widthHeight = 70;
            xAdjust = 5;
            xyCircleAdjust = 70;
            stringYAdjust = 3;
        }

        //Make the huffman tree
        public void MakeHuffmanTree(int[] frequencies, String[] symbols)
        {
            this.symbols = symbols;
            this.frequencies = frequencies;
            huffmanTree = new HuffmanTree(frequencies, symbols);
        }

        //Draws the huffman tree
        public void DrawHuffmanTree()
        {
            huffmanTree.DrawTree(canvas, pen, brush, font, startX, startY, widthHeight, xAdjust, xyCircleAdjust, stringYAdjust);
        }

        //Calls the method to get the codes from the huffman tree
        public void GetHuffmanCodes(ListBox listBox)
        {
            huffmanTree.GetCodes(listBox);
        }

        //Shows the code values 
        public void ShowValues(Label huffmanCodeLbl, Label fixedLengthCodeLbl)
        {
            huffmanCodeLbl.Text = huffmanTree.GetHuffmanValues().ToString();
            fixedLengthCodeLbl.Text = CalculateFixedLengthValue().ToString();
        }

        //calls the method to decode the input text
        public String DecodeInput(String inputText)
        {
            return huffmanTree.DecodeString(inputText);
        }

        public void ImportAndBuildTree()
        {
            //open txt file
            StreamReader sr = new StreamReader("huffmanInputTest2.txt");
            
            String fileToEncode = sr.ReadToEnd();

            List<int> frequencies = new List<int>();
            List<String> symbols = new List<String>();

            //search through looking for letters that are the same
            for (int i = 0; i < fileToEncode.Length; i++)
            {
                String letter = fileToEncode[i].ToString();
                int listPosition = 0;
                bool found = false;
                foreach(String symbol in symbols)
                {
                    //when the same letters have been found in the list the frequency is increased by one
                    if(letter == symbol)
                    {
                        frequencies[listPosition] += 1;
                        found = true;
                    }
                    listPosition++;
                }
                //if the letter was not found it adds a new one and sets the frequency to one
                if(!found)
                {
                    symbols.Add(letter);
                    frequencies.Add(1);
                }
            }

            //turns the lists into an array so that they can be passed to the make huffman tree method
            int[] frequenciesArray = frequencies.ToArray();
            String[] symbolsArray = symbols.ToArray();

            //builds the huffman tree
            MakeHuffmanTree(frequenciesArray, symbolsArray);
        }

        public int CalculateFixedLengthValue()
        {
            //calculates the number of bits so that Fixed length count can be calculated
            //Math.Ceiling is to make it round up
            int logBase = 2;
            int numOfBits = (int)Math.Ceiling(Math.Log(symbols.Length, logBase));
            int fixedLengthCode = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                //for fixed length bit size
                fixedLengthCode += (frequencies[i] * numOfBits);
            }

            return fixedLengthCode;
        }
    }
}
