using Project;
using System;

namespace Project
{
    // ============================
    // 1. Inheritance & Overriding
    // ============================
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }


    // 2. Abstract Classes & Methods
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}

// 3. Interfaces
interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

// Main Program Entry Point
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DCIT 318 Assignment 2 ===\n");
        // Part 1: Inheritance and Overriding
        Console.WriteLine("1. Inheritance and Method Overriding:");
        Animal genericAnimal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();
        genericAnimal.MakeSound(); // Output: Some generic sound
        dog.MakeSound();           // Output: Bark
        cat.MakeSound();           // Output: Meow
        onsole.WriteLine("\n2. Abstract Classes and Methods:");
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");
        Console.WriteLine("\n3. Interfaces:");
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();
        car.Move();       // Output: Car is moving



