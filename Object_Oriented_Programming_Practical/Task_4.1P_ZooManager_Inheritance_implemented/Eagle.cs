using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    class Eagle : Bird
    {
        //private String species;
       // private String colourStripes; DOESNT USE STRIPES
       // private double wingSpan;

        public Eagle(String name, String diet, String location, double weight, int age,
            string colour, string birdSpecies, double wingSpan) : base(name, diet, location, weight, age, colour, birdSpecies, wingSpan)
        {
            //this.species = species;
           // this.colourStripes = colourStripes;  DOESNT USE STRIPES
            //this.wingSpan = wingSpan;
        }

        public override void makeNoise()
        {
            Console.WriteLine("*Whistle whistle*");
        }

        public void layEgg()
        {
            Console.WriteLine("lays eggs");
        }

        public override void fly()
        {
            Console.WriteLine("Eagles can Fly");
        }

        public override void eat()
        {
            Console.WriteLine("I can eat one pound of fish");
        }

    }
}
