using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigenereTool
{
    public partial class Form1 : Form
    {
        private IEncryptDecrypt enryptDecryptType;
        private Worker worker;
        private int keyNumber;
        private int phraseNumber;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //makes a new vigenere decryptor
            enryptDecryptType = new VigenereEnryptDecrypt();
            //makes a new worker
            worker = new Worker(enryptDecryptType);
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            //gets the word and key from what user entered
            string stringToEncrypt = textBox1.Text.ToString();
            string key = keyTxtBox.Text.ToString();

            //displays the encrypted word
            FeedbackTxtBox.Text = worker.encryptorDecryptor(key, stringToEncrypt, true);
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            //gets the word and key from what user entered
            string stringToDecrypt = textBox1.Text.ToString();
            string key = keyTxtBox.Text.ToString();

            //displays the decrypted word
            FeedbackTxtBox.Text = worker.encryptorDecryptor(key, stringToDecrypt, false);
        }

        //reads in the file and then shows the first attempt at decrypting the first phrase
        private void decryptFileBtn_Click(object sender, EventArgs e)
        {
            keyNumber = 0;
            phraseNumber = 0;
            worker.readInFile();
            FeedbackTxtBox.Text = worker.fileDecrypt(keyNumber, phraseNumber);
        }

        //if the phrase is correctly decrypted the key will be removed from  the list
        //then the next phrase will be shown
        private void correctKeyBtn_Click(object sender, EventArgs e)
        {
            worker.removeKey(keyNumber);
            keyNumber = 0;
            phraseNumber++;
            FeedbackTxtBox.Text = "Next Phrase \n" + worker.fileDecrypt(keyNumber, phraseNumber);
        }

        //if the phrase is not correctly decrypted it will show the phrase again using a different key
        //if all the key words have been through it will start them again
        private void wrongKeyBtn_Click(object sender, EventArgs e)
        {
            keyNumber++;
            if (keyNumber == 10)
            {
                keyNumber = 0;
                FeedbackTxtBox.Text = worker.fileDecrypt(keyNumber, phraseNumber);
            }
            else
            {
                FeedbackTxtBox.Text = worker.fileDecrypt(keyNumber, phraseNumber);
            }
        }
    }
}
