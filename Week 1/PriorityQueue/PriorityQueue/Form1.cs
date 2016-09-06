using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriorityQueue
{
    public partial class Form1 : Form
    {
        PatientQueue patientQueue;

        public Form1()
        {
            InitializeComponent();
        }

        private void highPriBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(patientQueue.pop());
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            patientQueue.displayAllPatients(listBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            patientQueue = new PatientQueue();
            patientQueue.addPatients();
        }
    }
}
