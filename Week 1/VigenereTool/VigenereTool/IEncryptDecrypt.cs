using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VigenereTool
{
    public interface IEncryptDecrypt
    {
        int encryptLetter(int letterToEncrypt, int keyShift);
        int decryptLetter(int letterToDecrypt, int keyShift);
    }
}
