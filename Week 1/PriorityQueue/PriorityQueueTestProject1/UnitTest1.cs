using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriorityQueue;

namespace PriorityQueueTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void pushPatient()
        {
            PatientQueue pq = new PatientQueue();
            string expected = "Patient Added";
            string actual = pq.push("Jimmy", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void pushToFillQueue()
        {
            PatientQueue pq = new PatientQueue();
            for(int i = 0; i < 100; i ++)
            {
                pq.push("Jimmy", 5);
            }
            string expected = "Can not add patient queue full";
            string actual = pq.push("Jimmy", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void pushEmptyPatientName()
        {
            PatientQueue pq = new PatientQueue();
            string expected = "Patient Information Needed";
            string actual = pq.push("", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void pushPriorityTooHigh()
        {
            PatientQueue pq = new PatientQueue();
            string expected = "Patient Information Needed";
            string actual = pq.push("Jones", 11);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void popPatient()
        {
            PatientQueue pq = new PatientQueue();
            pq.push("Jimmy", 6);
            string expected = "Name: Jimmy\t Priority: 6";
            string actual = pq.pop();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void popEmptyQueue()
        {
            PatientQueue pq = new PatientQueue();
            string expected = "No Patients in Queue";
            string actual = pq.pop();

            Assert.AreEqual(expected, actual);
        }
    }
}
