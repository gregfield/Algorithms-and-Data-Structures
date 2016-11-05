using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_Assignment1Fractals
{
    public class Squares : IPattern
    {
        //drawing objects and basecase
        private Graphics canvas;
        private Pen pen;
        private Brush brush;
        private int baseCase;

        //Constructor initialises drawing objects
        public Squares(Graphics canvas, Pen pen, Brush brush, int baseCase)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.brush = brush;
            this.baseCase = baseCase;
        }

        //Draws the pattern by calling the recursive function
        public void DrawPattern(int depth)
        {
            //clears the canvas
            canvas.Clear(Color.White);
            //creates a rectangle
            Rectangle rectangle = new Rectangle(275, 175, 200, 200);
            //calls recursive function
            RecurseSquares(depth, rectangle);
        }

        //Recursive function
        public void RecurseSquares(int depth, Rectangle rectangle)
        {
            //if the depth is equal to the base case which is 0 it draws a rectangle
            if(depth == baseCase)
            {
                canvas.DrawRectangle(pen, rectangle);
                canvas.FillRectangle(brush, rectangle);
            }
            else
            {
                //First Recursion
                //Top Left rectangle
                Rectangle newRectangle = Calculations.CalculateTopLeftRectangle(rectangle);
                RecurseSquares(depth - 1, newRectangle);

                //Second Recursion
                //Top right rectangle
                newRectangle = Calculations.CalculateTopRightRectangle(rectangle);
                RecurseSquares(depth - 1, newRectangle);

                //Third Recursion
                //Bottom Left rectangle
                newRectangle = Calculations.CalculateBottomLeftRectangle(rectangle);
                RecurseSquares(depth - 1, newRectangle);

                //Fourth Recursion
                //Bottom Right rectangle
                newRectangle = Calculations.CalculateBottomRightRectangle(rectangle);
                RecurseSquares(depth - 1, newRectangle);

                //Draws the current rectangle
                //put after so that it is drawn on top of the smaller ones
                canvas.DrawRectangle(pen, rectangle);
                canvas.FillRectangle(brush, rectangle);
            }
        }
    }
}
