using System;

class Program
{
    // Define an interface with properties
    public interface IVehicle
    {
        string Make { get; set; }  // Read-write property
        string Model { get; set; } // Read-write property
        int Year { get; }          // Read-only property
    }

    // Implement the interface in a class
    public class Car : IVehicle
    {
        public string Make { get; set; }  // Implement the property
        public string Model { get; set; } // Implement the property
        public int Year { get; private set; } // Read-only implementation

        // Constructor to initialize properties
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }

   
    
        static void Main(string[] args)
        {
            IVehicle myCar = new Car("Toyota", "Camry", 2022);
            Console.WriteLine($"Make: {myCar.Make}, Model: {myCar.Model}, Year: {myCar.Year}");
        }
    

   
    
}
