using System;

public class MyClass
{

    private int number;
    private string text;

    // Default constructor
    public MyClass()
    {
        number = 0;
        text = "Default";
    }

    // Constructor with one parameter
    public MyClass(int num)
    {
        number = num;
        text = "Constructor with one parameter";
    }

    // Constructor with two parameters
    public MyClass(int num, string txt)
    {
        number = num;
        text = txt;
    }

    // Method to display the values
    public void Display()
    {
        Console.WriteLine($"Number: {number}, Text: {text}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects using different constructors
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass(10);
        MyClass obj3 = new MyClass(20, "Custom Text");

        // Displaying values
        obj1.Display();
        obj2.Display();
        obj3.Display();
        Console.ReadLine();
    }
}
