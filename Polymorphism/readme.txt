Polymorphism --->Many-Forms
Occurs when many classes that are related to each other by inheritance.

Two Types:1.Compile-Time Polymorphism(Static Polymorphism)--->Method Overloading.
          2.Run-Time Polymorphism(Dynamic Polymorphism)--->Method Overriding.

----------------------------------------------------------------------------------------------------------------------
In object-oriented programming, the terms reference and instance are fundamental concepts that are closely related but have distinct meanings. Here’s a breakdown of the differences between the two:

1.Instance : 
Definition: An instance refers to a specific realization of a class.
When you create an object from a class, you are creating an instance of that class.
Memory Allocation: When an instance is created, memory is allocated for it, and it contains all the properties and methods defined in the class.
Each instance has its own state and behavior.
Example: If you have a class named Car, creating a new object from this class (e.g., Car myCar = new Car();) means you have an instance of Car named myCar. Each Car instance can have different values for its properties (like color, model, etc.).

----------------------------------------------------------------------------------------------------------------------

2.Reference
Definition: A reference is a variable that holds the address of an instance in memory.
It allows you to access the instance’s methods and properties.
No Memory for Data: A reference itself does not contain the actual data of the instance.
Instead, it points to the location in memory where the instance is stored.
Multiple References: Multiple references can point to the same instance. For example, if you assign one reference to another (e.g., Car myCar2 = myCar;), both myCar and myCar2 refer to the same Car instance.
Example: Using the previous example, Car myCar = new Car(); creates a reference named myCar that points to the instance of Car. If you have another reference like Car myCar2 = myCar;, both myCar and myCar2 refer to the same Car instance.

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
     Instance                           |       Reference
1.A specific object created from a class. | A variable that holds the address of an instance.

2.Allocates memory for the data and state of the object. | Does not allocate memory for the object’s data; only holds the memory address.

3.Represents the actual object with its own state. | Represents a pointer to an object and does not own the object.

4.An instance can exist independently. | Multiple references can point to the same instance.

----------------------------------------------------------------------------------------------------------------------

Visual Representation: 

Creating an Instance:

Car myCar = new Car();  // 'myCar' is a reference to a new instance of 'Car'


References:

Car myCar2 = myCar; // Both 'myCar' and 'myCar2' reference the same instance of 'Car'


In summary, an instance is the actual object created from a class, while a reference is a variable that points to that object in memory. Understanding this distinction is crucial for effective programming in object-oriented languages, as it impacts how you manage memory and object interactions.
