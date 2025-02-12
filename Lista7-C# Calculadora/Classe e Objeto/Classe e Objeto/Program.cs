﻿using System;

namespace Classe_e_Objeto
{
    public class Person
    {
        // Constructor that takes no arguments:
        public Person()
        {
            Name = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            Name = name;
        }

        // Auto-implemented readonly property:
        public string Name { get; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }
    class TestPerson
    {
        static void Main()
        {
            // Call the constructor that has no parameters.
            var person1 = new Person("Renata Nunes");
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2);
            
        }
    }
}
