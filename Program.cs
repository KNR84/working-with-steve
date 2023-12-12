using System;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            // Mammal d is declaring
            // d = new Dog() is instantiating
            // Dog() is calling the class's constructor
            Mammal d = new Dog();
            d.Speak();
            d.Breathe();
            d.Move();


            BeNoisey(d);
            // d.Yell();
            Console.WriteLine("---------------");
            Mammal c = new Cat();
            c.Speak();
            c.Breathe();
            c.Move();
            BeNoisey(c);

            Console.WriteLine("---------------");

            Mammal w = new Whale();
            w.Speak();
            w.Breathe();
            BeNoisey(w);
            w.Move();


        }

        public static void BeNoisey(Animal a)
        {
            a.Yell();
        }
    }
}
