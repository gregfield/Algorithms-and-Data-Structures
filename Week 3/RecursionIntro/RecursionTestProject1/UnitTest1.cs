using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecursionIntro;

namespace RecursionTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReverseIt()
        {
            ReverseString test = new ReverseString();

            String testString = "abcde";

            String expected = "edcba";
            String actual = test.ReverseIt(testString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumNumbers()
        {
            SumOfNumbers test = new SumOfNumbers();

            int testInput = 10;

            int expected = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10; 
            int actual = test.SumToN(testInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeWithOddLetters()
        {
            RecursivePalindrome test = new RecursivePalindrome();

            String testInput = "racecar";

            bool expected = true;
            bool actual = test.Palindrome(testInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeWithEvenLetters()
        {
            RecursivePalindrome test = new RecursivePalindrome();

            String testInput = "abccba";

            bool expected = true;
            bool actual = test.Palindrome(testInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotPalindromeWithEvenLetters()
        {
            RecursivePalindrome test = new RecursivePalindrome();

            String testInput = "abccbn";

            bool expected = false;
            bool actual = test.Palindrome(testInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NotPalindromeWithoddLetters()
        {
            RecursivePalindrome test = new RecursivePalindrome();

            String testInput = "racecal";

            bool expected = false;
            bool actual = test.Palindrome(testInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveLetterFromString()
        {
            RemoveLetter test = new RemoveLetter();

            String testInput = "xxaxxxbxcd";
            String targetLetter = "x";

            String expected = "abcd";
            String actual = test.RemoveIt(targetLetter, testInput);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            RecursiveMergeSort mergeTest = new RecursiveMergeSort();
            int[] testArray = { 10, 8, 4, 16, 32, 3, 2, 6, 7, 89, 12, 5, 65, 23, 13, 1 };
            int setSize = 16;
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int[] actual = mergeTest.MergeSort(testArray, 0, testArray.Length-1, setSize);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeArraySegmentsTest()
        {
            RecursiveMergeSort mergeTest = new RecursiveMergeSort();
            int[] testArray = { 2, 3, 4, 1, 5, 9 };
            int low1 = 0, low2 = 3, high1 = 2, high2 = 5;
            int[] expected = { 1, 2, 3, 4, 5, 9 };
            int[] actual = mergeTest.MergeArraySegments(testArray, low1, high1, low2, high2);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinarySearchWithTargetInArrayTest()
        {
            RecursiveBinarySearch binaryTest = new RecursiveBinarySearch();
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int targetNumber = 10;

            bool expected = true;
            bool actual = binaryTest.BinarySearch(testArray, targetNumber, 0, testArray.Length);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BinarySearchWithTargetNotInArrayTest()
        {
            RecursiveBinarySearch binaryTest = new RecursiveBinarySearch();
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int targetNumber = 21;

            bool expected = false;
            bool actual = binaryTest.BinarySearch(testArray, targetNumber, 0, testArray.Length);

            Assert.AreEqual(expected, actual);
        }
    }
}
