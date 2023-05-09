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
            animal01.set_name("Joliene");
            animal01.describe();
            Console.WriteLine("First animal");


            Console.WriteLine("Second animal");
            Animal animal02 = new Animal();
            animal02.set_name("Keith");
            animal02.describe();


            // Creating a PET

            Pet pet01 = new Pet();   // INSTANTIATING a Pet object
            pet01.set_name("Tiddles");
            pet01.play();
            pet01.describe();
            pet01.Owner = "Stewart";
            pet01.owner_details();

            Pet pet02 = new Pet();   // INSTANTIATING a Pet object
            pet02.set_name("Nigel");
            pet02.play();
            pet02.describe();
            pet02.Owner = "Gareth";
            pet02.owner_details();


            // INSTANTIATING a Dog object
            Dog dog01 = new Dog();
            dog01.Owner = "Tom thumb";
            dog01.describe();
            dog01.WagTail(10);



            Console.ReadLine();

        }

        public class Animal
        {
            // Attributes for the Animal class
            public string name;
            protected string colour;
            private int numberOfLegs;

            // Constructor method
            public Animal(string Name = "AnimalName")
            {
                // Assigning default values to the attributes for the Animal class
                name = Name;
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

        // Creating an INHERITED/DERIVED class (Pet class)
        //          from the BASE class (Animal)
        //         : means inheritance
        public class Pet : Animal
        {

            // Attributes
            private string owner;
            private string breed;

            // Propeties
            public string Owner
            {
                get { return owner; }
                set { owner = value; }

            }
            public string Breed
            {
                get { return breed; }
                set { breed = value; }

            }

            // Methods

            public Pet(string Name = "PetName") : base(Name)
            {
                Console.WriteLine("Instantiated a Pet object derived/inherited from the Animal class");
                play();
            }

            public void play()
            {
                Console.WriteLine("{0} enjoys playing with it's toy. ", get_name());
            }

            public void owner_details()
            {
                Console.WriteLine("The owner of {0} is {1}", get_name(), Owner);
            }
        }

        // Creating an INHERITED/DERIVED class (Dog class) from the PARENT class (Pet)
        public class Dog : Pet
        {
            public Dog(string Name = "DogName") : base(Name)
            {
                Console.WriteLine("Instantiated a Dog object derived/inherited from the Pet class");
                WagTail();
                play();
            }

            public void WagTail(int numberOfTimes = 3)
            {
                for (int i = 0; i < numberOfTimes; i++)
                {
                    Console.WriteLine("Tail Wag!!");
                }
            }
        }
    }
}
