using System;

namespace _4._1
{
    class Wolf : Animal
    {
       // private String species;
       //  private String colourStripes;

        public Wolf(String name, String diet, String location, double weight, int age,
            string colour) : base(name, diet, location, weight, age, colour)
        {
            //this.species = species;
            // this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("HOOOWWWWWWWLLLLLINNNNGGGGG");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 10lbs of meat");
        }

        public override void fly()
        {
            Console.WriteLine("Wolves cannot fly");
        }

        public override void sleep()
        {
            Console.WriteLine("Wolves dont sleep for long **DEMO**");

        }

    }
}
