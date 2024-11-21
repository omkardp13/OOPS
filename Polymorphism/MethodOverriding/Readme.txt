Method Overriding:Allows a subclass to provide a specific implementation of a method that is already defined in superclass.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------

Here’s an example to demonstrate method overriding in C# with and without using the virtual and override keywords:

1. Without virtual and override Keywords:

In this case, the derived class method hides the base class method with the same signature, but it’s not considered an override by the compiler.

using System;

class Animal
{
    public void Speak() // No 'virtual' keyword here
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public void Speak() // No 'override' keyword here
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog(); // Object of derived class but referenced by base class

        myAnimal.Speak(); // Output: The animal makes a sound.
        myDog.Speak();    // Output: The animal makes a sound. (method is not overridden)
    }
}

-----------------------------------------------------------------------------------------------------------------------------------------------
2. With virtual and override Keywords:

In this case, the derived class method properly overrides the base class method.

using System;

class Animal
{
    public virtual void Speak() // 'virtual' keyword allows the method to be overridden
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak() // 'override' keyword provides new implementation
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal();
        Animal myDog = new Dog(); // Object of derived class but referenced by base class

        myAnimal.Speak(); // Output: The animal makes a sound.
        myDog.Speak();    // Output: The dog barks. (method is overridden)
    }
}

-----------------------------------------------------------------------------------------------------------------------------------------------
Key Differences:

1.Without virtual and override: The derived class method hides the base class method, but if you reference the derived object through a base class reference (like Animal myDog = new Dog()), the base class method is called.

2.With virtual and override: The derived class method properly overrides the base class method, and when you call the method through a base class reference, the derived class's version of the method is invoked. This provides better clarity and more control over method overriding.
