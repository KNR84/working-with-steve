using System;
public class Cat : Mammal
{
    // this is my constructor
    // it is called when something says = new Animal()
    public Cat()
    {
        Console.WriteLine("I'm creating a cat");
    }

    // Override says that we are replacing the Speak funcion from Animal
    public override string GenerateVoice()
    {
       return "meow";
    }
}