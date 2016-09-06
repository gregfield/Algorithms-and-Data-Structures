using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereTool
{
    public class VigenereEnryptDecrypt : IEncryptDecrypt
    {
        //constants specific to this particular enryption decryption method
        private const int alphabetStartPosition = 65;
        private const int alphabetLength = 26;

        //Encrypts a letter by adding a specific amount to the letter value
        public int encryptLetter(int letterToEncrypt, int keyShift)
        {
            //adds amount to letter value
            int encrypted = letterToEncrypt + keyShift;

            //used to wrap around to the begining of the alphabet for if it goes past z
            //then alphabet start position used for where A starts in the ASCII table
            encrypted = (encrypted % alphabetLength) + alphabetStartPosition;

            return encrypted;
        }

        public int decryptLetter(int letterToDecrypt, int keyShift)
        {
            //minus amount to letter value
            int decrypted = letterToDecrypt - keyShift;

            //used to wrap around to the begining of the alphabet for if it goes past a
            //then alphabet start position used for where A starts in the ASCII table
            decrypted = (decrypted % alphabetLength) + alphabetStartPosition;

            //used for if negative value to bring it back into the alphabet
            if (decrypted < alphabetStartPosition)
            {
                decrypted += alphabetLength;
            }

            return decrypted;
        }
    }
}
