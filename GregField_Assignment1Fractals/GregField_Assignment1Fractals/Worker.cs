using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregField_Assignment1Fractals
{
    public enum EPatterns{DragonCurve, Snowflake, Squares, Tree, Triangle}

    public class Worker
    {
        //drawing objects and basecase to be passed to objects
        private Graphics canvas;
        private Pen pen;
        private Brush brush;
        private int baseCase;
        private int penWidth;

        //Constructor initialises drawing objects
        public Worker(Graphics canvas, Pen pen, Brush brush, int baseCase, int penWidth)
        {
            this.canvas = canvas;
            this.pen = pen;
            this.brush = brush;
            this.baseCase = baseCase;
            this.penWidth = penWidth;
        }

        //creates the required objects then calls the patterns to draw
        public void DrawAPattern(int depth, EPatterns pattern)
        {
            pen.Color = Color.Black;
            pen.Width = penWidth;
            switch(pattern)
            {
                case EPatterns.DragonCurve:
                     DragonCurve dragon = new DragonCurve(canvas, pen, baseCase);
                     dragon.DrawPattern(depth);
                     break;

                case EPatterns.Snowflake:
                     Snowflake snowflake = new Snowflake(canvas, pen, baseCase);
                     snowflake.DrawPattern(depth);
                     break;

                case EPatterns.Squares:
                     Squares sq = new Squares(canvas, pen, brush, baseCase);
                     sq.DrawPattern(depth);
                     break;

                case EPatterns.Tree:
                     Tree tree = new Tree(canvas, pen, baseCase);
                     tree.DrawPattern(depth);
                     break;

                case EPatterns.Triangle:
                    Triangle triangle = new Triangle(canvas, pen , brush, baseCase);
                    triangle.DrawPattern(depth);
                    break;
            }
        }
    }
}
