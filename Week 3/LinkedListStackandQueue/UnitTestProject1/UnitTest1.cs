using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListStackandQueue;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckStackCount()
        {
            IntStack testStack = new IntStack();

            testStack.Push(10);
            int expected = 1, expected2 = 0;
            int actual = testStack.Count();

            testStack.Pop();

            int actual2 = testStack.Count();

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void CheckIfStackIsEmptyWhenItIsEmpty()
        {
            IntStack testStack = new IntStack();

            bool expected = true;
            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfStackIsEmptyWhenItIsNot()
        {
            IntStack testStack = new IntStack();

            testStack.Push(10);

            bool expected = false;
            bool actual = testStack.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PushToEmptyStack()
        {
            IntStack testStack = new IntStack();

            testStack.Push(10);

            int expected = 10;
            int actual = testStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PopMultipleFromStackToCheckOrder()
        {
            IntStack testStack = new IntStack();

            int first = 10, second = 18, third = 5;
            testStack.Push(first);
            testStack.Push(second);
            testStack.Push(third);

            int actual1 = testStack.Pop();
            int actual2 = testStack.Pop();
            int actual3 = testStack.Pop();

            Assert.AreEqual(first, actual3);
            Assert.AreEqual(second, actual2);
            Assert.AreEqual(third, actual1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PeekOnEmptyStack()
        {
            IntStack testStack = new IntStack();

            testStack.Peek();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopOnEmptyStack()
        {
            IntStack testStack = new IntStack();

            testStack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopFromStackfterHadThingsInIt()
        {
            IntStack testStack = new IntStack();

            testStack.Push(10);

            testStack.Pop();
            testStack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopOnEmptyQueue()
        {
            IntQueue testQueue = new IntQueue();

            testQueue.Pop();
        }

        [TestMethod]
        public void PopMultipleFromQueueToCheckOrder()
        {
            IntQueue testQueue = new IntQueue();

            int first = 10, second = 18, third = 5;
            testQueue.Push(first);
            testQueue.Push(second);
            testQueue.Push(third);

            int actual1 = testQueue.Pop();
            int actual2 = testQueue.Pop();
            int actual3 = testQueue.Pop();

            Assert.AreEqual(first, actual1);
            Assert.AreEqual(second, actual2);
            Assert.AreEqual(third, actual3);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PeekOnEmptyQueue()
        {
            IntQueue testQueue = new IntQueue();

            testQueue.Peek();
        }

        [TestMethod]
        public void CheckIfQueueIsEmptyWhenItIsEmpty()
        {
            IntQueue testQueue = new IntQueue();

            bool expected = true;
            bool actual = testQueue.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckIfQueueIsEmptyWhenItIsNot()
        {
            IntQueue testQueue = new IntQueue();

            testQueue.Push(10);

            bool expected = false;
            bool actual = testQueue.IsEmpty();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PushToEmptyQueue()
        {
            IntQueue testQueue = new IntQueue();

            testQueue.Push(10);

            int expected = 10;
            int actual = testQueue.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PopFromQueueAfterHadThingsInIt()
        {
            IntQueue testQueue = new IntQueue();

            testQueue.Push(10);

            testQueue.Pop();
            testQueue.Pop();
        }

        [TestMethod]
        public void CheckQueueCount()
        {
            IntQueue testQueue = new IntQueue();

            testQueue.Push(10);
            int expected = 1, expected2 = 0;
            int actual = testQueue.Count();

            testQueue.Pop();

            int actual2 = testQueue.Count();

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void BalancedBracesBalancedBracesInString()
        {
            BalancedBraces balBracesTest = new BalancedBraces();

            string testString = "{Hello {This} is {a} test}";

            bool expected = true;
            bool actual = balBracesTest.checkString(testString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BalancedBracesTooManyOpeningBracesInString()
        {
            BalancedBraces balBracesTest = new BalancedBraces();

            string testString = "{{Hello {This} is {a} test}";

            bool expected = false;
            bool actual = balBracesTest.checkString(testString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BalancedBracesTooManyClosingBracesInString()
        {
            BalancedBraces balBracesTest = new BalancedBraces();

            string testString = "{Hello {This} is {a} test}}";

            bool expected = false;
            bool actual = balBracesTest.checkString(testString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BalancedBracesForFile()
        {
            BalancedBraces balBracesTest = new BalancedBraces();

            bool[] expected = {false, true, false, true, true, false, true};
            bool[] actual = balBracesTest.checkFile();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PostfixParser()
        {
            PostfixParser testParser = new PostfixParser();

            string testString = "23+6*";
            string testString2 = "236+*";
            string testString3 = "234*+5+";

            int expected = 30;
            int expected2 = 18;
            int expected3 = 19;

            int actual = testParser.Parser(testString);
            int actual2 = testParser.Parser(testString2);
            int actual3 = testParser.Parser(testString3);

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void PalindromeWhenWordIsAPalindrome()
        {
            PalindromeFinder testFinder = new PalindromeFinder();

            string testString = "saippuakivikauppias";

            bool expected = true;
            bool actual = testFinder.SearchWord(testString);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromeWhenWordIsNotAPalindrome()
        {
            PalindromeFinder testFinder = new PalindromeFinder();

            string testString = "thisisnotapalindrome";

            bool expected = false;
            bool actual = testFinder.SearchWord(testString);

            Assert.AreEqual(expected, actual);
        }
    }
}
