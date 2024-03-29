﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practicaltask5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>();
            Bird bird1 = new Bird();
            bird1.name = "Feathers";
            Bird bird2 = new Bird();
            bird2.name = "Polly";




            //////////////////////////////////////////////////

            Penguin penguin1 = new Penguin();
            penguin1.name = "Happy Feet";
            Penguin penguin2 = new Penguin();
            penguin2.name = "Gloria";


            Duck duck1 = new Duck();
            duck1.name = "Daffy";
            duck1.size = 15;
            duck1.kind = "Mallard";
            Duck duck2 = new Duck();
            duck2.name = "Donald";
            duck2.size = 20;
            duck2.kind = "Decoy";

            List<Duck> duckstoAdd = new List<Duck>()
            {
                duck1,
                duck2,
            };

            IEnumerable<Bird> upcastDucks = duckstoAdd;
            List<Bird> birds2 = new List<Bird>();
            birds.Add(new Bird() { name = "Feather" });

            birds2.AddRange(upcastDucks); //important

            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(penguin1);
            birds.Add(penguin2);
            birds.Add(duck1);
            birds.Add(duck2);
            
            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            foreach (Bird bird in birds2)
            {
                Console.WriteLine(bird);
            }
        }
    }
}
