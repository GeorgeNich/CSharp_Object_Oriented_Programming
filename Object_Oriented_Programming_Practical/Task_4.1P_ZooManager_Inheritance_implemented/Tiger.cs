using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    class Tiger : Feline
    {
       // private String species;
        private String colourStripes;

        public Tiger(String name, String diet, String location, double weight, int age, 
            string colour, string species, string colourStripes) : base(name, diet, location, weight, age, colour, species)
        {
            // this.species = species;
            this.colourStripes = colourStripes;
        }

        public override void makeNoise()
        {
            Console.WriteLine("ROOOOAAAAARRRRRRRRRR");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat 20lbs of meat");
        }

        public override void fly()
        {
            Console.WriteLine("Tigers cannot fly");
        }

    }
}
