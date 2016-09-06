using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VigenereTool;

namespace VignereTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncryptOneLetterWraps()
        {
            VigenereEnryptDecrypt worker = new VigenereEnryptDecrypt();

            int letterValue = 86;
            int keyValue = 73;
            int expected = 68;

            int actual = worker.encryptLetter(letterValue, keyValue);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DencryptOneLetterWraps()
        {
            VigenereEnryptDecrypt worker = new VigenereEnryptDecrypt();

            int letterValue = 68;
            int keyValue = 73;
            int expected = 86;

            int actual = worker.decryptLetter(letterValue, keyValue);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncryptOneLetterNoWrap()
        {
            VigenereEnryptDecrypt worker = new VigenereEnryptDecrypt();

            int letterValue = 72;
            int keyValue = 78;
            int expected = 85;

            int actual = worker.encryptLetter(letterValue, keyValue);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DencryptOneLetterNoWrap()
        {
            VigenereEnryptDecrypt worker = new VigenereEnryptDecrypt();

            int letterValue = 85;
            int keyValue = 78;
            int expected = 72;

            int actual = worker.decryptLetter(letterValue, keyValue);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncryptWholeWord()
        {
            Worker worker = new Worker(new VigenereEnryptDecrypt());
            string key = "BART";
            string expected = "QOFWME";
            string actual = worker.encryptorDecryptor(key, "POODLE", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DencryptWholeWord()
        {
            Worker worker = new Worker(new VigenereEnryptDecrypt());
            string key = "BART";
            string expected = "POODLE";
            string actual = worker.encryptorDecryptor(key, "QOFWME", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EncryptSentece()
        {
            Worker worker = new Worker(new VigenereEnryptDecrypt());
            string key = "MORGAN";
            string sentence = "NEVER INSULT SEVEN MEN IF YOU ARE ONLY CARRYING A SIX SHOOTER";
            string expected = "ZSMKR VZGLRT FQJVT MRZ WW EOH MFV UNYK QRXRLUBX G SVJ GYUOGQF";
            string actual = worker.encryptorDecryptor(key, sentence, true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DencryptSentence()
        {
            Worker worker = new Worker(new VigenereEnryptDecrypt());
            string key = "MORGAN";
            string sentence = "ZSMKR VZGLRT FQJVT MRZ WW EOH MFV UNYK QRXRLUBX G SVJ GYUOGQF";
            string expected = "NEVER INSULT SEVEN MEN IF YOU ARE ONLY CARRYING A SIX SHOOTER";
            string actual = worker.encryptorDecryptor(key, sentence, false);

            Assert.AreEqual(expected, actual);
        }
    }
}
