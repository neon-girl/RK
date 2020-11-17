using System;
using System.Collections.Generic;
using System.Text;

namespace Laba2
{
    class Circle : Rectangle, IPrint
    {
        public Circle (double a) : base(Math.PI, a) {}

        public override string ToString()
        {
            return ("side: " + this.width + "  square: " + this.Square());
        }

    }
}
