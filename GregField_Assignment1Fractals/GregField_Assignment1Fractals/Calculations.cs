using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_Assignment1Fractals
{
    public static class Calculations
    {
        /*
         * Dragon Curve Calculation
        */
        //calculates the midpoint so that the line can be drawn to that point then to the end point
        public static Point CalculateDragonMidPoint(Point[] points)
        {
            int newX = (points[0].X + points[1].X) / 2 + (points[0].Y - points[1].Y) / 2;
            int newY = (points[0].Y + points[1].Y) / 2 - (points[0].X - points[1].X) / 2;

            return new Point(newX, newY);
        }


        /*
         * Snowflake Calculation
        */
        //Calculates the points at 1/3 of the position of the line and then returns that point
        public static Point CalculateSnowflakeOneThrid(int x1, int x2, int y1, int y2)
        {
            double totX = x2 - x1;
            double totY = y2 - y1;

            Point newPoint = new Point { X = (int)(x1 + totX / 3), Y = (int)(y1 + totY / 3) };
            return newPoint;
        }

        //Calculates the points at 2/3 of the position of the line and then returns that point
        public static Point CalculateSnowflakeTwoThrids(int x1, int x2, int y1, int y2)
        {
            double totX = x2 - x1;
            double totY = y2 - y1;

            Point newPoint = new Point { X = (int)(x1 + totX * 2 / 3), Y = (int)(y1 + totY * 2 / 3) };
            return newPoint;
        }

        //Calculates the middle point for where the two lines going up meet then returns that point
        public static Point CalculateSnowflakeMiddlePoint(int x1, int x2, int y1, int y2)
        {
            double totX = x1 + x2;
            double totY = y1 + y2;

            double newX = (int)(totX / 2 + (Math.Sqrt(3.0) / 6) * (y1 - y2));
            double newY = (int)(totY / 2 + (Math.Sqrt(3.0) / 6) * (x2 - x1));

            Point newPoint = new Point { X = (int)newX, Y = (int)newY };

            return newPoint;
        }

        //switches point for when start point for one recursion is end point of the previous
        public static Point[] SnowflakeSwitchPoints(Point[] points)
        {
            Point temp = points[0];
            points[0] = points[1];
            points[1] = temp;

            return points;
        }

        /*
         * Square Calculations
        */

        //Calculates the top left rectangle
        public static Rectangle CalculateTopLeftRectangle(Rectangle rectangle)
        {
            //reduces the height and width
            rectangle.Height /= 2;
            rectangle.Width /= 2;

            //calculates the new starting coordinates
            rectangle.X = rectangle.X - rectangle.Width / 2;
            rectangle.Y = rectangle.Y - rectangle.Height / 2;

            return rectangle;
        }

        //Calculates the top right rectangle

        public static Rectangle CalculateTopRightRectangle(Rectangle rectangle)
        {
            //reduces the height and width
            Rectangle newRectangle = rectangle;
            newRectangle.Height /= 2;
            newRectangle.Width /= 2;

            //calculates the new starting coordinates
            newRectangle.X = (rectangle.X + rectangle.Width) - newRectangle.Width / 2;
            newRectangle.Y = rectangle.Y - newRectangle.Height / 2;

            return newRectangle;
        }

        //Calculates the bottom left rectangle
        public static Rectangle CalculateBottomLeftRectangle(Rectangle rectangle)
        {
            //reduces the height and width
            Rectangle newRectangle = rectangle;
            newRectangle.Height /= 2;
            newRectangle.Width /= 2;

            //calculates the new starting coordinates
            newRectangle.X = rectangle.X - newRectangle.Width / 2;
            newRectangle.Y = (rectangle.Y + rectangle.Height) - newRectangle.Height / 2;

            return newRectangle;
        }

        //Calculates the bottom right rectangle
        public static Rectangle CalculateBottomRightRectangle(Rectangle rectangle)
        {
            //reduces the height and width
            Rectangle newRectangle = rectangle;
            newRectangle.Height /= 2;
            newRectangle.Width /= 2;

            //calculates the new starting coordinates
            newRectangle.X = (rectangle.X + rectangle.Width) - newRectangle.Width / 2;
            newRectangle.Y = (rectangle.Y + rectangle.Height) - newRectangle.Height / 2;

            return newRectangle;
        }

        /*
         * Tree Calculations
        */

        //makes a new point using a line length a starting point and an angle
        public static Point TreeNewPoint(Point startPoint, int length, int angle)
        {
            int startX = startPoint.X;
            int startY = startPoint.Y;

            double radiansAngle = angle * 0.01745;

            double xDelta = Math.Cos(radiansAngle) * length;
            double yDelta = Math.Sin(radiansAngle) * length;

            int endX = startX + (int)xDelta;
            int endY = startY + (int)yDelta;

            return new Point { X = endX, Y = endY };
        }

        /*
         * Triangle Calculations
        */

        //gets the middle point for each recursion
        public static Point GetTriangleMiddlePoint(Point firstPoint, Point secondPoint)
        {
            Point newPoint = new Point();

            //gets the middle by finding the middle point between both of the Y points and then both of the X points
            newPoint.Y = (firstPoint.Y + secondPoint.Y) / 2;
            newPoint.X = (firstPoint.X + secondPoint.X) / 2;

            return newPoint;
        }
    }
}
