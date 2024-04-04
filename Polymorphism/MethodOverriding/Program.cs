using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimePolymorphism
{
    class Program
    {
        //Override:Method is same as in base class and derived class.
        //RunTime-Polymorphism:When we don't know which method will be executed it only depends on object.

        /*
         * Class A contains a virtual method called Show(), and it is marked with the virtual keyword. 
         * The virtual keyword allows the method to be overridden by derived classes.
         */
        class A
        { 
        
            public virtual void Show()
            {
                Console.WriteLine("Class A");
            }
        }

        /*
         * Class B overrides the Show() method from class A using the override keyword. Inside the overridden method, 
         * it first calls the base class (A) Show() method using base.Show() and then prints "Class B" to the console.
         * */
        class B :A
        {
                        
            public override void Show()
            {
                base.Show(); //If we commented this line it only called class B show mwthod.
                Console.WriteLine("Class B");
            }
        }

        /*
         * Since the Show() method is marked as virtual in class A and overridden in class B, the actual method that gets executed is determined at runtime based on the type of the object.
         * In this case, it prints both "Class A" and "Class B" because the overridden method in class B calls the base class method using base.Show().
         * So, when you run the program, it will only print "Class B" to the console. 
         * This demonstrates how runtime polymorphism works – the actual method that gets executed is determined at runtime based on the actual type of the object (B in this case). 
         * Since the Show() method is overridden in class B and the base class method call is skipped, only the code within the overridden method in B is executed. 
         */

        static void Main(string[] args)
        {
            A obj = new B();
            obj.Show();
            Console.Read();


            /*
In this modified example, we are creating an object of class B and assigning it to a reference of type A. This is allowed because of polymorphism - you can assign an object of a derived class (B) to a reference of a base class (A).

Now, even though the reference obj is of type A, it's actually pointing to an object of type B. When you call obj.Show(), the method executed is determined by the runtime type of the object, which is B. Therefore, the Show() method of class B is executed, and "Class B" is printed to the console.

This is runtime polymorphism because the decision about which method to execute (Show() method of class A or B) is made at runtime based on the actual type of the object (B in this case), not the type of the reference (A in this case). Even though you didn't explicitly call the base class method, the mechanism of runtime polymorphism ensures that the correct method is executed based on the object's type at runtime.

            */
        }
    }
}
