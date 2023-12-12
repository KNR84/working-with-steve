using System;
public class Mammal : Animal
{
    // this is my constructor
    // it is called when something says = new Animal()
    public Mammal()
    {
        Console.WriteLine("I'm creating a mammal");
    }

    // Override says that we are replacing the Speak funcion from Animal
    public override string GenerateVoice()
    {
        return "unknown";
    }

    // Virtual is like a default
    public virtual void Move()
    {
        Console.WriteLine("I'm walking");
    }
}