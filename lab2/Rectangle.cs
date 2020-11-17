using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Rectangle : GeometricShape, IPrint
    {
        public double height { get; set; }
        public double width { get; set; }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double Square()
        {
            return Math.Round(this.height * this.width,2);
        }


        public override string ToString()
        {
            return ("height: " + this.height + "  width: " + this.width + "  Square: " +this.Square());
        }

        public void Print()
        {
           Console.WriteLine(this.ToString());
        }
    }
}
