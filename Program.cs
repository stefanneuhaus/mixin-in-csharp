using System;
using Drinker;
using Singer;

class Bird : MSinger, MDrinker { }

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Bird:");
        Bird bird = new Bird();
        bird.Sing();
        bird.Drink();
    }
}