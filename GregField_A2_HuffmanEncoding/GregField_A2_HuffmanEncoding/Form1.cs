using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregField_A2_HuffmanEncoding
{
    public partial class huffmanForm : Form
    {
        //Properties for drawing text boxes and for the huffman worker
        private const int NUMBEROFTEXTBOXES = 8;   
        private Graphics canvas;
        private Pen pen;
        private Brush brush;
        private Font font;

        private Worker huffmanWorker;
        private TextBox[] symblTextBoxes;
        private TextBox[] freqTextBoxes;
        private int[] frequencies;
        private String[] symbols;

        public huffmanForm()
        {
            InitializeComponent();
        }

        //Initialises graphics and adds teh arrays to text boxes
        private void huffmanForm_Load(object sender, EventArgs e)
        {
            canvas = CreateGraphics();
            brush = new SolidBrush(Color.Black);
            pen = new Pen(brush);
            font = label1.Font;
            huffmanWorker = new Worker(canvas, pen, brush, font);
            AddTextBoxesToArrays();
        }

        //When the build huffman button is clicked it calls the appropriate method in the worker
        private void buildHuffmanBtn_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            GetTextBoxValues();
            huffmanWorker.MakeHuffmanTree(frequencies, symbols);
            outputListBox.Items.Add("Huffman Tree Built");
        }

        //When the show codes button is clicked it calls the appropriate method in the worker
        private void showCodesBtn_Click(object sender, EventArgs e)
        {
            huffmanWorker.GetHuffmanCodes(outputListBox);
        }

        //When the decode button is clicked it calls the appropriate method in the worker
        private void decodeBtn_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            String stringToDecode = decodeTxtBox.Text.ToString();
            String decodedString = huffmanWorker.DecodeInput(stringToDecode);
            outputListBox.Items.Add(decodedString);
        }

        //When the import text button is clicked it calls the appropriate method in the worker
        private void importTxtBtn_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            huffmanWorker.ImportAndBuildTree();
            outputListBox.Items.Add("Huffman Tree Built");
        }

        //When the display tree button is clicked it calls the appropriate method in the worker
        private void displayTreeBtn_Click(object sender, EventArgs e)
        {
            huffmanWorker.DrawHuffmanTree();
        }

        //Displays the code values
        private void displayValuesBtn_Click(object sender, EventArgs e)
        {
            huffmanWorker.ShowValues(huffmanBitLbl, fixedLengthBitLbl);
        }

        //gets the symbols and frequencies that have been entered into the text box
        //and builds an array of nodes and returns them
        private void GetTextBoxValues()
        {
            int numberOfSymbolsEntered = GetNumberOfSymbolsEntered();
            frequencies = new int[numberOfSymbolsEntered];
            symbols = new String[numberOfSymbolsEntered];
            int textBoxNum = 0;
            String symbol = "";
            while ((textBoxNum != numberOfSymbolsEntered)&&((symbol = symblTextBoxes[textBoxNum].Text.ToString()) != ""))
            {
                String freqString = freqTextBoxes[textBoxNum].Text.ToString();
                if(freqString != "")
                {
                    frequencies[textBoxNum] = Convert.ToInt32(freqString);
                    symbols[textBoxNum] = symbol;
                }
                textBoxNum++;
            }
        }

        //gets the number of Symbols and frequencies that have been entered
        //so that the arrays can be created at the correct length
        private int GetNumberOfSymbolsEntered()
        {
            int numberOfSymbols = 0;
            while ((numberOfSymbols != NUMBEROFTEXTBOXES) && ((symblTextBoxes[numberOfSymbols].Text.ToString()) != ""))
            {
                numberOfSymbols++;
            }

            return numberOfSymbols;
        }

        //Adds the text boxes to arrays so that they can easily be looped through to get
        //the values out of them
        private void AddTextBoxesToArrays()
        {
            symblTextBoxes = new TextBox[NUMBEROFTEXTBOXES];
            symblTextBoxes[0] = syblTxtBox1;
            symblTextBoxes[1] = syblTxtBox2;
            symblTextBoxes[2] = syblTxtBox3;
            symblTextBoxes[3] = syblTxtBox4;
            symblTextBoxes[4] = syblTxtBox5;
            symblTextBoxes[5] = syblTxtBox6;
            symblTextBoxes[6] = syblTxtBox7;
            symblTextBoxes[7] = syblTxtBox8;

            freqTextBoxes = new TextBox[NUMBEROFTEXTBOXES];
            freqTextBoxes[0] = freqTxtBox1;
            freqTextBoxes[1] = freqTxtBox2;
            freqTextBoxes[2] = freqTxtBox3;
            freqTextBoxes[3] = freqTxtBox4;
            freqTextBoxes[4] = freqTxtBox5;
            freqTextBoxes[5] = freqTxtBox6;
            freqTextBoxes[6] = freqTxtBox7;
            freqTextBoxes[7] = freqTxtBox8;
        }
    }
}