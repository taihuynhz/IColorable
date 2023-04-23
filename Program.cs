﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIColorable
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Shape Test
            //Shape shape = new Shape();
            //Console.WriteLine(shape);

            //shape = new Shape("red", false);
            //Console.WriteLine(shape);

            //// Circle Test
            //Circle circle = new Circle();
            //Console.WriteLine(circle);

            //circle = new Circle(3.5);
            //Console.WriteLine(circle);

            //circle = new Circle(3.5, "indigo", false);
            //Console.WriteLine(circle);

            //// Square Test
            //Square square = new Square();
            //Console.WriteLine(square);
            //square.HowToColor();

            //square = new Square(2.3);
            //Console.WriteLine(square);

            //square = new Square(5.8, "yellow", true);
            //Console.WriteLine(square);

            Shape[] shapes = new Shape[3];
            
            shapes[0] = new Circle(3.5, "indigo", false);
            shapes[1] = new Rectangle(5, 7.5, "indigo", false);
            shapes[2] = new Square(5.8, "yellow", true);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);

                Square square = shape as Square;
                if (square != null)
                {
                    square.HowToColor();
                }
            }
        }
    }
}
