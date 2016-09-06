using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermediateRecursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            int num = Convert.ToInt32(textBox1.Text.ToString());
            
            Permutation perm = new Permutation(num);

            perm.Permutations(1, num, richTextBox1);
        }
    }
}
