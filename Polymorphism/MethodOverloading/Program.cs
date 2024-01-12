using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTimePolymorphism
{

    //Compile-Time Polymorphism-In compile-time polymorphism we know that which function will be called after executing the program.
    //Method Overloading
    /*
     *  Compile-time polymorphism occurs when you have multiple methods with the same name in a class, 
     *  but they differ in terms of the number or types of their parameters
     */
    class Program
    {

        public void Addition()
        {
            int a = 10, b = 20;
            int res = a +b;
            Console.WriteLine("Addition is:"+res);
        }

        public void Addition(int a,int b)
        {
            int res = a + b;
            Console.WriteLine("Addition is:" + res);
        }
        public void Addition(double a, double b)
        {
            double res = a + b;
            Console.WriteLine("Addition is:" + res);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Addition();
            obj.Addition(50,60);
            obj.Addition(12.5, 13.7);
            Console.Read();
        }
    }
}
