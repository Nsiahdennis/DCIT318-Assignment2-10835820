# DCIT 318 Assignment 2 – C# Console Application

This project is a submission for **DCIT 318: Programming II – Assignment 2**. It is a C# console application that demonstrates key concepts of **object-oriented programming (OOP)**, including:

1. Inheritance and Method Overriding  
2. Abstract Classes and Methods  
3. Interfaces and Implementation  

Project Structure

1. Inheritance and Method Overriding

 A base class `Animal` contains a virtual method `MakeSound()` that prints `"Some generic sound"`.
 Two derived classes:
   `Dog` overrides `MakeSound()` to print `"Bark"`.
   `Cat` overrides `MakeSound()` to print `"Meow"`.
 Demonstrates **polymorphism** and method overriding in C#.

 2. Abstract Classes and Methods
     An abstract base class `Shape` defines an abstract method `GetArea()`.
 Derived classes:
   `Circle` implements `GetArea()` using the formula `π × r²`.
   `Rectangle` implements `GetArea()` using the formula `width × height`.
 Shows how **abstract classes enforce method implementation** in derived classes

3. Interfaces

An interface `IMovable` defines a method `Move()`.
Implemented by:
   `Car` class – prints `"Car is moving"`.
   `Bicycle` class – prints `"Bicycle is moving"`.
 Demonstrates **interface implementation** and polymorphism via interfaces.
 Sample Output

=== DCIT 318 Assignment 2 ===

Inheritance and Method Overriding:
Some generic sound
Bark
Meow

Abstract Classes and Methods:
Circle Area: 78.54
Rectangle Area: 24.00

Interfaces:
Car is moving
Bicycle is moving


-
