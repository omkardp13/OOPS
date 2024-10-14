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

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
   
The choice between A obj = new B(); and B obj = new B(); relates to the concept of polymorphism in object-oriented programming, specifically runtime polymorphism. Here’s a breakdown of the reasons and implications of using each approach:

1. Using A obj = new B();
Base Class Reference: This line creates a reference obj of type A that points to an instance of B. This is significant because it allows you to treat the derived class (B) as if it were an instance of the base class (A).
    
Polymorphism: It enables polymorphism, meaning that you can use a base class reference to call methods that may be overridden in derived classes. When you call obj.Show(), the runtime determines that the actual object is of type B, so it calls the overridden Show() method in B.
Flexibility: This approach is useful in scenarios where you might want to handle different derived classes uniformly. For example, if you have multiple classes derived from A, you can create a collection of A references that can point to any of these derived classes. This allows for more flexible and extensible code.

2. Using B obj = new B();
Derived Class Reference: This line creates a reference obj of type B that points to an instance of B. In this case, since the reference type is the same as the object type, you can directly access methods and properties specific to class B.
No Polymorphism: If you only need to work with class B, you can certainly use this method. However, you lose the benefits of polymorphism, as the reference type B can only refer to objects of type B (and not to any of its base classes).
When to Use Each Approach:
Use A obj = new B(); when you want to take advantage of polymorphism. It’s particularly beneficial in scenarios involving collections of different derived types or when you want to pass objects to methods that accept base class parameters.

Use B obj = new B(); when you specifically need to work with the derived class and want direct access to its members. This is simpler and avoids the overhead of polymorphism if you don’t need it.

Example Scenario:
Here’s a practical scenario to illustrate the difference:

class Program
{
    static void ProcessObject(A obj)
    {
        obj.Show();
    }

    static void Main(string[] args)
    {
        A obj1 = new B();  // Polymorphism
        ProcessObject(obj1); // This will call B's Show() method

        B obj2 = new B();  // Direct reference
        obj2.Show(); // This will also call B's Show() method
    }
}
In the above example:

The ProcessObject method accepts a parameter of type A, allowing it to process any derived classes polymorphically.
You can pass an object of type B to ProcessObject, which allows for dynamic method resolution at runtime.
