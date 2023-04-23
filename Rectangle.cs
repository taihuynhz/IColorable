﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIColorable
{
    public class Rectangle : Shape, IColorable
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle()
        {

        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public double getWidth()
        {
            return width;
        }

        public virtual void setWidth(double width)
        {
            this.width = width;
        }

        public double getLength()
        {
            return length;
        }

        public virtual void setLength(double length)
        {
            this.length = length;
        }

        public double getArea()
        {
            return width * this.length;
        }

        public double getPerimeter()
        {
            return 2 * (width + this.length);
        }

        public override string ToString()
        {
            return "A Rectangle with width="
                    + getWidth()
                    + " and length="
                    + getLength()
                    + " and with area="
                    + getArea()
                    + ", which is a subclass of "
                    + base.ToString();
        }
    }
}
