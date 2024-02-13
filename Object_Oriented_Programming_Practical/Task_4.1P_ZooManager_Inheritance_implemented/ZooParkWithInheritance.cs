using System;

namespace _4._1
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           // Animal williamWolf = new Animal("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
          //  Animal tonyTiger = new Animal("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White");
           // Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black");

            Tiger tonyTiger = new Tiger("Tony the Tiger", "meat", "Cat Land", 110, 6, "orange and white", "Siberian", "White");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");

           Penguin petePeng = new Penguin("Peter the Penguin", "fish", "Antartica", 200, 32, "Black", "King Penguin", 2);


            tonyTiger.makeNoise();

            Animal baseAnimal = new Animal("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");

            tonyTiger.eat();
            baseAnimal.eat();
            williamWolf.eat();
            edgarEagle.eat();

            tonyTiger.fly();
            baseAnimal.fly();
            williamWolf.fly();
            edgarEagle.fly();

            tonyTiger.sleep();
            baseAnimal.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();
            tonyTiger.eat();

            petePeng.fly();
            edgarEagle.fly();





        }

    }
}


