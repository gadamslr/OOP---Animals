using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal01 = new Animal();
            animal01.describe();
            Console.WriteLine("First animal");
            

            Console.WriteLine("Second animal");
            Animal animal02 = new Animal();
            animal02.describe();
            Console.ReadLine();

        }

        public class Animal
        {
            // Attributes for the Animal class
            public string name;
            protected string colour;
            private int numberOfLegs;

            // Constructor method
            public Animal()
            {
                // Assigning default values to the attributes for the Animal class
                name = "AnimalName";
                colour = "Black";
                numberOfLegs = 0;
            }

            // Animal class - METHODS

            // Method to get name of Animal
            public string get_name()
            {
                return name;
            }


            // Method to get colour of Animal
            public string get_colour()
            {
                return colour;
            }
            // Method to get numberOfLegs of Animal
            public int get_numberOfLegs()
            {
                return numberOfLegs;
            }

            public void describe()
            {
                Console.WriteLine("Name of Animal is: {0}", get_name());
                Console.WriteLine("Colour of Animal is: {0}", get_colour());
                Console.WriteLine("The Animal has {0} legs", get_numberOfLegs());
            }

            // SETTER Method to **SET** name of Animal
            public void set_name(string Name)
            {
                name = Name;
            }

            public void greeting()
            {
                Console.WriteLine("Hello, my name is {0}. \n How are you doing?", name);
            }
        }
    }
}
