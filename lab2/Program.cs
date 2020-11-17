using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10, 15);
            rect1.Print();

            Square square1 = new Square(10);
            square1.Print();

            Circle circle1 = new Circle(5);
            circle1.Print();

            Console.ReadKey();

        }
    }
}
