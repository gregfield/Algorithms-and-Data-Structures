using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_Assignment1Fractals
{
    public class DragonCurve : IPattern
    {
        //drawing objects and basecase
        private Graphics canvas;
        private Pen pen;
        private Point[] startingPoints;
        private int baseCase;

        //Constructor initialises drawing objects and loads the starting points
        public DragonCurve(Graphics canvas, Pen pen, int baseCase)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.baseCase = baseCase;
            pen.Color = Color.Red;
            pen.Width = 1;
            startingPoints = new Point[]{new Point{X = 250, Y =  200}, new Point { X = 650, Y = 200}};
        }
 
        //Draws the pattern by calling the recursive function
        public void DrawPattern(int depth)
        {
            //clears the screen
            canvas.Clear(Color.White);
            //recursive call
            RecurseDragon(depth, startingPoints);
        }

        //Recursive function
        public void RecurseDragon(int depth, Point[] points)
        {
            //if the depth is equal to the base case which is 0 it draws a line
            if(depth == baseCase)
            {
                canvas.DrawLine(pen, points[0], points[1]);
            }
            else 
            {
                //makes a new set of points using the first point from the passed in array 
                //and the second is calculated to find the correct position
                Point[] newPoints = new Point[] { points[0], Calculations.CalculateDragonMidPoint(points)};
                //then calls recursive function with new points
                RecurseDragon(depth - 1, newPoints);

                //makes a new set of points using the second point from the passed in array 
                //and the second point is calculated to find the correct position
                newPoints = new Point[] { points[1], Calculations.CalculateDragonMidPoint(points) };
                //then recursive funtion is called
                RecurseDragon(depth - 1, newPoints);
            }
        }
    }
}
