using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GregField_A2_HuffmanEncoding;

namespace HuffmanEncodingTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BuildingCorrectHuffmanTreeRootNode()
        {
            int[] testFreqArray = {25,10,8,41};
            String[] testSymblArray = {"a","b","c","d"};
            HuffmanTree testTree = new HuffmanTree(testFreqArray, testSymblArray);

            int expectedFreq = 84;
            String expectedSymbl = "dcba";

            int actualFreq = testTree.RootNode.Frequency;
            String actualSymbl = testTree.RootNode.Symbol;

            Assert.AreEqual(expectedFreq, actualFreq);
            Assert.AreEqual(expectedSymbl, actualSymbl);
        }

        [TestMethod]
        public void CalculatingCorrectFixedLengthCode()
        {
            int[] testFreqArray = { 25, 10, 8, 41 };
            String[] testSymblArray = { "a", "b", "c", "d" };
            HuffmanTree testTree = new HuffmanTree(testFreqArray, testSymblArray);

            int expectedFixedLengthCode = 168;

            int actualFixedLengthCode = testTree.FixedLengthCodeCount;

            Assert.AreEqual(expectedFixedLengthCode, actualFixedLengthCode);
        }

        [TestMethod]
        public void Decoding()
        {
            int[] testFreqArray = { 25, 10, 8, 41 };
            String[] testSymblArray = { "a", "b", "c", "d" };
            HuffmanTree testTree = new HuffmanTree(testFreqArray, testSymblArray);

            String testDecode = "011000101";

            String expectedString = "cabd";
            String actual = testTree.DecodeString(testDecode);

            Assert.AreEqual(expectedString, actual);
        }
    }
}
