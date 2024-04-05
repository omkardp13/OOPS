using ConsoleApp1;
using System;


public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.Method(10);          // Output: Method(int) from File1.cs: 10
        obj.Method("Hello");
    }
}
