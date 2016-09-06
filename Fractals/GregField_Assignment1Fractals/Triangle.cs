using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_Assignment1Fractals
{
    public class Triangle : IPattern
    {
        //drawing objects and basecase
        private Graphics canvas;
        private Pen pen;
        private Brush brush;
        private Point[] startingPoints;
        private int baseCase;

        //Constructor initialises drawing objects and loads the starting points
        public Triangle(Graphics canvas, Pen pen, Brush brush, int baseCase)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.brush = brush;
            this.baseCase = baseCase;
            startingPoints = new Point[]{ new Point { X = 400, Y = 20 }, new Point { X = 200, Y = 420 }, new Point { X = 600, Y = 420 } };
        }

        //Calls the Recursive method to make the triangles
        public void DrawPattern(int depth)
        {
            canvas.Clear(Color.White);
            RecurseTriangle(depth, startingPoints);
        }

        public void RecurseTriangle(int depth, Point[] trianglePoints)
        {
            //if it reaches the base case which is 0 a triangle is drawn
            if(depth == baseCase)
            {
                DrawTriangle(trianglePoints);
            }
            else
            {
                //making new points for the first recursion
                Point newPoint1 = Calculations.GetTriangleMiddlePoint(trianglePoints[0], trianglePoints[1]);
                Point newPoint2 = Calculations.GetTriangleMiddlePoint(trianglePoints[0], trianglePoints[2]);
                RecurseTriangle(depth - 1, new Point[]{ trianglePoints[0], newPoint1, newPoint2});

                //making new points for second recursion
                newPoint1 = Calculations.GetTriangleMiddlePoint(trianglePoints[0], trianglePoints[1]);
                newPoint2 = Calculations.GetTriangleMiddlePoint(trianglePoints[1], trianglePoints[2]);
                RecurseTriangle(depth - 1, new Point[]{ newPoint1, trianglePoints[1], newPoint2});

                //making new points for third recursion
                newPoint1 = Calculations.GetTriangleMiddlePoint(trianglePoints[0], trianglePoints[2]);
                newPoint2 = Calculations.GetTriangleMiddlePoint(trianglePoints[1], trianglePoints[2]);
                RecurseTriangle(depth - 1, new Point[]{ newPoint1, newPoint2, trianglePoints[2]});
            }
        }

        //Draws the triangle at the points required
        public void DrawTriangle(Point[] trianglePoints)
        {
            canvas.DrawPolygon(pen, trianglePoints);
            canvas.FillPolygon(brush, trianglePoints);
        }
    }
}
