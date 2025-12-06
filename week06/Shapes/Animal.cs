using System;

class Animal()
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a noise:");
    
    }
}
class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("oink oink");
    }
}

class Dawg : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("woof woof");
    }
}

class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("meow meow");
    }
}