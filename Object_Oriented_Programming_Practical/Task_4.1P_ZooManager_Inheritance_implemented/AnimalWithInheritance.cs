using System;

namespace _4._1
{


    class Animal
    {
        private string name;
        private string diet;
        private string location;
        private double weight;
        private int age;
        private string colour;

        public Animal(String name, String diet, String location,
            double weight, int age, String colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }


        

        public virtual void eat()
        {
            Console.WriteLine("An animal eats");
        }

        public virtual void sleep()
        {
            Console.WriteLine("all animals sleep");
        }

        public virtual void makeNoise()
        {
            Console.WriteLine("An animals makes a noise");
        }

        public virtual void fly()
        {
            Console.WriteLine("only animals with wings can fly");
        }




    }

}


