using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GregField_Assignment1Fractals
{
    public partial class Form1 : Form
    {
        //Set up constants
        private const int BASECASE = 0;
        private const int PENWIDTH = 4;

        //For drawing 
        private Graphics canvas;
        private Pen pen;
        private Brush brush;
        private Worker patternWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialising all the objects
            canvas = CreateGraphics();
            pen = new Pen(Color.Black);
            pen.Width = PENWIDTH;
            brush = new SolidBrush(Color.Red);
            patternWorker = new Worker(canvas, pen, brush, BASECASE, PENWIDTH);
        }

        //Draws a triangle when the draw triangle button is clicked
        private void triangleBtn_Click(object sender, EventArgs e)
        {
            patternWorker.DrawAPattern(GetDepth(), EPatterns.Triangle);
        }

        //Draws a snowflake when the draw snowflake button is clicked
        private void snowflakeBtn_Click(object sender, EventArgs e)
        {
            patternWorker.DrawAPattern(GetDepth(), EPatterns.Snowflake);
        }

        //Draws a tree when the draw tree button is clicked
        private void treeBtn_Click(object sender, EventArgs e)
        {
            patternWorker.DrawAPattern(GetDepth(), EPatterns.Tree);
        }

        //Draws a square pyramid when the draw square button is clicked
        private void squaresBtn_Click(object sender, EventArgs e)
        {
            patternWorker.DrawAPattern(GetDepth(), EPatterns.Squares);
        }

        //Draws a dragon curve when the draw dragon curve button is clicked
        private void dragonBtn_Click(object sender, EventArgs e)
        {
            patternWorker.DrawAPattern(GetDepth(), EPatterns.DragonCurve);
        }

        //gets the entered depth
        private int GetDepth()
        {
            string depthString = depthTxtBox.Text.ToString();

            return Convert.ToInt32(depthString);
        }
    }
}
