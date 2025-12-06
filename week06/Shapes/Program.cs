using System;

class Program
{
    static void Main(string[] args)
    {
        Animal basicAnimal = new Animal();
        Animal pig = new Pig();
        Animal dawg = new Dawg();
        Animal cat = new Cat();

        basicAnimal.animalSound();
        pig.animalSound();
        dawg.animalSound();
        cat.animalSound();


    }
}