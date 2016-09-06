using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class Patient : IComparable
    {
        public string name { get; set; }
        public int priority { get; set; }

        public Patient(string name, int priority)
        {
            this.name = name;
            this.priority = priority;
        }
        public string toString()
        {
            return "Name: " + name + "\t Priority: " + priority.ToString();
        }

        //compares patients on priority
        public int CompareTo(object other)
        {
            Patient otherP = other as Patient;
            return this.priority.CompareTo(otherP.priority);
        }
    }
}
