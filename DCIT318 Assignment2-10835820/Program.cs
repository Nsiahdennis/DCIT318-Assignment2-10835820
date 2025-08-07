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