using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    class Feline : Animal
    {
        private string species;

        public Feline(string name, string diet, string location, 
            double weight, int age, string colour, string species)
            :base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        public override void sleep()
        {
            Console.WriteLine("FELINE SLEEP");
        }
    }
}
