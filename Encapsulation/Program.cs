
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1;
namespace ConsoleApp1
{

    public class Person
    {
        private string name; // Private field, encapsulated data

        public string Name // Public property, access to the name field
        {
            get { return name; }
            set { name = value; }
        }

        public Person(string name) // Constructor
        {
            this.name = name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John");
            Console.WriteLine(person.Name); // Accessing name through a public property
            Console.ReadKey();
        }
    }

}
