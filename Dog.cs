using System;
public class Dog : Mammal
{
    // this is my constructor
    // it is called when something says = new Animal()
    public Dog()
    {
        Console.WriteLine("I'm creating a dog");
    }

    // Override says that we are replacing the Speak funcion from Animal
    public override string GenerateVoice()
    {
        return "woof";
        // Console.WriteLine("woof");
    }
}