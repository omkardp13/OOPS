using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    abstract class Shape
    {
       public Shape()
        {
            Console.WriteLine("In Shape Constrctor");
        }

       public abstract void Draw();

       public void Display()
       {
            Console.WriteLine("In Abstract Class Shape");
        }

    }
    class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("In Derived Class Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("In Derived Class Rectangle");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Circle obj1 = new Circle();
            obj1.Display();
            obj1.Draw();
            Console.WriteLine("*------------------------*");
            Rectangle obj2 = new Rectangle();
            obj2.Display();
            obj2.Draw();
            Console.Read();
        }
    }
}

/*OUTPUT
 * In Shape Constrctor
In Abstract Class Shape
In Derived Class Circle
*------------------------*
In Shape Constrctor
In Abstract Class Shape
In Derived Class Rectangle
 * 
 */