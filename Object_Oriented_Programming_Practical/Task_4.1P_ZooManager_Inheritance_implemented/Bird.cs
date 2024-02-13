using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    class Bird : Animal
    {
        private string birdSpecies;
        private double wingSpan;
        public Bird(String name, String diet, String location, double weight, int age,
            string colour, string birdSpecies, double wingSpan) : base(name, diet, location, weight, age, colour)
        {
            this.birdSpecies = birdSpecies;
            this.wingSpan = wingSpan;
            // this.colourStripes = colourStripes;
        }

        public override void fly()
        {
            Console.WriteLine("BIRDS CAN FLY");
        }

    }
}
