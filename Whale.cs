using System;
public class Whale : Mammal
{
    // this is my constructor
    // it is called when something says = new Animal()
    public Whale()
    {
        Console.WriteLine("I'm creating a whale");
    }

    // Override says that we are replacing the Speak funcion from Animal
    public override string GenerateVoice()
    {
       return "blaaaaajaha";
    }

    public override void Move()
    {
        Console.WriteLine("I am swimming");   
    }
}