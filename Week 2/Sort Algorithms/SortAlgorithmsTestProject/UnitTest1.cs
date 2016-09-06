using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort_Algorithms;

namespace SortAlgorithmsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BubbleSortTest()
        {
            BubbleSort bubble = new BubbleSort();
            int[] testArray = { 10, 8, 4, 16, 32, 3, 2, 6, 7, 89, 12, 5, 65, 23, 13, 1 };

            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int[] actual = bubble.sort(testArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectionSortTest()
        {
            SelectionSort selection = new SelectionSort();
            int[] testArray = { 10, 8, 4, 16, 32, 3, 2, 6, 7, 89, 12, 5, 65, 23, 13, 1 };

            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int[] actual = selection.sort(testArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            InsertionSort insertion = new InsertionSort();
            int[] testArray = { 10, 8, 4, 16, 32, 3, 2, 6, 7, 89, 12, 5, 65, 23, 13, 1 };

            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int[] actual = insertion.sort(testArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeSortTest()
        {
            MergeSort merge = new MergeSort();
            int[] testArray = { 10, 8, 4, 16, 32, 3, 2, 6, 7, 89, 12, 5, 65, 23, 13, 1 };

            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 13, 16, 23, 32, 65, 89 };
            int[] actual = merge.sort(testArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MergeArraySegmentsTest()
        {
            MergeSort merge = new MergeSort();
            int[] testArray = { 2, 3, 4, 1, 5, 9};
            int low1 = 0, low2 = 3, high1 = 2, high2 = 5;
            int[] expected = { 1, 2, 3, 4, 5, 9};
            int[] actual = merge.mergeArraySegments(testArray,low1,high1,low2,high2);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
