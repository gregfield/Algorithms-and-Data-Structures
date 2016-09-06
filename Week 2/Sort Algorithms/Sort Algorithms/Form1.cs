using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort_Algorithms
{
    public partial class Form1 : Form
    {
        private ISort sortType;
        private SortWorker worker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            worker = new SortWorker(listBox1);
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            sortType = new BubbleSort();
            if(bubbleBtn.Checked)
            {
                sortType = new BubbleSort();
            }
            else if(selectionBtn.Checked)
            {
                sortType = new SelectionSort();
            }
            else if(insertionBtn.Checked)
            {
                sortType = new InsertionSort();
            }
            else if(mergeBtn.Checked)
            {
                sortType = new MergeSort();
            }

            int arraySize = Convert.ToInt32(textBox1.Text);

            worker.runSort(sortType, arraySize);
        }
    }
}
