using System;
public class Animal
{
    // this is my constructor
    // it is called when something says = new Animal()
    public Animal()
    {
        Console.WriteLine("I'm creating an animal");
    }

// Virtual says that anything that is an animal can make their own Speak function
    public virtual string GenerateVoice()
    {
        return "unknown";
        // Console.WriteLine("unknown");
    }
    public void Breathe()
    {
        Console.WriteLine("sigh");
    }

    public void Speak(){
        Console.WriteLine(GenerateVoice());
    }

    public void Yell(){
        string voice = GenerateVoice();
        Console.WriteLine(voice.ToUpper());
    }
}