using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereTool
{
    public class Worker
    {
        private const int ASCIISTART = 65;
        private const int ASCIISTOP = 90;

        //lists for the file keywords and sentences
        private List<String> keyWords;
        private List<String> phrases;
        private int numberPhrases;

        //for what type of enryption/decryption to use
        IEncryptDecrypt enryptDecryptType;

        public Worker(IEncryptDecrypt enryptDecryptType)
        {
            this.enryptDecryptType = enryptDecryptType;
            keyWords = new List<string>();
            phrases = new List<string>();
        }

        //converts the strings into char arrays then converts those chars into their values
        //then sends them to the encryptor or decryptor, once it gets the new value back it converts
        //it back into a char then to a string
        public string encryptorDecryptor(string key, string stringToConvert, bool encryptDecrypt)
        {
            //converting the string to be encrypted/decrypted and the key word into char arrays
            char[] charsToConvert = stringToConvert.ToCharArray();
            char[] keyChars = key.ToCharArray();

            //for what letter is being used from the key word for the conversion
            int keyLetter = 0;

            //to go throught the whole char arrays for the word that is to be converted
            for (int i = 0; i < charsToConvert.Length; i++)
            {
                //sets the key letter back to zero if the key word is smaller than what is being converted
                if (keyLetter >= keyChars.Length)
                {
                    keyLetter = 0;
                }

                //converting the letters to ints
                int letterToConvert = (int)charsToConvert[i];
                int keyLetterValue = (int)keyChars[keyLetter];
                //int for the converted letter
                int converted = 0;

                //so that it only converts letters between A and Z
                if ((letterToConvert >= ASCIISTART) && (letterToConvert <= ASCIISTOP))
                {
                    //sends the letter value and key value to the encryptor if thats what was selected
                    if (encryptDecrypt == true)
                    {
                        converted = enryptDecryptType.encryptLetter(letterToConvert, keyLetterValue);
                    }
                    //sends the letter value and key value to the decryptor if thats what was selected
                    else if (encryptDecrypt == false)
                    {
                        converted = enryptDecryptType.decryptLetter(letterToConvert, keyLetterValue);
                    }

                    //to use the next letter in key word
                    keyLetter++;
                }
                else
                {
                    converted = letterToConvert;
                }

                //converts the value back to a char
                charsToConvert[i] = Convert.ToChar(converted); 
            }

            //changes the char array back to a string
            string convertedString = new string(charsToConvert);

            return convertedString;
        }

        //gets the phrases and keywords from the file
        public void readInFile()
        {
            StreamReader sr = new StreamReader("ViginereTestInput.txt");
            string line;
            int count = 0;
            numberPhrases = Convert.ToInt32(sr.ReadLine());
            while ((line = sr.ReadLine()) != null)
            {
                if (count < numberPhrases)
                {
                    keyWords.Add(line);
                }
                else
                {
                    phrases.Add(line);
                }
                count++;
            }
        }

        //attempts to decrypt the phrases using the keywords
        public string fileDecrypt(int keyword, int phrase)
        {
            string decrypted = "";
            try
            {
                decrypted = encryptorDecryptor(keyWords[keyword], phrases[phrase], false);
                decrypted += "\nKeyword = " + keyWords[keyword];
            }
            catch(ArgumentOutOfRangeException)
            {
                decrypted = "No More Phrases or Keywords";
            }

            return decrypted;
        }

        //removes keywords after a match has been found
        public void removeKey(int keyNumber)
        {
            try
            {
                keyWords.RemoveAt(keyNumber);
            }
            catch(ArgumentOutOfRangeException)
            {

            }
        }
    }
}
