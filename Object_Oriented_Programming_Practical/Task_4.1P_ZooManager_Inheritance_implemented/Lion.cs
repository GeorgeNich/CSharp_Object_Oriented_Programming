using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    class Lion : Feline
    {
        private String colourStripes;

        public Lion(String name, String diet, String location, double weight, int age,
            string colour, string species, string colourStripes) : base(name, diet, location, weight, age, colour, species)
        {
            // this.species = species;
            this.colourStripes = colourStripes;
        }
    }
}
