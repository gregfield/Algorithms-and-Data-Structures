using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_Assignment1Fractals
{
    public class Snowflake : IPattern
    {
        //drawing objects and basecase
        private Graphics canvas;
        private Pen pen;
        private int baseCase;

        //Constructor initialises drawing objects
        public Snowflake(Graphics canvas, Pen pen, int baseCase)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.baseCase = baseCase;
        }

        //Draws the pattern by calling the recursive function
        public void DrawPattern(int depth)
        {
            //clears the canvas
            canvas.Clear(Color.White);

            //makes the starting points for the three lines
            Point[] startingPoint1 = new Point[] { new Point { X = 400, Y = 20 }, new Point { X = 200, Y = 420 } };
            Point[] startingPoint2 = new Point[] { new Point { X = 200, Y = 420 }, new Point { X = 600, Y = 420 } };
            Point[] startingPoint3 = new Point[] { new Point { X = 600, Y = 420 }, new Point { X = 400, Y = 20 } };

            //calls the recursive function on each of the three lines
            //needs to be done three times so that it creates a triangle
            RecurseSnowflake(depth, startingPoint1);
            RecurseSnowflake(depth, startingPoint2);
            RecurseSnowflake(depth, startingPoint3);
        }

        //Recursive function to draw the snowflake
        public void RecurseSnowflake(int depth, Point[] linePoints)
        {
            //if the depth is equal to the basecase it draws a line
            if(depth == baseCase)
            {
                canvas.DrawLine(pen, linePoints[0], linePoints[1]);
            }
            else
            {
                // the x and y coordinates for each of the lines
                int x1 = linePoints[0].X;
                int y1 = linePoints[0].Y;
                int x2 = linePoints[1].X;
                int y2 = linePoints[1].Y;

                //first recursion
                //first point same the second is 1/3 of line then recurses
                Point[] newPoints = linePoints;
                newPoints[1] = Calculations.CalculateSnowflakeOneThrid(x1,x2,y1,y2);
                RecurseSnowflake(depth - 1, newPoints);

                //second recursion
                //first point is the second point of first recursion second point is calculated
                //then reucrses
                newPoints = Calculations.SnowflakeSwitchPoints(newPoints);
                newPoints[1] = Calculations.CalculateSnowflakeMiddlePoint(x1, x2, y1, y2);
                RecurseSnowflake(depth - 1, newPoints);

                //third recursion
                //first point is the second point of second recursion
                //second is 2/3 of original line
                //then reurses
                newPoints = Calculations.SnowflakeSwitchPoints(newPoints);
                newPoints[1] = Calculations.CalculateSnowflakeTwoThrids(x1, x2, y1, y2);
                RecurseSnowflake(depth - 1, newPoints);

                //fourth recursion 
                //first point is the second point of third recursion
                //second point is second point of original points
                //then recurses
                newPoints = Calculations.SnowflakeSwitchPoints(newPoints);
                newPoints[1] = new Point { X = x2, Y = y2 };
                RecurseSnowflake(depth - 1, newPoints);
            }
        }
    }
}
