using System;
using System.Collections.Generic;
using System.Text;

namespace _4._1
{
    class Penguin : Bird
    {
        public Penguin(String name, String diet, String location, double weight, int age,
           string colour, string birdSpecies, double wingSpan)
            : base(name, diet, location, weight, age, colour, birdSpecies, wingSpan)
        {

        }

        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly!!");
        }
    }
}
