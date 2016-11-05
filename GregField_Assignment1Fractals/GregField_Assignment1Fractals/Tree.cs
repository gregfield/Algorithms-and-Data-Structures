using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GregField_Assignment1Fractals
{
    public class Tree : IPattern
    {
        //Constant for when to change colour of the pen
        private const int COLOURDEPTH = 9;

        //drawing objects and basecase and line length and angle variables
        private Graphics canvas;
        private Pen pen;
        private Point startingPoint;
        private int baseCase;
        private int lineLength;
        private int startAngle;
        private int changeAngle;
        private int originalDepth;
        private double lengthAdjust;

        //Constructor initialises drawing objects and variables and loads the starting points
        public Tree(Graphics canvas, Pen pen, int baseCase)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.baseCase = baseCase;
            startingPoint = new Point{X = 400, Y =  600};
            lineLength = 150;
            startAngle = -90;
            changeAngle = 30;
            lengthAdjust = 0.75;
        }

        //Draws the pattern by calling the recursive function
        public void DrawPattern(int depth)
        {
            //for the change of pen colour
            originalDepth = depth;
            //clear the canvas
            canvas.Clear(Color.White);
            //call recursive function
            RecurseTree(depth, lineLength, startAngle, startingPoint);
        }

        //Recursive Function
        public void RecurseTree(int depth, int length, int angle, Point basePoint)
        {
            //calculates the second point for where the line is to go
            Point secondPoint = Calculations.TreeNewPoint(basePoint, length, angle);

            //if base case and depth the same it draws a line
            if(depth == baseCase)
            {
                pen.Color = Color.Green;
                canvas.DrawLine(pen, basePoint, secondPoint);
            }
            else
            {
                //if the deoth is greater than 9 it will change the pen colour to green
                if (originalDepth - depth > COLOURDEPTH)
                {
                    pen.Color = Color.Green;
                }
                else
                {
                    pen.Color = Color.Brown;
                }

                //draws a line so that each branch is drawn
                canvas.DrawLine(pen, basePoint, secondPoint);

                //makes the length of the branches smaller
                length =  (int) (length * lengthAdjust);

                //Recurses twice for each branch
                //minus the angle so it goes to the left
                RecurseTree(depth - 1, length, angle - changeAngle, secondPoint);
                //plus the angle so it goes to the right
                RecurseTree(depth - 1, length, angle + changeAngle, secondPoint);
            }
        }
    }
}
